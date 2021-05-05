namespace SpaceInvaders
{
    partial class frmLevels
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
            this.lblNext = new System.Windows.Forms.Label();
            this.btnLevelFour = new System.Windows.Forms.Button();
            this.btnLevelThree = new System.Windows.Forms.Button();
            this.btnLevelTwo = new System.Windows.Forms.Button();
            this.btnLevelOne = new System.Windows.Forms.Button();
            this.lblSettings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Magneto", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Location = new System.Drawing.Point(-4, 539);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(241, 73);
            this.lblBack.TabIndex = 9;
            this.lblBack.Text = "BACK";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Font = new System.Drawing.Font("Magneto", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.ForeColor = System.Drawing.Color.White;
            this.lblNext.Location = new System.Drawing.Point(558, 529);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(350, 73);
            this.lblNext.TabIndex = 10;
            this.lblNext.Text = "RESUME";
            this.lblNext.Click += new System.EventHandler(this.lblNext_Click);
            // 
            // btnLevelFour
            // 
            this.btnLevelFour.BackColor = System.Drawing.Color.White;
            this.btnLevelFour.Enabled = false;
            this.btnLevelFour.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevelFour.Location = new System.Drawing.Point(487, 336);
            this.btnLevelFour.Name = "btnLevelFour";
            this.btnLevelFour.Size = new System.Drawing.Size(158, 97);
            this.btnLevelFour.TabIndex = 14;
            this.btnLevelFour.Tag = "LEVEL 4";
            this.btnLevelFour.Text = "LOCKED";
            this.btnLevelFour.UseVisualStyleBackColor = false;
            this.btnLevelFour.Click += new System.EventHandler(this.btnLevelFour_Click);
            // 
            // btnLevelThree
            // 
            this.btnLevelThree.BackColor = System.Drawing.Color.White;
            this.btnLevelThree.Enabled = false;
            this.btnLevelThree.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevelThree.Location = new System.Drawing.Point(274, 336);
            this.btnLevelThree.Name = "btnLevelThree";
            this.btnLevelThree.Size = new System.Drawing.Size(158, 97);
            this.btnLevelThree.TabIndex = 13;
            this.btnLevelThree.Tag = "LEVEL 3";
            this.btnLevelThree.Text = "LOCKED";
            this.btnLevelThree.UseVisualStyleBackColor = false;
            this.btnLevelThree.Click += new System.EventHandler(this.btnLevelThree_Click);
            // 
            // btnLevelTwo
            // 
            this.btnLevelTwo.BackColor = System.Drawing.Color.White;
            this.btnLevelTwo.Enabled = false;
            this.btnLevelTwo.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevelTwo.Location = new System.Drawing.Point(487, 191);
            this.btnLevelTwo.Name = "btnLevelTwo";
            this.btnLevelTwo.Size = new System.Drawing.Size(158, 97);
            this.btnLevelTwo.TabIndex = 12;
            this.btnLevelTwo.Tag = "LEVEL 2";
            this.btnLevelTwo.Text = "LOCKED";
            this.btnLevelTwo.UseVisualStyleBackColor = false;
            this.btnLevelTwo.Click += new System.EventHandler(this.btnLevelTwo_Click);
            // 
            // btnLevelOne
            // 
            this.btnLevelOne.BackColor = System.Drawing.Color.White;
            this.btnLevelOne.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevelOne.Location = new System.Drawing.Point(274, 191);
            this.btnLevelOne.Name = "btnLevelOne";
            this.btnLevelOne.Size = new System.Drawing.Size(158, 97);
            this.btnLevelOne.TabIndex = 11;
            this.btnLevelOne.Tag = "LEVEL 1";
            this.btnLevelOne.Text = "LEVEL 1";
            this.btnLevelOne.UseVisualStyleBackColor = false;
            this.btnLevelOne.Click += new System.EventHandler(this.btnLevelOne_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblSettings.Font = new System.Drawing.Font("Poor Richard", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSettings.Location = new System.Drawing.Point(341, 27);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(244, 55);
            this.lblSettings.TabIndex = 19;
            this.lblSettings.Text = "Level Select";
            // 
            // frmLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SpaceInvaders.Properties.Resources.pixel;
            this.ClientSize = new System.Drawing.Size(909, 611);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.btnLevelFour);
            this.Controls.Add(this.btnLevelThree);
            this.Controls.Add(this.btnLevelTwo);
            this.Controls.Add(this.btnLevelOne);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.lblBack);
            this.Name = "frmLevels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Levels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btnLevelFour;
        private System.Windows.Forms.Button btnLevelThree;
        private System.Windows.Forms.Button btnLevelTwo;
        private System.Windows.Forms.Button btnLevelOne;
        private System.Windows.Forms.Label lblSettings;
    }
}