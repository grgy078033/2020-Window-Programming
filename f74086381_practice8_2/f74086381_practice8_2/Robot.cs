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

namespace f74086381_practice8_2
{
    public partial class Robot : Form
    {
        public Form1 f1;
        public Robot(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
            timer1.Enabled = false;
            timer1.Enabled = false;
            progressBar1.Step = 1;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar2.Step = 1;
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 100;
            timer1.Interval = 50;
            timer2.Interval = 50;
        }
        Machine choose;
        string type1;
        string type2;
        string get_return_str;
        private void button_mode1_Click(object sender, EventArgs e)
        {
            choose = new Machine_mode_one();
            type1 = choose.get_type();
            progressBar1.PerformStep();
            timer1.Enabled = true;
        }

        private void button_mode2_Click(object sender, EventArgs e)
        {
            choose = new Machine_mode_two();
            type2 = choose.get_type();
            progressBar2.PerformStep();
            timer2.Enabled = true;
        }
        public string SetType(string type)
        {
            return type;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = progressBar1.Value + "%";
            progressBar1.PerformStep();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 0;
                timer1.Enabled = false;
                label1.Text = "";
                f1.setTextBox(type1, ref get_return_str);
                string filename = @"..\Debug\record.txt";
                FileInfo finfo = new FileInfo(filename);
                if (!Directory.Exists(finfo.DirectoryName))
                    Directory.CreateDirectory(finfo.DirectoryName);
                using (StreamWriter sw = File.AppendText(filename))
                {
                    sw.WriteLine(get_return_str);
                    sw.Flush();
                    sw.Close();
                }
            }
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = progressBar2.Value + "%";
            progressBar2.PerformStep();
            if (progressBar2.Value == progressBar2.Maximum)
            {
                progressBar2.Value = 0;
                timer2.Enabled = false;
                label2.Text = "";
                f1.setTextBox(type2, ref get_return_str);
                string filename = @"..\Debug\record.txt";
                FileInfo finfo = new FileInfo(filename);
                if (!Directory.Exists(finfo.DirectoryName))
                    Directory.CreateDirectory(finfo.DirectoryName);
                using (StreamWriter sw = File.AppendText(filename))
                {
                    sw.WriteLine(get_return_str);
                    sw.Flush();
                    sw.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                textBox_fileread.Text = "";
                string filename = @"..\Debug\record.txt";
                try
                {
                    StreamReader sr = new StreamReader(filename);
                    string content;
                    while ((content = sr.ReadLine()) != null)
                        textBox_fileread.Text += content.ToString() + "\r\n";
                    sr.Close();
                }
                catch (Exception) { }
            }
        }
    }
}
