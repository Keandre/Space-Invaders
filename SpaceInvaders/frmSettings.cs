using System;
using System.Windows.Forms;
namespace SpaceInvaders
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            //switch to home form
            this.Close();
        }

        private void lblBack_MouseHover(object sender, EventArgs e)
        {
            lblBack.ForeColor = System.Drawing.Color.Cyan;
            lblBack.Font = new System.Drawing.Font("Magneto", 48);
        }

        private void btnLowerMusic_Click(object sender, EventArgs e)
        {
            if (Sound.MusicVolume() - 10 >= 0)
            {
                Sound.ChangeMusicVolume(-10);
                lblMusicPercentage.Text = Sound.MusicVolume() + "%";
            }
        }

        private void btnRaiseMusic_Click(object sender, EventArgs e)
        {
            if (Sound.MusicVolume() + 10 <= 100)
            {
                Sound.ChangeMusicVolume(10);
                lblMusicPercentage.Text = Sound.MusicVolume() + "%";
            } 
        }

        private void btnLowerSound_Click(object sender, EventArgs e)
        {
            if(Sound.SoundVolume() - 10 >=0)
            {
                Sound.ChangeSoundVolume(-10);
                lblSoundPercentage.Text = Sound.SoundVolume() + "%";
            }
        }

        private void btnRaiseSound_Click(object sender, EventArgs e)
        {
            if(Sound.SoundVolume()+10<=100)
            {
                Sound.ChangeSoundVolume(10);
                lblSoundPercentage.Text = Sound.SoundVolume() + "%";
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            lblMusicPercentage.Text = Sound.MusicVolume() + "%";
            lblSoundPercentage.Text = Sound.SoundVolume() + "%";
        }
    }
}
