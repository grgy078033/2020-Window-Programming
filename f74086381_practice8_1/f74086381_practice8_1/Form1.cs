using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace f74086381_practice8_1
{
    public partial class Form1 : Form
    {
        int time_count = 0;
        bool talk = false;
        
        
        public Form1()
        {
            InitializeComponent();
            time.Text = "User: " + time_count + " seconds";
            timer1.Interval = 1000;
            timer1.Enabled = false;
            textBox_enter.KeyPress += Form1_KeyPress;
            openFileDialog1.Filter = "JPEG|*.jpg|BMP|*.bmp|GIF|*.gif|PNG|*.png";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_count++;
            time.Text = "User: " + time_count + " seconds";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        private void 結束程式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 開啟聊天機器人ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            talk = true;
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            if (talk)
            {
                string filename = @"..\Debug\record.txt";
                FileInfo finfo = new FileInfo(filename);
                if (!Directory.Exists(finfo.DirectoryName))
                    Directory.CreateDirectory(finfo.DirectoryName);
                textBox_content.Text += "Me:    " + textBox_enter.Text + "\r\nMachine:你好\r\n";
                using (StreamWriter sw = File.AppendText(filename))
                {
                    sw.WriteLine("Me:    " + textBox_enter.Text);
                    sw.WriteLine("Machine:你好");
                    sw.Flush();
                    sw.Close();
                }
                textBox_enter.Text = "";
            }
            else
                textBox_enter.Text = "";
        }

        private void 字體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBox_content.Font = fontDialog1.Font;
            }
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBox_content.ForeColor = colorDialog1.Color;
            }
        }

        private void button_photo_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (talk)
                {
                    string filename = @"..\Debug\record.txt";
                    FileInfo finfo = new FileInfo(filename);
                    if (!Directory.Exists(finfo.DirectoryName))
                        Directory.CreateDirectory(finfo.DirectoryName);
                    textBox_content.Text += "Me:    " + textBox_enter.Text + "\r\nMachine:你好\r\n";
                    using (StreamWriter sw = File.AppendText(filename))
                    {
                        sw.WriteLine("Me:    " + textBox_enter.Text);
                        sw.WriteLine("Machine:你好");
                        sw.Flush();
                        sw.Close();
                    }
                    textBox_enter.Text = "";
                }
                else
                    textBox_enter.Text = "";
            }
        }
    }
}
