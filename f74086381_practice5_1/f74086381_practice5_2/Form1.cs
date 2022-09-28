using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f74086381_practice5_2
{
    public partial class Form1 : Form
    {
        Random rd = new Random();
        char[] random = new char[4];
        public string str = "";
        public int guess_times = 0;
        public int guess_num = 0;
        public Form1()
        {
            InitializeComponent();
            Random rd = new Random();
            for(int i = 0; i < 4; ++i)
            {
                str += Convert.ToString(rd.Next(0, 9));
            }
            ans.Text = str;
            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            string str = "";
            for (int i = 0; i < 4; ++i)
            {
                str += Convert.ToString(rd.Next(0, 9));
            }
            ans.Text = str;
            guess.Text = "";
            guess_num = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guess.Text += "1";
            guess_num++;
            if(guess_num == 4)
            {
                if(guess.Text == ans.Text)
                {
                    DialogResult result;
                    result = MessageBox.Show("驗證碼正確!", "驗證碼正確", MessageBoxButtons.OK);
                    if(result == DialogResult.OK)
                    {
                        Application.Exit();
                        guess_num = 0;
                        guess.Text = "";
                    }
                }
                else if(guess.Text != ans.Text)
                {
                    guess_times++;
                    DialogResult result;
                    result = MessageBox.Show("驗證碼錯誤" + guess_times + "次", "驗證碼錯誤", MessageBoxButtons.OK);
                    if(result == DialogResult.OK)
                    {
                        if (guess_times == 3)
                        {
                            Application.Exit();
                        }
                        guess_num = 0;
                        guess.Text = "";
                        string str = "";
                        for (int i = 0; i < 4; ++i)
                        {
                            str += Convert.ToString(rd.Next(0, 9));
                        }
                        ans.Text = str;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guess.Text += "2";
            guess_num++;
            if (guess_num == 4)
            {
                if (guess.Text == ans.Text)
                {
                    DialogResult result;
                    result = MessageBox.Show("驗證碼正確!", "驗證碼正確", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                        guess_num = 0;
                        guess.Text = "";
                    }
                }
                else if (guess.Text != ans.Text)
                {
                    guess_times++;
                    DialogResult result;
                    result = MessageBox.Show("驗證碼錯誤" + guess_times + "次", "驗證碼錯誤", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        if (guess_times == 3)
                        {
                            Application.Exit();
                        }
                        guess_num = 0;
                        guess.Text = "";
                        string str = "";
                        for (int i = 0; i < 4; ++i)
                        {
                            str += Convert.ToString(rd.Next(0, 9));
                        }
                        ans.Text = str;
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            guess.Text += "3";
            guess_num++;
            if (guess_num == 4)
            {
                if (guess.Text == ans.Text)
                {
                    DialogResult result;
                    result = MessageBox.Show("驗證碼正確!", "驗證碼正確", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                        guess_num = 0;
                        guess.Text = "";
                    }
                }
                else if (guess.Text != ans.Text)
                {
                    guess_times++;
                    DialogResult result;
                    result = MessageBox.Show("驗證碼錯誤" + guess_times + "次", "驗證碼錯誤", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        if (guess_times == 3)
                        {
                            Application.Exit();
                        }
                        guess_num = 0;
                        guess.Text = "";
                        string str = "";
                        for (int i = 0; i < 4; ++i)
                        {
                            str += Convert.ToString(rd.Next(0, 9));
                        }
                        ans.Text = str;
                    }
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            guess.Text += "4";
            guess_num++;
            if (guess_num == 4)
            {
                if (guess.Text == ans.Text)
                {
                    DialogResult result;
                    result = MessageBox.Show("驗證碼正確!", "驗證碼正確", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                        guess_num = 0;
                        guess.Text = "";
                    }
                }
                else if (guess.Text != ans.Text)
                {
                    guess_times++;
                    DialogResult result;
                    result = MessageBox.Show("驗證碼錯誤" + guess_times + "次", "驗證碼錯誤", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        if (guess_times == 3)
                        {
                            Application.Exit();
                        }
                        guess_num = 0;
                        guess.Text = "";
                        string str = "";
                        for (int i = 0; i < 4; ++i)
                        {
                            str += Convert.ToString(rd.Next(0, 9));
                        }
                        ans.Text = str;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            guess.Text += "5";
            guess_num++;
            if (guess_num == 4)
            {
                if (guess.Text == ans.Text)
                {
                    DialogResult result;
                    result = MessageBox.Show("驗證碼正確!", "驗證碼正確", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                        guess_num = 0;
                        guess.Text = "";
                    }
                }
                else if (guess.Text != ans.Text)
                {
                    guess_times++;
                    DialogResult result;
                    result = MessageBox.Show("驗證碼錯誤" + guess_times + "次", "驗證碼錯誤", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        if (guess_times == 3)
                        {
                            Application.Exit();
                        }
                        guess_num = 0;
                        guess.Text = "";
                        string str = "";
                        for (int i = 0; i < 4; ++i)
                        {
                            str += Convert.ToString(rd.Next(0, 9));
                        }
                        ans.Text = str;
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            guess.Text += "6";
            guess_num++;
            if (guess_num == 4)
            {
                if (guess.Text == ans.Text)
                {
                    DialogResult result;
                    result = MessageBox.Show("驗證碼正確!", "驗證碼正確", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                        guess_num = 0;
                        guess.Text = "";
                    }
                }
                else if (guess.Text != ans.Text)
                {
                    guess_times++;
                    DialogResult result;
                    result = MessageBox.Show("驗證碼錯誤" + guess_times + "次", "驗證碼錯誤", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        if (guess_times == 3)
                        {
                            Application.Exit();
                        }
                        guess_num = 0;
                        guess.Text = "";
                        string str = "";
                        for (int i = 0; i < 4; ++i)
                        {
                            str += Convert.ToString(rd.Next(0, 9));
                        }
                        ans.Text = str;
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            guess.Text += "7";
            guess_num++;
            if (guess_num == 4)
            {
                if (guess.Text == ans.Text)
                {
                    DialogResult result;
                    result = MessageBox.Show("驗證碼正確!", "驗證碼正確", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                        guess_num = 0;
                        guess.Text = "";
                    }
                }
                else if (guess.Text != ans.Text)
                {
                    guess_times++;
                    DialogResult result;
                    result = MessageBox.Show("驗證碼錯誤" + guess_times + "次", "驗證碼錯誤", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        if (guess_times == 3)
                        {
                            Application.Exit();
                        }
                        guess_num = 0;
                        guess.Text = "";
                        string str = "";
                        for (int i = 0; i < 4; ++i)
                        {
                            str += Convert.ToString(rd.Next(0, 9));
                        }
                        ans.Text = str;
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            guess.Text += "8";
            guess_num++;
            if (guess_num == 4)
            {
                if (guess.Text == ans.Text)
                {
                    DialogResult result;
                    result = MessageBox.Show("驗證碼正確!", "驗證碼正確", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                        guess_num = 0;
                        guess.Text = "";
                    }
                }
                else if (guess.Text != ans.Text)
                {
                    guess_times++;
                    DialogResult result;
                    result = MessageBox.Show("驗證碼錯誤" + guess_times + "次", "驗證碼錯誤", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        if (guess_times == 3)
                        {
                            Application.Exit();
                        }
                        guess_num = 0;
                        guess.Text = "";
                        string str = "";
                        for (int i = 0; i < 4; ++i)
                        {
                            str += Convert.ToString(rd.Next(0, 9));
                        }
                        ans.Text = str;
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            guess.Text += "9";
            guess_num++;
            if (guess_num == 4)
            {
                if (guess.Text == ans.Text)
                {
                    DialogResult result;
                    result = MessageBox.Show("驗證碼正確!", "驗證碼正確", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                        guess_num = 0;
                        guess.Text = "";
                    }
                }
                else if (guess.Text != ans.Text)
                {
                    guess_times++;
                    DialogResult result;
                    result = MessageBox.Show("驗證碼錯誤" + guess_times + "次", "驗證碼錯誤", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        if (guess_times == 3)
                        {
                            Application.Exit();
                        }
                        guess_num = 0;
                        guess.Text = "";
                        string str = "";
                        for (int i = 0; i < 4; ++i)
                        {
                            str += Convert.ToString(rd.Next(0, 9));
                        }
                        ans.Text = str;
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            guess.Text += "0";
            guess_num++;
            if (guess_num == 4)
            {
                if (guess.Text == ans.Text)
                {
                    DialogResult result;
                    result = MessageBox.Show("驗證碼正確!", "驗證碼正確", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                        guess_num = 0;
                        guess.Text = "";
                    }
                }
                else if (guess.Text != ans.Text)
                {
                    guess_times++;
                    DialogResult result;
                    result = MessageBox.Show("驗證碼錯誤" + guess_times + "次", "驗證碼錯誤", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        if (guess_times == 3)
                        {
                            Application.Exit();
                        }
                        guess_num = 0;
                        guess.Text = "";
                        string str = "";
                        for (int i = 0; i < 4; ++i)
                        {
                            str += Convert.ToString(rd.Next(0, 9));
                        }
                        ans.Text = str;
                    }
                }
            }
        }
    }
}
