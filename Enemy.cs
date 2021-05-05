using System;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public class Enemy : GameEntity
    {
        //field
        public enum Direction { Right = 0, Down = 1, Left = 2, DownAgain = 3 };
        Direction thisDirection = Direction.Right;
        Random randomShot;
        int ShootRate;

        //contstructor for enemy class
        public Enemy(Form Form, int x, int y, int LevelCounter)
        {
            //create picturebox for each enemy
            picEntity = new PictureBox();
            picEntity.Size = new System.Drawing.Size(List.dimensions, List.dimensions);
            picEntity.Location = new System.Drawing.Point(x, y);
            picEntity.SizeMode = PictureBoxSizeMode.StretchImage;
            picEntity.Image = List.enemyImage[LevelCounter];

            //add enemy to game form
            this.Form = Form;
            this.Form.Controls.Add(picEntity);

            //store values for enemy properties
            ShootRate = List.shootRates[LevelCounter];
            Velocity = List.enemySpeed[LevelCounter];
            randomShot = new Random();
        }

        public override void Destroy()
        {
            //dispose enemy
            picEntity.Dispose();
        }

        public override void Update()
        {
            //move enemy in pattern right, down, left, down and repeat
            if (thisDirection == Direction.Right)
            {
                picEntity.Left += Velocity;

                //change direction when furthermost enemy hits right wall
                foreach(Enemy Invader in List.Enemies)
                {
                    if(Invader.Right > Form.ClientSize.Width)
                    {
                        Invader.Direct = Direction.Down;
                        this.Direct = Direction.Down;
                    }
                }
            }
            else if (thisDirection == Direction.Down)
            {
                picEntity.Top += Velocity;
                thisDirection = Direction.Left;
            }
            else if (thisDirection == Direction.Left)
            {
                picEntity.Left -= Velocity;

                //change direction when furthermost enemy hits left wall
                foreach (Enemy Invader in List.Enemies)
                {
                    if (Invader.Left < 0)
                    {
                        Invader.Direct = Direction.DownAgain;
                        this.Direct = Direction.DownAgain;
                    }
                }
            }
            else if (thisDirection == Direction.DownAgain)
            {
                picEntity.Top += Velocity;
                thisDirection = Direction.Right;
            }

            //enemy shoot random bullets downward
            if (List.InvaderBullets.Count < 6)
            {
                if (randomShot.Next(0, ShootRate) == 1)
                    List.InvaderBullets.Add(new InvaderBullet(this.Form, this));
            }
        }

        //properties
        public int Probablity
        {
            get { return ShootRate; }
            set { ShootRate = value; }
        }
        public Direction Direct
        {
            get { return thisDirection; }
            set { thisDirection = value; }
        }
    }
}