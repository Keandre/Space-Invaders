using System.Windows.Forms;

namespace SpaceInvaders
{
    //inhertiance from game entity class
    public class InvaderBullet : GameEntity
    {
        //constructor
        public InvaderBullet(Form Form, Enemy Invader)
        {
            //create picturebox for invader bullet
            picEntity = new PictureBox();
            picEntity.Size = new System.Drawing.Size(1, 40);
            picEntity.Location = new System.Drawing.Point(Invader.Left + Invader.Width / 2, Invader.Top + Invader.Height - 5);
            picEntity.BackColor = System.Drawing.Color.Blue;
            
            //add invader bullet to game form
            this.Form = Form;
            this.Form.Controls.Add(picEntity);

            //set velocity of invader bullet to 20
            Velocity = 35;
        }

        public override void Update()
        {
            //move invader bullet
            if (picEntity.Top + picEntity.Height < this.Form.ClientSize.Height) picEntity.Top += Velocity;

            //call destroy method
            else Destroy();
        }

        public override void Destroy()
        {
            //destroy invader bullet
            picEntity.Dispose();
            picEntity.Visible = false;
        }
    }
}