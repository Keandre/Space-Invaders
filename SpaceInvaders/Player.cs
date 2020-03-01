using System.Windows.Forms;

namespace SpaceInvaders
{
    public class Player : GameEntity
    {
        //field
        bool U = false, D = false, L = false, R = false, EnableShoot = false;

        //constructor for player class
        public Player(Form Form)
        {
            this.Form = Form;
            //create picturebox for player
            picEntity = new PictureBox();
            picEntity.Size = new System.Drawing.Size(40, 40);
            picEntity.SizeMode = PictureBoxSizeMode.StretchImage;
            picEntity.Image = SpaceInvaders.Properties.Resources.ship;
            picEntity.Location = new System.Drawing.Point(300, this.Form.ClientSize.Height - 75);


            //add to form
            this.Form.Controls.Add(picEntity);

            //set player velocity to 20
            Velocity = 27;
        }

        public void InputDown(KeyEventArgs Key)
        {
            //for each key check if they are clicked
            if (Key.KeyCode == Keys.W) U = true;
            if (Key.KeyCode == Keys.S) D = true;
            if (Key.KeyCode == Keys.A) L = true;
            if (Key.KeyCode == Keys.D) R = true;
            if (Key.KeyCode == Keys.Space)
                //player shoots a maximum of 5 bullets at a time
                if (List.Bullets.Count < 5 && EnableShoot)
                {
                    List.Bullets.Add(new Bullet(Form));
                    Sound.ChangeSoundURL("Fire.mp3");
                    Sound.PlaySound();
                }
        }

        public void InputUp(KeyEventArgs Key)
        {
            //check if each key is released
            if (Key.KeyCode == Keys.W) U = false;
            if (Key.KeyCode == Keys.S) D = false;
            if (Key.KeyCode == Keys.D) R = false;
            if (Key.KeyCode == Keys.A) L = false;
        }

        public override void Update()
        {
            //depending on which key is clicked, player will move in that direction
            //if player's movement exceeds form's dimensions, player would location would be set to specific locations
            if (L)
            {
                if (picEntity.Left < Velocity)
                    picEntity.Left = 0;
                else
                    picEntity.Left -= Velocity;
            }
            if (R)
            {
                if (picEntity.Left > 870 - Velocity)
                    picEntity.Left = 870;
                else
                    picEntity.Left += Velocity;
            }
            if (U)
            {
                if (picEntity.Top < 415 + Velocity)
                    picEntity.Top = 415;
                else
                    picEntity.Top -= Velocity;
            }
            if (D)
            {
                if (picEntity.Top > 570 - Velocity)
                    picEntity.Top = 570;
                else
                    picEntity.Top += Velocity;
            }

            //loop through each invader bullet to check if they intersect with player
            foreach (InvaderBullet bull in List.InvaderBullets)
            {
                if (bull.Bounds.IntersectsWith(this.Bounds))
                {
                    Destroy();
                    return;
                }
            }
            foreach (Enemy Invader in List.Enemies)
            {
                if (Invader.Bounds.IntersectsWith(this.Bounds))
                {
                    Destroy();
                    Invader.Destroy();
                    return;
                }
            }
        }

        public override void Destroy()
        {
            //dispose player
            picEntity.Dispose();
            picEntity.Visible = false;
        }

        //property
        public bool CanShoot
        {
            get { return EnableShoot; }
            set { EnableShoot = value; }
        }
    }
}