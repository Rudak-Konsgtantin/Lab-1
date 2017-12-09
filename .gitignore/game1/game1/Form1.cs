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
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public int rndNumber;
        int lives;
        int gameTime;
        
        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Rand = " + rndNumber.ToString());
            if (rndNumber.ToString() == textBox1.Text)
            {
                timer1.Stop();
                label1.Text = "YOU WIN";
                winForm winForm = new winForm();
                winForm.Show();
            }

            if (checkBox1.Checked == true)
            {
               if (int.Parse(textBox1.Text) > rndNumber)
               {
                    label1.Text = "число меньше";
                    lives--;
               }
               if (int.Parse(textBox1.Text) < rndNumber)
               {
                   label1.Text = "число больше";
                   lives--;
               }
            }

            if (checkBox3.Checked == true)
            {
                label3.Text = lives.ToString();
                if (lives == 0)
                {
                    MessageBox.Show("LIVER OVER");
                    button1.Enabled = false;                    
                }
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                rndNumber = rnd.Next(0, 10);
            }
            if (radioButton2.Checked == true)
            {
                rndNumber = rnd.Next(0, 50);
            }
            if (radioButton3.Checked == true)
            {
                rndNumber = rnd.Next(0, 100);
            }
            label1.Text = "Я загодал число";
            lives = 10;

            timer1.Enabled=true;
            textBox1.Visible = true; 
            button1.Enabled = true;
            button2.Enabled = false;

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.DoEvents();
            label2.Text = gameTime.ToString();
            gameTime++;
            
            if (checkBox2.Checked == true)
            {
                if (int.Parse(label2.Text) >= 60)
                {
                    timer1.Stop();
                    button1.Enabled = false;
                    MessageBox.Show("TIME OVER");
                }
            }

        }
    }
}
