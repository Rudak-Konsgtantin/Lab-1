using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game1
{
    public partial class winForm : Form
    {
        Random rnd = new Random();
        public int r,g,b;

        public winForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //for (int i = 0; i < 255; ++i)
            //    for (int k = 0; k < 255; k++)
            //        for (int j = 0; j < 255 && Visible; ++j)
            //        {
            //            this.BackColor = Color.FromArgb(k, i, j);
            //            Application.DoEvents();
            //        }
            r= rnd.Next(0, 255);
            g= rnd.Next(0, 255);
            b= rnd.Next(0, 255);
            this.BackColor = Color.FromArgb(r, g, b);
            Application.DoEvents();
        }
    }
}
