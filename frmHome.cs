using System;
using System.Windows.Forms;
using System.Drawing;

// A beta version of the Space Invaders game

namespace SpaceInvaders
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Sound.ChangeMusicURL("Menu.mp3");
            Sound.PlayMusic();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //switch to levels form
            frmLevels Levels = new frmLevels();
            Levels.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //switch to settings form
            frmSettings Settings = new frmSettings();
            Settings.ShowDialog();
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout About = new frmAbout();
            About.ShowDialog();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //close program
            this.Close();
        }

        //change forecolour of button when mouse enters and leaves
        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            btnPlay.ForeColor = Color.DarkOrange;
        }
        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.ForeColor = Color.Black;
        }
        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            btnSettings.ForeColor = Color.DarkOrange;
        }
        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.ForeColor = Color.Black;
        }
        private void btnAbout_MouseEnter(object sender, EventArgs e)
        {
            btnAbout.ForeColor = Color.DarkOrange;
        }
        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            btnAbout.ForeColor = Color.Black;
        }
        private void btnQuit_MouseEnter(object sender, EventArgs e)
        {
            btnQuit.ForeColor = Color.DarkOrange;
        }

        private void btnQuit_MouseLeave(object sender, EventArgs e)
        {
            btnQuit.ForeColor = Color.Black;
        }
    }
}
