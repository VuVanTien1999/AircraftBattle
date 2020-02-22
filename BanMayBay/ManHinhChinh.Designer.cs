namespace BanMayBay
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnQuitGame = new System.Windows.Forms.Button();
            this.btnSetPlane1 = new System.Windows.Forms.Button();
            this.btnSetPlane2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(43, 250);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(113, 44);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnQuitGame
            // 
            this.btnQuitGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitGame.Location = new System.Drawing.Point(452, 250);
            this.btnQuitGame.Name = "btnQuitGame";
            this.btnQuitGame.Size = new System.Drawing.Size(113, 44);
            this.btnQuitGame.TabIndex = 1;
            this.btnQuitGame.Text = "Quit";
            this.btnQuitGame.UseVisualStyleBackColor = true;
            this.btnQuitGame.Click += new System.EventHandler(this.btnQuitGame_Click);
            // 
            // btnSetPlane1
            // 
            this.btnSetPlane1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetPlane1.BackColor = System.Drawing.Color.Transparent;
            this.btnSetPlane1.FlatAppearance.BorderSize = 0;
            this.btnSetPlane1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnSetPlane1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSetPlane1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPlane1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPlane1.ForeColor = System.Drawing.Color.White;
            this.btnSetPlane1.Location = new System.Drawing.Point(43, 179);
            this.btnSetPlane1.Name = "btnSetPlane1";
            this.btnSetPlane1.Size = new System.Drawing.Size(172, 33);
            this.btnSetPlane1.TabIndex = 2;
            this.btnSetPlane1.Text = "Set Plane 1";
            this.btnSetPlane1.UseVisualStyleBackColor = false;
            this.btnSetPlane1.Click += new System.EventHandler(this.btnSetPlane1_Click);
            this.btnSetPlane1.MouseEnter += new System.EventHandler(this.btnSetPlane1_MouseEnter);
            this.btnSetPlane1.MouseLeave += new System.EventHandler(this.btnSetPlane1_MouseLeave);
            // 
            // btnSetPlane2
            // 
            this.btnSetPlane2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetPlane2.BackColor = System.Drawing.Color.Transparent;
            this.btnSetPlane2.FlatAppearance.BorderSize = 0;
            this.btnSetPlane2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnSetPlane2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSetPlane2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPlane2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPlane2.ForeColor = System.Drawing.Color.White;
            this.btnSetPlane2.Location = new System.Drawing.Point(393, 179);
            this.btnSetPlane2.Name = "btnSetPlane2";
            this.btnSetPlane2.Size = new System.Drawing.Size(172, 33);
            this.btnSetPlane2.TabIndex = 3;
            this.btnSetPlane2.Text = "Set Plane 2";
            this.btnSetPlane2.UseVisualStyleBackColor = false;
            this.btnSetPlane2.Click += new System.EventHandler(this.btnSetPlane2_Click);
            this.btnSetPlane2.MouseEnter += new System.EventHandler(this.btnSetPlane1_MouseEnter);
            this.btnSetPlane2.MouseLeave += new System.EventHandler(this.btnSetPlane1_MouseLeave);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::BanMayBay.Properties.Resources.Battleplane;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.btnSetPlane2);
            this.Controls.Add(this.btnSetPlane1);
            this.Controls.Add(this.btnQuitGame);
            this.Controls.Add(this.btnStartGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "FormMenu";
            this.Text = "Battle Aircraft";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnQuitGame;
        public System.Windows.Forms.Button btnSetPlane1;
        public System.Windows.Forms.Button btnSetPlane2;
    }
}

