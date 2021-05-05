using System;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        public void lblBack_Click(object sender, EventArgs e)
        {
            //switch to home form
            this.Close();
        }
    }
}
