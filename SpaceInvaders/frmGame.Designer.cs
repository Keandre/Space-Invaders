namespace SpaceInvaders
{
    partial class frmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblOutput = new System.Windows.Forms.Label();
            this.tmrMovement = new System.Windows.Forms.Timer(this.components);
            this.tmrShooting = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemy = new System.Windows.Forms.Timer(this.components);
            this.tmrStart = new System.Windows.Forms.Timer(this.components);
            this.mnuOptions = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGoHome = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblLevel = new System.Windows.Forms.Label();
            this.mnuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Tempus Sans ITC", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(394, 239);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(137, 173);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "3";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrMovement
            // 
            this.tmrMovement.Tick += new System.EventHandler(this.tmrMovement_Tick);
            // 
            // tmrShooting
            // 
            this.tmrShooting.Tick += new System.EventHandler(this.tmrShooting_Tick);
            // 
            // tmrEnemy
            // 
            this.tmrEnemy.Tick += new System.EventHandler(this.tmrEnemy_Tick);
            // 
            // tmrStart
            // 
            this.tmrStart.Enabled = true;
            this.tmrStart.Tick += new System.EventHandler(this.tmrStart_Tick);
            // 
            // mnuOptions
            // 
            this.mnuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.mnuOptions.Location = new System.Drawing.Point(0, 0);
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(909, 24);
            this.mnuOptions.TabIndex = 9;
            this.mnuOptions.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGoHome,
            this.toolStripSeparator1,
            this.mnuQuit,
            this.toolStripSeparator2});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // mnuGoHome
            // 
            this.mnuGoHome.Name = "mnuGoHome";
            this.mnuGoHome.Size = new System.Drawing.Size(180, 22);
            this.mnuGoHome.Text = "Go Home";
            this.mnuGoHome.Click += new System.EventHandler(this.mnuGoHome_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuQuit
            // 
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.Size = new System.Drawing.Size(180, 22);
            this.mnuQuit.Text = "Quit";
            this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Tempus Sans ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(336, 34);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(210, 84);
            this.lblLevel.TabIndex = 8;
            this.lblLevel.Text = "Level 1";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SpaceInvaders.Properties.Resources.pixel;
            this.ClientSize = new System.Drawing.Size(909, 611);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.mnuOptions);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.mnuOptions;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyUp);
            this.mnuOptions.ResumeLayout(false);
            this.mnuOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Timer tmrMovement;
        private System.Windows.Forms.Timer tmrShooting;
        private System.Windows.Forms.Timer tmrEnemy;
        private System.Windows.Forms.Timer tmrStart;
        private System.Windows.Forms.MenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGoHome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label lblLevel;
    }
}