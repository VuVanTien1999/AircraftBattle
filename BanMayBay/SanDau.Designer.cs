namespace BanMayBay
{
    partial class SanDau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanDau));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lbThongBao1 = new System.Windows.Forms.Label();
            this.lbThongBao2 = new System.Windows.Forms.Label();
            this.arrow = new System.Windows.Forms.PictureBox();
            this.lbTimer = new System.Windows.Forms.Label();
            this.pnlPlayer2 = new System.Windows.Forms.Panel();
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(115, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(557, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player2";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LemonChiffon;
            this.label3.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(374, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Time";
            // 
            // lbThongBao1
            // 
            this.lbThongBao1.AutoSize = true;
            this.lbThongBao1.BackColor = System.Drawing.Color.Transparent;
            this.lbThongBao1.Font = new System.Drawing.Font("VNI-Times", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbThongBao1.Location = new System.Drawing.Point(58, 445);
            this.lbThongBao1.Name = "lbThongBao1";
            this.lbThongBao1.Size = new System.Drawing.Size(0, 23);
            this.lbThongBao1.TabIndex = 12;
            // 
            // lbThongBao2
            // 
            this.lbThongBao2.AutoSize = true;
            this.lbThongBao2.BackColor = System.Drawing.Color.Transparent;
            this.lbThongBao2.Font = new System.Drawing.Font("VNI-Times", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbThongBao2.Location = new System.Drawing.Point(479, 445);
            this.lbThongBao2.Name = "lbThongBao2";
            this.lbThongBao2.Size = new System.Drawing.Size(0, 23);
            this.lbThongBao2.TabIndex = 13;
            // 
            // arrow
            // 
            this.arrow.BackColor = System.Drawing.Color.Transparent;
            this.arrow.Image = global::BanMayBay.Properties.Resources.rightArrow;
            this.arrow.Location = new System.Drawing.Point(354, 211);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(94, 75);
            this.arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrow.TabIndex = 10;
            this.arrow.TabStop = false;
            // 
            // lbTimer
            // 
            this.lbTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTimer.Font = new System.Drawing.Font("Ink Free", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.Color.Red;
            this.lbTimer.Location = new System.Drawing.Point(354, 48);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(90, 60);
            this.lbTimer.TabIndex = 6;
            this.lbTimer.Text = "00";
            this.lbTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPlayer2
            // 
            this.pnlPlayer2.BackgroundImage = global::BanMayBay.Properties.Resources.pubgmap_erangel_500x500_new;
            this.pnlPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPlayer2.Location = new System.Drawing.Point(454, 112);
            this.pnlPlayer2.Name = "pnlPlayer2";
            this.pnlPlayer2.Size = new System.Drawing.Size(315, 315);
            this.pnlPlayer2.TabIndex = 5;
            // 
            // pnlPlayer1
            // 
            this.pnlPlayer1.BackgroundImage = global::BanMayBay.Properties.Resources.miramar;
            this.pnlPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPlayer1.Location = new System.Drawing.Point(29, 112);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(315, 315);
            this.pnlPlayer1.TabIndex = 4;
            // 
            // SanDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::BanMayBay.Properties.Resources.bgSanDau;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 521);
            this.Controls.Add(this.lbThongBao2);
            this.Controls.Add(this.lbThongBao1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arrow);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.pnlPlayer2);
            this.Controls.Add(this.pnlPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SanDau";
            this.Text = "Battle Aircraft";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SanDau_FormClosed);
            this.Load += new System.EventHandler(this.SanDau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlPlayer1;
        private System.Windows.Forms.Panel pnlPlayer2;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox arrow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbThongBao1;
        private System.Windows.Forms.Label lbThongBao2;
    }
}