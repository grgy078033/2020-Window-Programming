using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f74086381_practice6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_num.Text = "2";
            time.Text = "0";
            timer1.Interval = 1000;
            timer1.Enabled = false;
            timer2.Interval = 50;
            timer2.Enabled = false;
        }
        int[] count = new int[5];
        Button[] b = new Button[5];
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            if (Convert.ToInt32(button_num.Text) >= 2 || Convert.ToInt32(button_num.Text) < 5)
            {
                for (int i = 0; i < Convert.ToInt32(button_num.Text); ++i)
                {
                    b[i] = new Button();
                    b[i].SetBounds(20 + 80 * i, 0, 60, 60);
                    b[i].Visible = true;
                    b[i].Enabled = false;
                    Controls.Add(b[i]);
                    switch (i)
                    {
                        case 0:
                            b[i].Text = "Q";
                            break;
                        case 1:
                            b[i].Text = "W";
                            break;
                        case 2:
                            b[i].Text = "E";
                            break;
                        case 3:
                            b[i].Text = "R";
                            break;
                        case 4:
                            b[i].Text = "T";
                            break;
                    }
                }
            }
        }
        int time_count = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = Convert.ToString(time_count);
            time_count++;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button_num.Enabled = false;
            start.Enabled = false;
            for (int i = 0; i < Convert.ToInt32(button_num.Text); ++i)
            {
                b[i].SetBounds(20 + 80 * i, count[i] * 3, 60, 60);
                count[i]++;
            }

            for (int i = 0; i < Convert.ToInt32(button_num.Text); ++i)
            {
                if(b[i].Location.Y >= 434-147)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    DialogResult end;
                    end = MessageBox.Show("生存時間:" + (time_count-1), "", MessageBoxButtons.OK);
                    if (end == DialogResult.OK)
                    {
                        time.Text = "0";
                        for (int j = 0; j < Convert.ToInt32(button_num.Text); ++j)
                        {
                            b[j].SetBounds(20 + 80 * j, 0, 60, 60);
                            b[j].Visible = false;
                            count[j] = 0;
                        }
                        time_count = 1;
                        start.Enabled = true;
                        button_num.Enabled = true;
                        break;
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           char c = (char)e.KeyCode;
            if (c == 'Q')
                count[0]-=2;
            if (c == 'W')
                count[1]-=2;
            if (c == 'E')
                count[2]-=2;
            if (c == 'R')
                count[3]-=2;
            if (c == 'T')
                count[4]-=2;
        }
    }
}
