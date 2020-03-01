using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace SpaceInvaders
{
    public abstract class GameEntity
    {
        //field
        public PictureBox picEntity;
        public int Velocity;
        public Form Form;

        //constructors
        public GameEntity() { }

        public GameEntity(Form Form)
        {
            this.Form = Form;
            picEntity = new PictureBox();
        }
        public abstract void Update();
        public abstract void Destroy();

        //properties
        public Rectangle Bounds
        {
            get { return picEntity.Bounds; }
        }
        public int Height
        {
            get { return picEntity.Height; }
        }
        public int Width
        {
            get { return picEntity.Width; }
        }
        public int Speed
        {
            get { return this.Velocity; }
            set { Velocity = value; }
        }
        public int Left
        {
            get { return picEntity.Left; }
            set { picEntity.Left = value; }
        }
        public int Right
        {
            get { return picEntity.Right; }
        }
        public int Top
        {
            get { return picEntity.Top; }
            set { picEntity.Top = value; }
        }
        public bool Visible
        {
            get { return picEntity.Visible; }
            set { picEntity.Visible = value; }
        }
        public Point Location
        {
            get { return picEntity.Location; }
            set { picEntity.Location = value; }
        }
        public Image Image
        {
            get { return picEntity.Image; }
            set { picEntity.Image = value; }
        }
    }

    //store changing variables
    public class List
    {
        public static Player player;
        public static List<Bullet> Bullets = new List<Bullet>();
        public static List<Enemy> Enemies = new List<Enemy>();
        public static List<InvaderBullet> InvaderBullets = new List<InvaderBullet>();
        public static Image[] enemyImage = { SpaceInvaders.Properties.Resources.enemySprite, Properties.Resources.russian, Properties.Resources.cyclopsBrown, Properties.Resources.deathEnemy, Properties.Resources.reddyEnemy };
        public static int[] enemySpeed = { 7, 13, 21, 19, 15 }, Rows = { 3, 3, 4, 6, 5 }, Columns = { 8, 8, 5, 6, 5 }, X = { 64, 64, 200, 100, 200 }, Y = { 14, 14, 14, 14, 50 }, shootRates = { 6, 4, 5, 2, 2 };
        public static int dimensions = 80;
    }
}