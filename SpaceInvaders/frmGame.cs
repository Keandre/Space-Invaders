using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace SpaceInvaders
{
    public partial class frmGame : Form
    {
        //global variables
        public int LevelCounter = 0, TickCounter = 0, Countdown = 5;

        //constructor for game form
        public frmGame()
        {
            InitializeComponent();
            List.player = new Player(this);
            LevelCounter = 0;
            DestroyEverything();
            SpawnEnemies();
            Sound.ChangeSoundURL("Fire.mp3");
            Sound.ChangeMusicURL("Game.mp3");

            if (!File.Exists("Level.txt"))
            {
                using (StreamWriter sw = File.CreateText("Level.txt"))
                {
                    sw.Write("1");
                }
            }
        }
        //overloaded constructor
        public frmGame(int Level)
        {
            InitializeComponent();
            List.player = new Player(this);
            LevelCounter = Level;
            DestroyEverything();
            SpawnEnemies();
            Sound.ChangeSoundURL("Fire.mp3");
            Sound.ChangeMusicURL("Game.mp3");
            lblLevel.Text = "Level " + Level;
        }

        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            //if key is pressed call method in list class
            List.player.InputDown(e);
        }

        private void frmGame_KeyUp(object sender, KeyEventArgs e)
        {
            //if key is released call method in list class
            List.player.InputUp(e);
        }

        private void mnuGoHome_Click(object sender, EventArgs e)
        {
            //navigate to home form
            frmHome Home = new frmHome();
            this.Hide();
            Home.Show();
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            //close program
            this.Close();
            Application.Exit();
        }

        public void DestroyEverything()
        {
            //destroy all entities that may already exists due to past instances
            foreach (Bullet bull in List.Bullets)
            {
                bull.Destroy();
            }
            List.Bullets.RemoveAll(p => true);
            foreach (InvaderBullet bull in List.InvaderBullets)
            {
                bull.Destroy();
            }
            List.InvaderBullets.RemoveAll(p => true);
            foreach (Enemy Invader in List.Enemies)
            {
                Invader.Destroy();
            }
            List.Enemies.RemoveAll(p => true);
        }

        private void Display(string Output, Label label)
        {
            //method to display centered output
            label.Text = Output;
            label.Left = (ClientSize.Width - label.Width) / 2;
            label.Top = (ClientSize.Height - label.Height) / 2;
            label.Visible = true;
        }

        public void SpawnEnemies()
        {
            //temporarily store starting x and y positions of enemies
            int tempX = List.X[LevelCounter], tempY = List.Y[LevelCounter];

            //spawn enemies by looping through each element
            for (int i = 0; i < List.Rows[LevelCounter]; i++)
            {
                tempX = List.X[LevelCounter];
                for (int j = 0; j < List.Columns[LevelCounter]; j++)
                {
                    List.Enemies.Add(new Enemy(this, tempX, tempY, LevelCounter));
                    tempX += List.dimensions;
                }
                tempY += List.dimensions;
            }
        }

        private void GameOver()
        {
            //turn off all timers
            tmrShooting.Enabled = false;
            tmrEnemy.Enabled = false;
            tmrMovement.Enabled = false;

            //output You Lose
            Display("YOU LOSE!\nGo Back Home", lblOutput);
            Sound.StopMusic();
            Sound.ChangeSoundURL("GameOver.mp3");
            Sound.PlaySound();

            //prevent player from shooting
            List.player.CanShoot = false;

            DestroyEverything();
        }

        private void LevelUp()
        {
            //add to levelcounter
            LevelCounter++;
            File.WriteAllText("Level.txt", String.Empty);
            if(LevelCounter <=4) File.WriteAllText("Level.txt", (LevelCounter-1).ToString());
            DestroyEverything();

            //check if level does not exceed level 5
            if (LevelCounter > 4)
            {
                Display("YOU WIN!", lblOutput);
            }
            else
            {
                //display level
                Display("Level " + (LevelCounter + 1), lblLevel);
                lblLevel.Top = 50;

                //spawn new enemies with different properties
                SpawnEnemies();

                //reset countdown
                Countdown = 5;

                //set all timers to false
                tmrEnemy.Enabled = false;
                tmrMovement.Enabled = false;
                tmrShooting.Enabled = false;

                //remove player's ability to shoot until the game starts, and reposition
                List.player.CanShoot = false;
                List.player.Location = new Point(300, this.ClientSize.Height - 75);
                List.InvaderBullets.RemoveAll(p => true);
                tmrStart.Enabled = true;
            }
        }

        private void tmrMovement_Tick(object sender, EventArgs e)
        {
            //check if InvaderBullets hit player
            if (!List.player.Visible)
            {
                //game is over
                GameOver();
            }
            //move player
            else List.player.Update();
        }

        private void tmrShooting_Tick(object sender, EventArgs e)
        {
            //loop through each of player's 3 bullets to move and remove them
            foreach (Bullet bull in List.Bullets)
            {
                //move bullets
                bull.Update();
            }
            List.Bullets.RemoveAll(p => !p.picEntity.Visible);
            foreach (InvaderBullet bullet in List.InvaderBullets)
            {
                bullet.Update();
            }
            List.InvaderBullets.RemoveAll(p => !p.Visible);
        }

        private void tmrEnemy_Tick(object sender, EventArgs e)
        {
            //loop through each enemy to move and remove them
            foreach (Enemy Invader in List.Enemies)
            {
                if (Invader.Top + Invader.Height > ClientSize.Height) GameOver();
                Invader.Update();
            }
            List.Enemies.RemoveAll(p => !p.picEntity.Visible);

            CheckLevel();
        }

        private void CheckLevel()
        {
            //check if all enemies are killed
            if (List.Enemies.Count == 0)
            {
                //player proceeds to next level
                Display("NEXT LEVEL", lblOutput);
                LevelUp();
            }
        }

        private void tmrStart_Tick(object sender, EventArgs e)
        {
            //add to tick counter
            TickCounter++;

            //if tickcounter is multiple of 5, decrease countdown by 1
            if (TickCounter % 5 == 0) Countdown--;

            //if countdown counter is more than 0, display the number
            if (Countdown >= 0)
            {
                Display(Countdown.ToString(), lblOutput);
            }
            //if countdown number reaches -1, display start
            else if (Countdown == -1)
            {
                Display("START", lblOutput);
            }
            //if countdown counter is -2, start game
            else
            {
                //allow player to shoot
                List.player.CanShoot = true;

                //hide output label
                lblOutput.Visible = false;

                //enable all timers and disable start timer
                tmrEnemy.Enabled = true;
                tmrMovement.Enabled = true;
                tmrShooting.Enabled = true;
                tmrStart.Enabled = false;
            }
        }
    }
}
