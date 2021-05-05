namespace SpaceInvaders
{
    partial class frmSettings
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
            this.lblBack = new System.Windows.Forms.Label();
            this.lblSoundPercentage = new System.Windows.Forms.Label();
            this.btnLowerSound = new System.Windows.Forms.Button();
            this.btnRaiseSound = new System.Windows.Forms.Button();
            this.lblMusicPercentage = new System.Windows.Forms.Label();
            this.btnLowerMusic = new System.Windows.Forms.Button();
            this.btnRaiseMusic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMusic = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblArrowKeysControl = new System.Windows.Forms.Label();
            this.lblSpaceBarControl = new System.Windows.Forms.Label();
            this.lblControls = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picSpaceBar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpaceBar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Magneto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Location = new System.Drawing.Point(-1, 524);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(257, 78);
            this.lblBack.TabIndex = 9;
            this.lblBack.Text = "BACK";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            this.lblBack.MouseHover += new System.EventHandler(this.lblBack_MouseHover);
            // 
            // lblSoundPercentage
            // 
            this.lblSoundPercentage.AutoSize = true;
            this.lblSoundPercentage.BackColor = System.Drawing.Color.Transparent;
            this.lblSoundPercentage.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoundPercentage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSoundPercentage.Location = new System.Drawing.Point(85, 372);
            this.lblSoundPercentage.Name = "lblSoundPercentage";
            this.lblSoundPercentage.Size = new System.Drawing.Size(52, 28);
            this.lblSoundPercentage.TabIndex = 17;
            this.lblSoundPercentage.Text = "50%";
            // 
            // btnLowerSound
            // 
            this.btnLowerSound.BackColor = System.Drawing.SystemColors.Control;
            this.btnLowerSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowerSound.Location = new System.Drawing.Point(54, 406);
            this.btnLowerSound.Name = "btnLowerSound";
            this.btnLowerSound.Size = new System.Drawing.Size(57, 32);
            this.btnLowerSound.TabIndex = 16;
            this.btnLowerSound.Text = "-";
            this.btnLowerSound.UseVisualStyleBackColor = false;
            this.btnLowerSound.Click += new System.EventHandler(this.btnLowerSound_Click);
            // 
            // btnRaiseSound
            // 
            this.btnRaiseSound.BackColor = System.Drawing.SystemColors.Control;
            this.btnRaiseSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiseSound.Location = new System.Drawing.Point(117, 406);
            this.btnRaiseSound.Name = "btnRaiseSound";
            this.btnRaiseSound.Size = new System.Drawing.Size(57, 32);
            this.btnRaiseSound.TabIndex = 15;
            this.btnRaiseSound.Text = "+";
            this.btnRaiseSound.UseVisualStyleBackColor = false;
            this.btnRaiseSound.Click += new System.EventHandler(this.btnRaiseSound_Click);
            // 
            // lblMusicPercentage
            // 
            this.lblMusicPercentage.AutoSize = true;
            this.lblMusicPercentage.BackColor = System.Drawing.Color.Transparent;
            this.lblMusicPercentage.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicPercentage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMusicPercentage.Location = new System.Drawing.Point(86, 166);
            this.lblMusicPercentage.Name = "lblMusicPercentage";
            this.lblMusicPercentage.Size = new System.Drawing.Size(52, 28);
            this.lblMusicPercentage.TabIndex = 14;
            this.lblMusicPercentage.Text = "50%";
            // 
            // btnLowerMusic
            // 
            this.btnLowerMusic.BackColor = System.Drawing.SystemColors.Control;
            this.btnLowerMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowerMusic.Location = new System.Drawing.Point(54, 199);
            this.btnLowerMusic.Name = "btnLowerMusic";
            this.btnLowerMusic.Size = new System.Drawing.Size(57, 32);
            this.btnLowerMusic.TabIndex = 13;
            this.btnLowerMusic.Text = "-";
            this.btnLowerMusic.UseVisualStyleBackColor = false;
            this.btnLowerMusic.Click += new System.EventHandler(this.btnLowerMusic_Click);
            // 
            // btnRaiseMusic
            // 
            this.btnRaiseMusic.BackColor = System.Drawing.SystemColors.Control;
            this.btnRaiseMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiseMusic.Location = new System.Drawing.Point(117, 199);
            this.btnRaiseMusic.Name = "btnRaiseMusic";
            this.btnRaiseMusic.Size = new System.Drawing.Size(57, 32);
            this.btnRaiseMusic.TabIndex = 12;
            this.btnRaiseMusic.Text = "+";
            this.btnRaiseMusic.UseVisualStyleBackColor = false;
            this.btnRaiseMusic.Click += new System.EventHandler(this.btnRaiseMusic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(58, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 44);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sound";
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.BackColor = System.Drawing.Color.Transparent;
            this.lblMusic.Font = new System.Drawing.Font("Poor Richard", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMusic.Location = new System.Drawing.Point(67, 125);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(101, 44);
            this.lblMusic.TabIndex = 10;
            this.lblMusic.Text = "Music";
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblSettings.Font = new System.Drawing.Font("Poor Richard", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSettings.Location = new System.Drawing.Point(372, 9);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(168, 55);
            this.lblSettings.TabIndex = 18;
            this.lblSettings.Text = "Settings";
            // 
            // lblArrowKeysControl
            // 
            this.lblArrowKeysControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblArrowKeysControl.AutoSize = true;
            this.lblArrowKeysControl.BackColor = System.Drawing.Color.Transparent;
            this.lblArrowKeysControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrowKeysControl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblArrowKeysControl.Location = new System.Drawing.Point(555, 338);
            this.lblArrowKeysControl.Name = "lblArrowKeysControl";
            this.lblArrowKeysControl.Size = new System.Drawing.Size(301, 29);
            this.lblArrowKeysControl.TabIndex = 23;
            this.lblArrowKeysControl.Text = "WASD will guide your ship.";
            this.lblArrowKeysControl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSpaceBarControl
            // 
            this.lblSpaceBarControl.AutoSize = true;
            this.lblSpaceBarControl.BackColor = System.Drawing.Color.Transparent;
            this.lblSpaceBarControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceBarControl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSpaceBarControl.Location = new System.Drawing.Point(493, 520);
            this.lblSpaceBarControl.Name = "lblSpaceBarControl";
            this.lblSpaceBarControl.Size = new System.Drawing.Size(410, 29);
            this.lblSpaceBarControl.TabIndex = 21;
            this.lblSpaceBarControl.Text = "Use the spacebar to shoot. Pew pew!";
            this.lblSpaceBarControl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.BackColor = System.Drawing.Color.Transparent;
            this.lblControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControls.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblControls.Location = new System.Drawing.Point(636, 106);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(147, 39);
            this.lblControls.TabIndex = 20;
            this.lblControls.Text = "Controls";
            this.lblControls.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SpaceInvaders.Properties.Resources.wasd_keys_png_11;
            this.pictureBox1.Location = new System.Drawing.Point(563, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 194);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // picSpaceBar
            // 
            this.picSpaceBar.BackColor = System.Drawing.Color.Transparent;
            this.picSpaceBar.Image = global::SpaceInvaders.Properties.Resources.spacebar;
            this.picSpaceBar.Location = new System.Drawing.Point(569, 388);
            this.picSpaceBar.Name = "picSpaceBar";
            this.picSpaceBar.Size = new System.Drawing.Size(275, 129);
            this.picSpaceBar.TabIndex = 19;
            this.picSpaceBar.TabStop = false;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SpaceInvaders.Properties.Resources.pixel;
            this.ClientSize = new System.Drawing.Size(909, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblArrowKeysControl);
            this.Controls.Add(this.lblSpaceBarControl);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.picSpaceBar);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.lblSoundPercentage);
            this.Controls.Add(this.btnLowerSound);
            this.Controls.Add(this.btnRaiseSound);
            this.Controls.Add(this.lblMusicPercentage);
            this.Controls.Add(this.btnLowerMusic);
            this.Controls.Add(this.btnRaiseMusic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMusic);
            this.Controls.Add(this.lblBack);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpaceBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblSoundPercentage;
        private System.Windows.Forms.Button btnLowerSound;
        private System.Windows.Forms.Button btnRaiseSound;
        private System.Windows.Forms.Label lblMusicPercentage;
        private System.Windows.Forms.Button btnLowerMusic;
        private System.Windows.Forms.Button btnRaiseMusic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblArrowKeysControl;
        private System.Windows.Forms.Label lblSpaceBarControl;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.PictureBox picSpaceBar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}