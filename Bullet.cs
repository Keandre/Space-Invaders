using System.Windows.Forms;

namespace SpaceInvaders
{
    public class Bullet : GameEntity
    {
        //constructor for bullet class
        public Bullet(Form Form)
        {
            //create picturebox for player bullet
            picEntity = new PictureBox();
            picEntity.Size = new System.Drawing.Size(2, 60);
            picEntity.BackColor = System.Drawing.Color.Red;
            picEntity.Location = new System.Drawing.Point(List.player.picEntity.Left + List.player.picEntity.Width / 2, List.player.picEntity.Top - 60);

            //add player bullet to game form
            this.Form = Form;
            this.Form.Controls.Add(picEntity);

            //set velocity of bullet to 35
            Velocity = 35;
        }

        public override void Destroy()
        {
            //dispose PLAYER BULLET
            picEntity.Visible = false;
            picEntity.Dispose();
        }
        public override void Update()
        {
            //move player bullet
            if (picEntity.Top > 0) picEntity.Top -= Velocity;
            else Destroy();

            //loop through each enemy to check if player bullet intersects with one of them
            foreach (Enemy Invader in List.Enemies)
            {
                if (Invader.picEntity.Visible && this.Bounds.IntersectsWith(Invader.Bounds))
                {
                    Destroy();
                    Invader.Destroy();
                    Sound.ChangeSound2URL("thunk.wav");
                    Sound.PlaySound2();
                    return;
                }
            }
        }
    }
}