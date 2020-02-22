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
    public partial class XepMayBay : Form
    {
        // Khai báo hằng và biến cần thiết
        const int size = 9;
        const int squareSize = 35;

        private List<List<myButton>> matrix;
        public List<List<myButton>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private int numOfPlane;
        public int NumOfPlane
        {
            get { return numOfPlane; }
            set { numOfPlane = value; }
        }
        
        public XepMayBay()
        {
            InitializeComponent();
            NumOfPlane = 0;
        }

        private FormMenu manHinhChinh = null;
        public XepMayBay (FormMenu mainMenu)
        {
            InitializeComponent();
            NumOfPlane = 0;

            manHinhChinh = mainMenu;
        }

        private List<string> colorList;
        public List<string> ColorList { get => colorList; set => colorList = value; }
        
        private void XepMayBay_Load(object sender, EventArgs e)
        {
            Matrix = new List<List<myButton>>();

            ColorList = new List<string>();
            
            ColorList.Add("Red");
            ColorList.Add("Green");
            ColorList.Add("Blue");
            
            int i, j;
            for (i = 0; i < 9; i++)
            {
                Matrix.Add(new List<myButton>());

                for (j = 0; j < 9; j++)
                {
                    myButton btn = new myButton()
                    {
                        Width = squareSize,
                        Height = squareSize,
                        Location = new Point(squareSize * i, squareSize * j),
                        X = i, Y = j,
                        UseVisualStyleBackColor = true,
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.Transparent,
                    };

                    btn.Click += btn_Click;
                    pnlAirport.Controls.Add(btn);
                    Matrix[i].Add(btn);
                }
            }
            
        }
        
        void btn_Click(object sender, EventArgs e)
        {
            myButton btn = sender as myButton;
            
            if (NumOfPlane == 3)
            {
                MessageBox.Show("Reach maximum of Plane");
                return;
            }

            if (radioUp.Checked)
            {
                if (drawUp(btn)) btn.Direct = direction.up;
            }
            else if (radioDown.Checked)
            {
                if (drawDown(btn)) btn.Direct = direction.down;
            }
            else if (radioLeft.Checked)
            {
                if (drawLeft(btn)) btn.Direct = direction.left;
            }
            else if (radioRight.Checked)
            {
                if (drawRight(btn)) btn.Direct = direction.right;
            }

            else MessageBox.Show("Choose direction for Plane");
        }

        bool drawUp(myButton btn)
        {
            if (outOfIndex(btn))
            {
                MessageBox.Show("Out of bound");
                return false;
            }
            if (partExisted(btn))
            {
                MessageBox.Show("Existed");
                return false;
            }

            // đổi màu máy bay
            btn.BackColor = Color.FromName(ColorList[0]);

            btn.isHead = true;

            for (int i = btn.X - 2; i <= btn.X + 2; i++)
            {
                Matrix[i][btn.Y + 1].BackColor = Color.FromName(ColorList[0]);
                Matrix[i][btn.Y + 1].isPart = true;
            }

            Matrix[btn.X][btn.Y + 2].BackColor = Color.FromName(ColorList[0]);
            Matrix[btn.X][btn.Y + 2].isPart = true;

            for (int i = btn.X - 1; i <= btn.X + 1; i++)
            {
                Matrix[i][btn.Y + 3].BackColor = Color.FromName(ColorList[0]);
                Matrix[i][btn.Y + 3].isPart = true;
            }

            // đưa màu đã dùng xuống cuối
            string temp = ColorList[0];
            ColorList.RemoveAt(0);
            ColorList.Add(temp);

            NumOfPlane++;

            btn.Click -= btn_Click;
            btn.Click += btn_Click_2;

            return true;
        }
        bool drawDown(myButton btn)
        {
            // máy bay hướng xuống
            // kiểm tra toàn bộ máy bay có nằm trong khuôn không
            if (btn.X - 2 < 0 || btn.X + 2 >= 9 || btn.Y - 3 < 0)
            {
                MessageBox.Show("Out of bound");
                return false;
            }

            // kiểm tra thân có trùng với máy bay khác không
            // phần đầu
            if (btn.isPart || btn.isHead)
            {
                MessageBox.Show("Existed");
                return false;
            }
            // phần cánh
            for (int i = btn.X - 2; i <= btn.X + 2; i++)
            {
                if (Matrix[i][btn.Y - 1].isPart || Matrix[i][btn.Y - 1].isHead)
                {
                    MessageBox.Show("Existed");
                    return false;
                }
            }
            // phần giữa
            if (Matrix[btn.X][btn.Y - 2].isPart || Matrix[btn.X][btn.Y - 2].isHead)
            {
                MessageBox.Show("Existed");
                return false;
            }
            // phần đuôi
            for (int i = btn.X - 1; i <= btn.X + 1; i++)
            {
                if (Matrix[i][btn.Y - 3].isPart || Matrix[i][btn.Y - 3].isHead)
                {
                    MessageBox.Show("Existed");
                    return false;
                }
            }

            // Vẽ máy bay
            // Phần đầu
            btn.BackColor = Color.FromName(ColorList[0]);
            btn.isHead = true;

            // Phần thân
            for (int i = btn.X - 2; i <= btn.X + 2; i++)
            {
                Matrix[i][btn.Y - 1].BackColor = Color.FromName(ColorList[0]);
                Matrix[i][btn.Y - 1].isPart = true;
            }

            // Phần giữa
            Matrix[btn.X][btn.Y - 2].BackColor = Color.FromName(ColorList[0]);
            Matrix[btn.X][btn.Y - 2].isPart = true;

            // Phần đuôi
            for (int i = btn.X - 1; i <= btn.X + 1; i++)
            {
                Matrix[i][btn.Y - 3].BackColor = Color.FromName(ColorList[0]);
                Matrix[i][btn.Y - 3].isPart = true;
            }
            
            // đưa màu đã dùng xuống cuối
            string temp = ColorList[0];
            ColorList.RemoveAt(0);
            ColorList.Add(temp);

            NumOfPlane++;

            btn.Click -= btn_Click;
            btn.Click += btn_Click_2;

            return true;
        }

        bool drawLeft(myButton btn)
        {
            // Máy bay hướng sang trái
            // Kiểm tra các bộ phận có nằm trong khung không
            if (btn.X + 3 >= 9 || btn.Y - 2 < 0 || btn.Y + 2 >= 9)
            {
                MessageBox.Show("Out of bound");
                return false;
            }

            // Kiểm tra có bị trùng với máy bay khác không
            // Phần đầu
            if (btn.isPart || btn.isHead) {
                MessageBox.Show("Existed");
                return false;
            }
            // Phần cánh
            for (int i = btn.Y - 2; i <= btn.Y + 2; i++)
            {
                if (Matrix[btn.X + 1][i].isPart || Matrix[btn.X + 1][i].isHead)
                {
                    MessageBox.Show("Existed");
                    return false;
                }
            }
            // Phần giữa
            if (Matrix[btn.X + 2][btn.Y].isPart || Matrix[btn.X + 2][btn.Y].isHead)
            {
                MessageBox.Show("Existed");
                return false;
            }
            // Phần đuôi
            for (int i = btn.Y - 1; i <= btn.Y + 1; i++)
            {
                if (Matrix[btn.X + 3][i].isPart || Matrix[btn.X + 1][i].isHead)
                {
                    MessageBox.Show("Existed");
                    return false;
                }
            }

            // Vẽ máy bay
            // Phần đầu
            btn.BackColor = Color.FromName(ColorList[0]);
            btn.isHead = true;
            // Phần cánh
            for (int i = btn.Y - 2; i <= btn.Y + 2; i++)
            {
                Matrix[btn.X + 1][i].BackColor = Color.FromName(ColorList[0]);
                Matrix[btn.X + 1][i].isPart = true;
            }
            // Phần giữa
            Matrix[btn.X + 2][btn.Y].BackColor = Color.FromName(ColorList[0]);
            Matrix[btn.X + 2][btn.Y].isPart = true;
            // Phần đuôi
            for (int i = btn.Y - 1; i <= btn.Y + 1; i++)
            {
                Matrix[btn.X + 3][i].BackColor = Color.FromName(ColorList[0]);
                Matrix[btn.X + 3][i].isPart = true;
            }
            
            // đưa màu đã dùng xuống cuối
            string temp = ColorList[0];
            ColorList.RemoveAt(0);
            ColorList.Add(temp);

            NumOfPlane++;

            btn.Click -= btn_Click;
            btn.Click += btn_Click_2;

            return true;
        }

        bool drawRight(myButton btn)
        {
            // Máy bay hướng sang phải
            // Kiểm tra máy bay có nằm trong khung không
            if (btn.Y - 2 < 0 || btn.Y + 2 >= 9 || btn.X - 3 < 0)
            {
                MessageBox.Show("Out of bound");
                return false;
            }

            // Kiểm tra có bị trùng với máy bay khác không
            // Phần đầu
            if (btn.isPart || btn.isHead)
            {
                MessageBox.Show("Existed");
                return false;
            }
            // Phần cánh
            for (int i = btn.Y - 2; i <= btn.Y + 2; i++)
            {
                if (Matrix[btn.X - 1][i].isPart || Matrix[btn.X - 1][i].isHead)
                {
                    MessageBox.Show("Existed");
                    return false;
                }
            }
            // Phần giữa
            if (Matrix[btn.X - 2][btn.Y].isPart || Matrix[btn.X - 2][btn.Y].isHead)
            {
                MessageBox.Show("Existed");
                return false;
            }
            // Phần đuôi
            for (int i = btn.Y - 1; i <= btn.Y + 1; i++)
            {
                if (Matrix[btn.X - 3][i].isPart || Matrix[btn.X - 3][i].isHead)
                {
                    MessageBox.Show("Existed");
                    return false;
                }
            }

            // Vẽ máy bay
            // Phần đầu
            btn.BackColor = Color.FromName(ColorList[0]);
            btn.isHead = true;
            // Phần cánh
            for (int i = btn.Y - 2; i <= btn.Y + 2; i++)
            {
                Matrix[btn.X - 1][i].BackColor = Color.FromName(ColorList[0]);
                Matrix[btn.X - 1][i].isPart = true;
            }
            // Phần giữa
            Matrix[btn.X - 2][btn.Y].BackColor = Color.FromName(ColorList[0]);
            Matrix[btn.X - 2][btn.Y].isPart = true;
            // Phần đuôi
            for (int i = btn.Y - 1; i <= btn.Y + 1; i++)
            {
                Matrix[btn.X - 3][i].BackColor = Color.FromName(ColorList[0]);
                Matrix[btn.X - 3][i].isPart = true;
            }

            // 
            // đưa màu đã dùng xuống cuối
            string temp = ColorList[0];
            ColorList.RemoveAt(0);
            ColorList.Add(temp);

            NumOfPlane++;

            btn.Click -= btn_Click;
            btn.Click += btn_Click_2;

            return true;
        }

        bool outOfIndex(myButton btn)
        {
            if (btn.X - 2 < 0 || btn.X + 2 >= 9 || btn.Y + 3 >= 9)
                return true;
            return false;
        }
        bool partExisted(myButton btn)
        {
            if (btn.isPart || btn.isHead)   // Check đầu
                return true;
            for (int i = btn.X - 2; i <= btn.X + 2; i++)    // Check hàng cánh
            {
                if (Matrix[i][btn.Y + 1].isPart || Matrix[i][btn.Y + 1].isHead)
                    return true;
            }
            if (Matrix[btn.X][btn.Y + 2].isPart || Matrix[btn.X][btn.Y + 2].isHead) // Check gần đuôi
                return true;
            for (int i = btn.X - 1; i <= btn.X + 1; i++)    // Check đuôi
            {
                if (Matrix[i][btn.Y + 3].isPart || Matrix[i][btn.Y + 3].isHead)
                    return true;
            }
            return false;
        }
        void btn_Click_2(object sender, EventArgs e)
        {
            myButton btn = sender as myButton;
            // đưa màu đã xóa lên đầu
            ColorList.Remove(btn.BackColor.Name);
            ColorList.Insert(0, btn.BackColor.Name);

            btn.BackColor = default(Color);
            btn.UseVisualStyleBackColor = true;
            btn.isHead = false;

            if (btn.Direct == direction.up)
                removeUp(btn);
            else if (btn.Direct == direction.down)
                removeDown(btn);
            else if (btn.Direct == direction.left)
                removeLeft(btn);
            else if (btn.Direct == direction.right)
                removeRight(btn);

            // 
            NumOfPlane--;
            btn.Click -= btn_Click_2;
            btn.Click += btn_Click;
        }

        void removeUp(myButton btn)
        {
            // Xóa cánh
            for (int i = btn.X - 2; i <= btn.X + 2; i++)
            {
                Matrix[i][btn.Y + 1].BackColor = default(Color);
                Matrix[i][btn.Y + 1].UseVisualStyleBackColor = true;
                Matrix[i][btn.Y + 1].isPart = false;
            }
            // Xóa giữa
            Matrix[btn.X][btn.Y + 2].BackColor = default(Color);
            Matrix[btn.X][btn.Y + 2].UseVisualStyleBackColor = true;
            Matrix[btn.X][btn.Y + 2].isPart = false;
            // Xóa đuôi
            for (int i = btn.X - 1; i <= btn.X + 1; i++)
            {
                Matrix[i][btn.Y + 3].BackColor = default(Color);
                Matrix[i][btn.Y + 3].UseVisualStyleBackColor = true;
                Matrix[i][btn.Y + 3].isPart = false;
            }
        }

        void removeDown(myButton btn)
        {
            // Xóa cánh
            for (int i = btn.X - 2; i <= btn.X + 2; i++)
            {
                Matrix[i][btn.Y - 1].BackColor = default(Color);
                Matrix[i][btn.Y - 1].UseVisualStyleBackColor = true;
                Matrix[i][btn.Y - 1].isPart = false;
            }
            // Xóa giữa
            Matrix[btn.X][btn.Y - 2].BackColor = default(Color);
            Matrix[btn.X][btn.Y - 2].UseVisualStyleBackColor = true;
            Matrix[btn.X][btn.Y - 2].isPart = false;
            // Xóa đuôi
            for (int i = btn.X - 1; i <= btn.X + 1; i++)
            {
                Matrix[i][btn.Y - 3].BackColor = default(Color);
                Matrix[i][btn.Y - 3].UseVisualStyleBackColor = true;
                Matrix[i][btn.Y - 3].isPart = false;
            }
        }

        void removeLeft(myButton btn)
        {
            // Xóa cánh
            for (int i = btn.Y - 2; i <= btn.Y + 2; i++)
            {
                Matrix[btn.X + 1][i].BackColor = default(Color);
                Matrix[btn.X + 1][i].UseVisualStyleBackColor = true;
                Matrix[btn.X + 1][i].isPart = false;
            }

            // Xóa giữa
            Matrix[btn.X + 2][btn.Y].BackColor = default(Color);
            Matrix[btn.X + 2][btn.Y].UseVisualStyleBackColor = true;
            Matrix[btn.X + 2][btn.Y].isPart = false;

            // Xóa đuôi
            for (int i = btn.Y - 1; i <= btn.Y + 1; i++)
            {
                Matrix[btn.X + 3][i].BackColor = default(Color);
                Matrix[btn.X + 3][i].UseVisualStyleBackColor = true;
                Matrix[btn.X + 3][i].isPart = false;
            }
        }

        void removeRight(myButton btn)
        {
            // Xóa cánh
            for (int i = btn.Y - 2; i <= btn.Y + 2; i++)
            {
                Matrix[btn.X - 1][i].BackColor = default(Color);
                Matrix[btn.X - 1][i].UseVisualStyleBackColor = true;
                Matrix[btn.X - 1][i].isPart = false;
            }
            // Xóa giữa
            Matrix[btn.X - 2][btn.Y].BackColor = default(Color);
            Matrix[btn.X - 2][btn.Y].UseVisualStyleBackColor = true;
            Matrix[btn.X - 2][btn.Y].isPart = false;
            // Xóa đuôi
            for (int i = btn.Y - 1; i <= btn.Y + 1; i++)
            {
                Matrix[btn.X - 3][i].BackColor = default(Color);
                Matrix[btn.X - 3][i].UseVisualStyleBackColor = true;
                Matrix[btn.X - 3][i].isPart = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i=0;i<9;i++)
                for (int j=0;j<9;j++)
                {
                    Matrix[i][j].BackColor = default(Color);
                    Matrix[i][j].UseVisualStyleBackColor = true;
                    if (Matrix[i][j].isHead)
                    {
                        Matrix[i][j].Click -= btn_Click_2;
                        Matrix[i][j].Click += btn_Click;
                    }
                    Matrix[i][j].isHead = false;
                    Matrix[i][j].isPart = false;
                }
            NumOfPlane = 0;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (numOfPlane < 3)
                MessageBox.Show("Not enough aircraft.\nYou need 3 aircraft to play the game.");
            else
            {
                Hide();
                if (manHinhChinh.btnSetPlane1.Enabled == false)
                {
                    manHinhChinh.btnSetPlane1.Enabled = true;
                    manHinhChinh.btnSetPlane2.Enabled = false;
                    
                    if (manHinhChinh.player1 != null)
                    {
                        manHinhChinh.btnSetPlane1.Enabled = false;
                    }
                }

                else if (manHinhChinh.btnSetPlane2.Enabled == false)
                {
                    manHinhChinh.btnSetPlane2.Enabled = true;
                    manHinhChinh.btnSetPlane1.Enabled = false;
                    if (manHinhChinh.player2 != null)
                    {
                        manHinhChinh.btnSetPlane2.Enabled = false;
                    }
                }
            }
        }

        private void XepMayBay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            if (manHinhChinh.btnSetPlane1.Enabled == false)
            {
                manHinhChinh.player2 = null;
                if (manHinhChinh.player1 == null)
                {
                    manHinhChinh.btnSetPlane1.Enabled = true;
                }

            }
            else if (manHinhChinh.btnSetPlane2.Enabled == false)
            {
                manHinhChinh.player1 = null;
                if (manHinhChinh.player2 == null)
                {
                    manHinhChinh.btnSetPlane2.Enabled = true;
                }
            }
        }
    }
}
