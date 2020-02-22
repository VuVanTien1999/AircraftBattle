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
    public enum direction { up = 0, down = 1, left = 2, right = 3 }
    public partial class myButton : Button
    {
        public myButton()
        {
            InitializeComponent();
            isHead = false;
            isPart = false;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        // my Code
        private direction direct;
        public direction Direct
        {
            get { return direct; }
            set { direct = value; }
        }

        private bool ishead;
        public bool isHead
        {
            get { return ishead; }
            set { ishead = value; }
        }

        private bool ispart;
        public bool isPart
        {
            get { return ispart; }
            set { ispart = value; }
        }

        private int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }

}

