using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BanMayBay
{
    public partial class SanDau : Form
    {
        // Khai báo hằng và biến cần thiết
        const int size = 9;
        const int squareSize = 35;
        const int countDown = 3;
        int count;
        enum turn { player1, player2 }
        turn playerTurn;
        
        private List<List<myButton>> Panel1;

        private List<List<myButton>> Panel2;

        public SanDau()
        {
            InitializeComponent();
        }

        // gắn vào ma trận của player1 và player2
        private XepMayBay player1 = null;
        private XepMayBay player2 = null;
        public SanDau(XepMayBay XMBform1, XepMayBay XMBform2)
        {
            playerTurn = turn.player1;  // player1 chơi trước

            player1 = XMBform2;         // đổi 2 player
            player2 = XMBform1;         // đổi 2 player
            InitializeComponent();
            count = countDown;
            lbTimer.Text = count.ToString();

            arrow.Image = BanMayBay.Properties.Resources.leftArrow;
        }
        
        private void SanDau_Load(object sender, EventArgs e)
        {
            int i, j;
            // Tạo ma trận button cho player1
            Panel1 = new List<List<myButton>>();    // panel1
            for (i = 0; i < 9; i++)
            {
                Panel1.Add(new List<myButton>());   // panel1
                for (j = 0; j < 9; j++)
                {
                    myButton btn = new myButton()
                    {
                        Width = squareSize,
                        Height = squareSize,
                        Location = new Point(squareSize * i, squareSize * j),
                        X = i,
                        Y = j,
                        //UseVisualStyleBackColor = true,
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.Transparent,
                    };

                    btn.Click += Btn_Click_pnl1;

                    pnlPlayer1.Controls.Add(btn);
                    Panel1[i].Add(btn);     // Panel
                }
            }

            // Tạo ma trận button cho player1
            Panel2 = new List<List<myButton>>();    // panel2
            for (i = 0; i < 9; i++)
            {
                Panel2.Add(new List<myButton>());   // panel2
                for (j = 0; j < 9; j++)
                {
                    myButton btn = new myButton()
                    {
                        Width = squareSize,
                        Height = squareSize,
                        Location = new Point(squareSize * i, squareSize * j),
                        X = i,
                        Y = j,
                        //UseVisualStyleBackColor = true,
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.Transparent,
                    };

                    btn.Click += Btn_Click_pnl2;
                    pnlPlayer2.Controls.Add(btn);
                    Panel2[i].Add(btn);     // Pane2
                }
            }
        }

        private void Btn_Click_pnl1(object sender, EventArgs e)
        {
            myButton btn = sender as myButton;

            if (playerTurn == turn.player2)     // lượt của player2
            {
                timer.Stop();
                MessageBox.Show("This is player2's turn");
                timer.Start();
                return;
            }

            //if (btn.UseVisualStyleBackColor == false)
            if (btn.BackColor == Color.Yellow || btn.BackColor == Color.Wheat
                || btn.BackColor == Color.White)
            {
                timer.Stop();
                MessageBox.Show("This position has been shot");
                timer.Start();
                return;
            }
            // ban trung dau
            if (player1.Matrix[btn.X][btn.Y].isHead)
            {
                btn.BackColor = Color.Yellow;
                player1.NumOfPlane--;
                lbThongBao1.Text = "You shot down " + (3 - player1.NumOfPlane).ToString() + " enemy aircraft";
                if (player1.NumOfPlane > 0) { }
                else
                {
                    timer.Stop();

                    DialogResult dialogResult = MessageBox.Show("YOU WIN",
                        "Do you want to start a new game?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Choi tiep
                        //FormMenu newGame = new FormMenu();
                        //newGame.Show();
                        //Close();
                        System.Diagnostics.Process.Start(Application.ExecutablePath);
                        Application.Exit();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Close();
                    }

                }
            }

            else if (player1.Matrix[btn.X][btn.Y].isPart)
            {
                btn.BackColor = Color.Wheat;
            }
            else
            {
                btn.BackColor = Color.White;
            }

            // đổi lượt
            timer.Stop();
            playerTurn = turn.player2;

            // đổi hướng mũi tên sang player2
            arrow.Image = BanMayBay.Properties.Resources.rightArrow;

            // reset timer
            count = countDown;
            lbTimer.Text = count.ToString();
            timer.Start();

            
        }

        private void Btn_Click_pnl2(object sender, EventArgs e)
        {
            myButton btn = sender as myButton;

            if (playerTurn == turn.player1)
            {
                timer.Stop();
                MessageBox.Show("This is player1's turn");
                timer.Start();
                return;
            }

            //if (btn.UseVisualStyleBackColor == false)
            if (btn.BackColor == Color.Yellow || btn.BackColor == Color.Wheat
                || btn.BackColor == Color.White)
            {
                timer.Stop();
                MessageBox.Show("This position has been shot");
                timer.Start();
                return;
            }
            // ban trung dau
            if (player2.Matrix[btn.X][btn.Y].isHead)
            {
                btn.BackColor = Color.Yellow;
                player2.NumOfPlane--;
                lbThongBao2.Text = "You shot down " + (3 - player2.NumOfPlane).ToString() + " enemy aircraft";
                if (player2.NumOfPlane > 0)
                { }
                else
                {
                    // MessageBox.Show("Ban da ban 3 may bay cua doi phuong\nBan THANG roi");
                    timer.Stop();
                    DialogResult dialogResult = MessageBox.Show("YOU WIN",
                        "Do you want to start a new game?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Game reset 
                        System.Diagnostics.Process.Start(Application.ExecutablePath);
                        Application.Exit();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Close();
                    }
                }
            }

            else if (player2.Matrix[btn.X][btn.Y].isPart)
            {
                btn.BackColor = Color.Wheat;
            }

            else
            {
                btn.BackColor = Color.White;
            }

            // đổi lượt
            timer.Stop();
            playerTurn = turn.player1;
            // mũi tên sangs player1
            arrow.Image = BanMayBay.Properties.Resources.leftArrow;

            // reset timer
            count = countDown;
            lbTimer.Text = count.ToString();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                timer.Stop();
                lbTimer.Text = count.ToString();
                count = countDown;
                // bắn ngẫu nhiên
                if (playerTurn == turn.player1)
                {
                    MessageBox.Show("Time Out\nPlayer1 shoots automatically.");
                    Random rnd = new Random();
                    int x, y;
                    int i = 0;
                    do
                    {
                        x = rnd.Next(9);
                        y = rnd.Next(9);
                        i++;
                        if (i > 200)
                        {
                            do
                            {
                                x = rnd.Next(9);
                                y = rnd.Next(9);
                            } while (Panel1[x][y].BackColor != Color.Transparent);
                            break;
                        }
                    } while (player1.Matrix[x][y].UseVisualStyleBackColor == false
                    || Panel1[x][y].BackColor == Color.White);

                    Panel1[x][y].PerformClick();


                }
                else if (playerTurn == turn.player2)
                {
                    MessageBox.Show("Time Out\nPlayer2 shoots automatically");
                    Random rnd = new Random();
                    int x, y;
                    int i = 0;
                    do
                    {
                        x = rnd.Next(9);
                        y = rnd.Next(9);
                        i++;
                        if (i > 200)
                        {
                            do
                            {
                                x = rnd.Next(9);
                                y = rnd.Next(9);
                            } while (Panel2[x][y].BackColor != Color.Transparent);
                            break;
                        }
                    } while (player2.Matrix[x][y].UseVisualStyleBackColor == false
                    || Panel2[x][y].BackColor == Color.White);
                    Panel2[x][y].PerformClick();
                }
            }
            else
            {
                lbTimer.Text = count.ToString();
            }
        }

        private void SanDau_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}