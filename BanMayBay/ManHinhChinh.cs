using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BanMayBay
{
    public partial class FormMenu : Form
    {
        public XepMayBay player1 ;
        public XepMayBay player2 ;

        public FormMenu()
        {
            InitializeComponent();
        }
        
        private void FormMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (player1 == null || player2 == null)
            {
                //MessageBox.Show("Ban chua set may bay");
                MessageBox.Show("You haven't set aircraft.");
                return;
            }
            
            SanDau sandau = new SanDau(player1, player2);
            Hide();
            sandau.Show();
        }
        
        private void btnQuitGame_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSetPlane1_Click(object sender, EventArgs e)
        {
            player1 = new XepMayBay(this);
            player1.pnlAirport.BackgroundImage = BanMayBay.Properties.Resources.pubgmap_erangel_500x500_new;
            player1.grpBoxPlayer.Text = "Player 1";
            player1.Show();
            btnSetPlane2.Enabled = false;
        }

        private void btnSetPlane2_Click(object sender, EventArgs e)
        {
            player2 = new XepMayBay(this);
            player2.pnlAirport.BackgroundImage = BanMayBay.Properties.Resources.miramar;
            player2.grpBoxPlayer.Text = "Player 2";
            player2.Show();
            btnSetPlane1.Enabled = false;
        }

        private void btnSetPlane1_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.Blue;
        }

        private void btnSetPlane1_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 0;
        }
    }
}
