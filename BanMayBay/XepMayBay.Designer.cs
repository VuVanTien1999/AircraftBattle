namespace BanMayBay
{
    partial class XepMayBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XepMayBay));
            this.grpBoxPlayer = new System.Windows.Forms.GroupBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grbNavigation = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioRight = new System.Windows.Forms.RadioButton();
            this.radioLeft = new System.Windows.Forms.RadioButton();
            this.radioDown = new System.Windows.Forms.RadioButton();
            this.radioUp = new System.Windows.Forms.RadioButton();
            this.pnlAirport = new System.Windows.Forms.Panel();
            this.grpBoxPlayer.SuspendLayout();
            this.grbNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxPlayer
            // 
            this.grpBoxPlayer.Controls.Add(this.btnDone);
            this.grpBoxPlayer.Controls.Add(this.btnReset);
            this.grpBoxPlayer.Controls.Add(this.grbNavigation);
            this.grpBoxPlayer.Location = new System.Drawing.Point(13, 4);
            this.grpBoxPlayer.Name = "grpBoxPlayer";
            this.grpBoxPlayer.Size = new System.Drawing.Size(264, 328);
            this.grpBoxPlayer.TabIndex = 3;
            this.grpBoxPlayer.TabStop = false;
            this.grpBoxPlayer.Text = "Player";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(158, 291);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(69, 23);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(46, 291);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(69, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grbNavigation
            // 
            this.grbNavigation.Controls.Add(this.pictureBox2);
            this.grbNavigation.Controls.Add(this.pictureBox4);
            this.grbNavigation.Controls.Add(this.pictureBox3);
            this.grbNavigation.Controls.Add(this.pictureBox1);
            this.grbNavigation.Controls.Add(this.radioRight);
            this.grbNavigation.Controls.Add(this.radioLeft);
            this.grbNavigation.Controls.Add(this.radioDown);
            this.grbNavigation.Controls.Add(this.radioUp);
            this.grbNavigation.Location = new System.Drawing.Point(22, 31);
            this.grbNavigation.Name = "grbNavigation";
            this.grbNavigation.Size = new System.Drawing.Size(231, 240);
            this.grbNavigation.TabIndex = 3;
            this.grbNavigation.TabStop = false;
            this.grbNavigation.Text = "Navigation";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BanMayBay.Properties.Resources.Plane_Down;
            this.pictureBox2.Location = new System.Drawing.Point(136, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BanMayBay.Properties.Resources.Plane_Right;
            this.pictureBox4.Location = new System.Drawing.Point(136, 149);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BanMayBay.Properties.Resources.Plane_Left;
            this.pictureBox3.Location = new System.Drawing.Point(24, 149);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BanMayBay.Properties.Resources.Plane_UP;
            this.pictureBox1.Location = new System.Drawing.Point(24, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // radioRight
            // 
            this.radioRight.AutoSize = true;
            this.radioRight.Location = new System.Drawing.Point(136, 124);
            this.radioRight.Name = "radioRight";
            this.radioRight.Size = new System.Drawing.Size(50, 17);
            this.radioRight.TabIndex = 3;
            this.radioRight.Text = "Right";
            this.radioRight.UseVisualStyleBackColor = true;
            // 
            // radioLeft
            // 
            this.radioLeft.AutoSize = true;
            this.radioLeft.Location = new System.Drawing.Point(24, 124);
            this.radioLeft.Name = "radioLeft";
            this.radioLeft.Size = new System.Drawing.Size(43, 17);
            this.radioLeft.TabIndex = 2;
            this.radioLeft.Text = "Left";
            this.radioLeft.UseVisualStyleBackColor = true;
            // 
            // radioDown
            // 
            this.radioDown.AutoSize = true;
            this.radioDown.Location = new System.Drawing.Point(136, 23);
            this.radioDown.Name = "radioDown";
            this.radioDown.Size = new System.Drawing.Size(53, 17);
            this.radioDown.TabIndex = 1;
            this.radioDown.Text = "Down";
            this.radioDown.UseVisualStyleBackColor = true;
            // 
            // radioUp
            // 
            this.radioUp.AutoSize = true;
            this.radioUp.Location = new System.Drawing.Point(24, 23);
            this.radioUp.Name = "radioUp";
            this.radioUp.Size = new System.Drawing.Size(39, 17);
            this.radioUp.TabIndex = 0;
            this.radioUp.Text = "Up";
            this.radioUp.UseVisualStyleBackColor = true;
            // 
            // pnlAirport
            // 
            this.pnlAirport.BackColor = System.Drawing.Color.Transparent;
            this.pnlAirport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAirport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlAirport.Location = new System.Drawing.Point(303, 12);
            this.pnlAirport.Name = "pnlAirport";
            this.pnlAirport.Size = new System.Drawing.Size(315, 315);
            this.pnlAirport.TabIndex = 4;
            // 
            // XepMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 361);
            this.Controls.Add(this.pnlAirport);
            this.Controls.Add(this.grpBoxPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(675, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(675, 400);
            this.Name = "XepMayBay";
            this.Text = "Battle Aircraft";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.XepMayBay_FormClosed);
            this.Load += new System.EventHandler(this.XepMayBay_Load);
            this.grpBoxPlayer.ResumeLayout(false);
            this.grbNavigation.ResumeLayout(false);
            this.grbNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grbNavigation;
        private System.Windows.Forms.RadioButton radioRight;
        private System.Windows.Forms.RadioButton radioLeft;
        private System.Windows.Forms.RadioButton radioDown;
        private System.Windows.Forms.RadioButton radioUp;
        public System.Windows.Forms.GroupBox grpBoxPlayer;
        public System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Panel pnlAirport;
    }
}