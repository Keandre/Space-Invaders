namespace SpaceInvaders
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblBack = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.lblHowToPlay = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.lblPlayExplain = new System.Windows.Forms.Label();
            this.lblRulesExplain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Tempus Sans ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Location = new System.Drawing.Point(3, 559);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(199, 84);
            this.lblBack.TabIndex = 8;
            this.lblBack.Text = "BACK";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Tempus Sans ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.White;
            this.lblAbout.Location = new System.Drawing.Point(330, 9);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(212, 84);
            this.lblAbout.TabIndex = 9;
            this.lblAbout.Text = "About";
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.AutoSize = true;
            this.lblIntroduction.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroduction.ForeColor = System.Drawing.Color.White;
            this.lblIntroduction.Location = new System.Drawing.Point(11, 104);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(886, 186);
            this.lblIntroduction.TabIndex = 9;
            this.lblIntroduction.Text = resources.GetString("lblIntroduction.Text");
            // 
            // lblHowToPlay
            // 
            this.lblHowToPlay.AutoSize = true;
            this.lblHowToPlay.Font = new System.Drawing.Font("Tempus Sans ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowToPlay.ForeColor = System.Drawing.Color.White;
            this.lblHowToPlay.Location = new System.Drawing.Point(70, 315);
            this.lblHowToPlay.Name = "lblHowToPlay";
            this.lblHowToPlay.Size = new System.Drawing.Size(377, 84);
            this.lblHowToPlay.TabIndex = 9;
            this.lblHowToPlay.Text = "How To Play";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Font = new System.Drawing.Font("Tempus Sans ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.ForeColor = System.Drawing.Color.White;
            this.lblRules.Location = new System.Drawing.Point(576, 315);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(177, 84);
            this.lblRules.TabIndex = 9;
            this.lblRules.Text = "Rules";
            // 
            // lblPlayExplain
            // 
            this.lblPlayExplain.AutoSize = true;
            this.lblPlayExplain.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayExplain.ForeColor = System.Drawing.Color.White;
            this.lblPlayExplain.Location = new System.Drawing.Point(143, 399);
            this.lblPlayExplain.Name = "lblPlayExplain";
            this.lblPlayExplain.Size = new System.Drawing.Size(227, 124);
            this.lblPlayExplain.TabIndex = 9;
            this.lblPlayExplain.Text = "- Move the hunter\r\nwith the WASD keys\r\n- Press space to shoot\r\na bullet";
            // 
            // lblRulesExplain
            // 
            this.lblRulesExplain.AutoSize = true;
            this.lblRulesExplain.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRulesExplain.ForeColor = System.Drawing.Color.White;
            this.lblRulesExplain.Location = new System.Drawing.Point(512, 399);
            this.lblRulesExplain.Name = "lblRulesExplain";
            this.lblRulesExplain.Size = new System.Drawing.Size(308, 124);
            this.lblRulesExplain.TabIndex = 9;
            this.lblRulesExplain.Text = "- Do not let the enemy\r\ntroops reach the bottom\r\n- Do not let the bullets of the\r" +
    "\nenemy troops touch you";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(909, 653);
            this.Controls.Add(this.lblRulesExplain);
            this.Controls.Add(this.lblPlayExplain);
            this.Controls.Add(this.lblIntroduction);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblHowToPlay);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblBack);
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblIntroduction;
        private System.Windows.Forms.Label lblHowToPlay;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Label lblPlayExplain;
        private System.Windows.Forms.Label lblRulesExplain;
    }
}