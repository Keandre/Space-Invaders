using System;
using System.Windows.Forms;
using System.IO;

namespace SpaceInvaders
{
    public partial class frmLevels : Form
    {
        public frmLevels()
        {
            InitializeComponent();
            Button[] Levels = new Button[] {btnLevelOne,btnLevelTwo,btnLevelThree,btnLevelFour};
            if (!File.Exists("Level.txt"))
            {
                using (StreamWriter sw = File.CreateText("Level.txt"))
                {
                    sw.Write("1");
                }
            }

            using(StreamReader sr = File.OpenText("Level.txt"))
            {
                string s = sr.ReadLine().ToString();
                if(s.Substring(0,1)!= null)
                {
                    for(int i = 0; i < Int32.Parse(s)+1; i++)
                    {
                        Levels[i].Enabled = true;
                        Levels[i].Text = Levels[i].Tag.ToString();
                    }
                }
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            //switch to home form
            frmHome Home = new frmHome();
            Home.ShowDialog();
            this.Close();
        }

        private void lblNext_Click(object sender, EventArgs e)
        {
            //go to latest level
            frmGame Game;
            if (btnLevelFour.Enabled) Game = new frmGame(4);
            else if (btnLevelThree.Enabled) Game = new frmGame(3);
            else if (btnLevelTwo.Enabled) Game = new frmGame(2);
            else Game = new frmGame();

            Game.Show();
            this.Close();
        }

        private void btnLevelTwo_Click(object sender, EventArgs e)
        {
            //switch to game form
            if(((Button)sender).Enabled)
            {
                frmGame Game = new frmGame(2);
                Game.Show();
                this.Close();
            }
        }

        private void btnLevelThree_Click(object sender, EventArgs e)
        {
            //switch to game form
            if (((Button)sender).Enabled)
            {
                frmGame Game = new frmGame(3);
                Game.Show();
                this.Close();
            }
        }

        private void btnLevelFour_Click(object sender, EventArgs e)
        {
            //switch to game form
            if (((Button)sender).Enabled)
            {
                frmGame Game = new frmGame(4);
                Game.Show();
                this.Close();
            }
        }

        private void btnLevelOne_Click(object sender, EventArgs e)
        {
            frmGame Game = new frmGame();
            Game.Show();
            this.Close();
        }
    }
}
