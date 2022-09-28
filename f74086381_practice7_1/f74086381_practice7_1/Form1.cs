using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f74086381_practice7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = false;
            X_ScrollBar.LargeChange = 1;
            X_ScrollBar.Minimum = 0;
            X_ScrollBar.Maximum = 3;
            Y_ScrollBar.LargeChange = 1;
            Y_ScrollBar.Minimum = 0;
            Y_ScrollBar.Maximum = 1;
            ans_00.Visible = false;
            ans_01.Visible = false;
            ans_02.Visible = false;
            ans_03.Visible = false;
            ans_10.Visible = false;
            ans_11.Visible = false;
            ans_12.Visible = false;
            ans_13.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button1.Location = new Point(0 * button1.Width, 0 * button1.Height + 30);
            button2.Location = new Point(1 * button2.Width, 0 * button2.Height + 30);
            button3.Location = new Point(2 * button3.Width, 0 * button3.Height + 30);
            button4.Location = new Point(3 * button4.Width, 0 * button4.Height + 30);
            button5.Location = new Point(0 * button5.Width, 1 * button5.Height + 30);
            button6.Location = new Point(1 * button6.Width, 1 * button6.Height + 30);
            button7.Location = new Point(2 * button7.Width, 1 * button7.Height + 30);
            button8.Location = new Point(3 * button8.Width, 1 * button8.Height + 30);
        }
        int time_count = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ++time_count;
            time_set.Text = "Used " + time_count + " second";
        }
        int record_word_Q = 0;
        int record_word_W = 0;
        int record_word_E = 0;
        int record_word_R = 0;
        int record_word_Qb = 0;
        int record_word_Wb = 0;
        int record_word_Eb = 0;
        int record_word_Rb = 0;
        int Q_xpos;
        int W_xpos;
        int E_xpos;
        int R_xpos;
        int Q_ypos;
        int W_ypos;
        int E_ypos;
        int R_ypos;
        int Qb_xpos;
        int Wb_xpos;
        int Eb_xpos;
        int Rb_xpos;
        int Qb_ypos;
        int Wb_ypos;
        int Eb_ypos;
        int Rb_ypos;
        int i;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rx = new Random();
            for (int i = 0; i < 10; i++)
                label1.Text += rx.Next(0, 3).ToString();
            timer1.Enabled = true;
            time_set.Text = "Used " + time_count + " second";
            Random rd = new Random();
            for(i = 0; i < 4; ++i)
            {
                int row_rand_num = rd.Next(0, 2);
                int word_rand = rd.Next(0, 4);
                if(row_rand_num == 2 || word_rand == 4)
                {
                    --i;
                    continue;
                }
                string word = "";
                bool back = false;

                switch (word_rand)
                {
                    case 0:
                        if(record_word_Q == 1)
                        {
                            --i;
                            back = true;
                            break;
                        }
                        word = "Q";
                        record_word_Q = 1;
                        break;
                    case 1:
                        if (record_word_W == 1)
                        {
                            --i;
                            back = true;
                            break;
                        }
                        word = "W";
                        record_word_W = 1;
                        break;
                    case 2:
                        if (record_word_E == 1)
                        {
                            --i;
                            back = true;
                            break;
                        }
                        word = "E";
                        record_word_E = 1;
                        break;
                    case 3:
                        if (record_word_R == 1)
                        {
                            --i;
                            back = true;
                            break;
                        }
                        word = "R";
                        record_word_R = 1;
                        break;
                }

                if (back)
                    continue;

                if (row_rand_num == 0)
                {
                    switch (i)
                    {
                        case 0:
                            ans_00.Visible = true;
                            ans_00.Text = word;
                            switch (word)
                            {
                                case "Q":
                                    Q_xpos = 0;
                                    Q_ypos = 0;
                                    break;
                                case "W":
                                    W_xpos = 0;
                                    W_ypos = 0;
                                    break;
                                case "E":
                                    E_xpos = 0;
                                    E_ypos = 0;
                                    break;
                                case "R":
                                    R_xpos = 0;
                                    R_ypos = 0;
                                    break;
                            }
                            break;
                        case 1:
                            ans_01.Visible = true;
                            ans_01.Text = word;
                            switch (word)
                            {
                                case "Q":
                                    Q_xpos = 1;
                                    Q_ypos = 0;
                                    break;
                                case "W":
                                    W_xpos = 1;
                                    W_ypos = 0;
                                    break;
                                case "E":
                                    E_xpos = 1;
                                    E_ypos = 0;
                                    break;
                                case "R":
                                    R_xpos = 1;
                                    R_ypos = 0;
                                    break;
                            }
                            break;
                        case 2:
                            ans_02.Visible = true;
                            ans_02.Text = word;
                            switch (word)
                            {
                                case "Q":
                                    Q_xpos = 2;
                                    Q_ypos = 0;
                                    break;
                                case "W":
                                    W_xpos = 2;
                                    W_ypos = 0;
                                    break;
                                case "E":
                                    E_xpos = 2;
                                    E_ypos = 0;
                                    break;
                                case "R":
                                    R_xpos = 2;
                                    R_ypos = 0;
                                    break;
                            }
                            break;
                        case 3:
                            ans_03.Visible = true;
                            ans_03.Text = word;
                            switch (word)
                            {
                                case "Q":
                                    Q_xpos = 3;
                                    Q_ypos = 0;
                                    break;
                                case "W":
                                    W_xpos = 3;
                                    W_ypos = 0;
                                    break;
                                case "E":
                                    E_xpos = 3;
                                    E_ypos = 0;
                                    break;
                                case "R":
                                    R_xpos = 3;
                                    R_ypos = 0;
                                    break;
                            }
                            break;
                    }
                }
                if (row_rand_num == 1)
                {
                    switch (i)
                    {
                        case 0:
                            ans_10.Visible = true;
                            ans_10.Text = word;
                            switch (word)
                            {
                                case "Q":
                                    Q_xpos = 0;
                                    Q_ypos = 1;
                                    break;
                                case "W":
                                    W_xpos = 0;
                                    W_ypos = 1;
                                    break;
                                case "E":
                                    E_xpos = 0;
                                    E_ypos = 1;
                                    break;
                                case "R":
                                    R_xpos = 0;
                                    R_ypos = 1;
                                    break;
                            }
                            break;
                        case 1:
                            ans_11.Visible = true;
                            ans_11.Text = word;
                            switch (word)
                            {
                                case "Q":
                                    Q_xpos = 1;
                                    Q_ypos = 1;
                                    break;
                                case "W":
                                    W_xpos = 1;
                                    W_ypos = 1;
                                    break;
                                case "E":
                                    E_xpos = 1;
                                    E_ypos = 1;
                                    break;
                                case "R":
                                    R_xpos = 1;
                                    R_ypos = 1;
                                    break;
                            }
                            break;
                        case 2:
                            ans_12.Visible = true;
                            ans_12.Text = word;
                            switch (word)
                            {
                                case "Q":
                                    Q_xpos = 2;
                                    Q_ypos = 1;
                                    break;
                                case "W":
                                    W_xpos = 2;
                                    W_ypos = 1;
                                    break;
                                case "E":
                                    E_xpos = 2;
                                    E_ypos = 1;
                                    break;
                                case "R":
                                    R_xpos = 2;
                                    R_ypos = 1;
                                    break;
                            }
                            break;
                        case 3:
                            ans_13.Visible = true;
                            ans_13.Text = word;
                            switch (word)
                            {
                                case "Q":
                                    Q_xpos = 3;
                                    Q_ypos = 1;
                                    break;
                                case "W":
                                    W_xpos = 3;
                                    W_ypos = 1;
                                    break;
                                case "E":
                                    E_xpos = 3;
                                    E_ypos = 1;
                                    break;
                                case "R":
                                    R_xpos = 3;
                                    R_ypos = 1;
                                    break;
                            }
                            break;
                    }
                }
            }
            
            for (i = 0; i < 4; ++i)
            {
                int row_rand_num = rd.Next(0, 2);
                int word_rand = rd.Next(0, 4);
                if(row_rand_num == 2 || word_rand == 4)
                {
                    --i;
                    continue;
                }
                string word = "";
                bool back = false;

                switch (word_rand)
                {
                    case 0:
                        if (record_word_Qb == 1)
                        {
                            --i;
                            back = true;
                            break;
                        }
                        word = "Q";
                        record_word_Qb = 1;
                        break;
                    case 1:
                        if (record_word_Wb == 1)
                        {
                            --i;
                            back = true;
                            break;
                        }
                        word = "W";
                        record_word_Wb = 1;
                        break;
                    case 2:
                        if (record_word_Eb == 1)
                        {
                            --i;
                            back = true;
                            break;
                        }
                        word = "E";
                        record_word_Eb = 1;
                        break;
                    case 3:
                        if (record_word_Rb == 1)
                        {
                            --i;
                            back = true;
                            break;
                        }
                        word = "R";
                        record_word_Rb = 1;
                        break;
                }

                if (back)
                    continue;


                if (row_rand_num == 0)
                {
                    switch (i)
                    {
                        case 0:
                            button1.Visible = true;
                            button1.Text = word;
                            switch (word)
                            {
                                case "Q":
                                    Qb_xpos = 0;
                                    Qb_ypos = 0;
                                    break;
                                case "W":
                                    Wb_xpos = 0;
                                    Wb_ypos = 0;
                                    break;
                                case "E":
                                    Eb_xpos = 0;
                                    Eb_ypos = 0;
                                    break;
                                case "R":
                                    Rb_xpos = 0;
                                    Rb_ypos = 0;
                                    break;
                            }
                            break;
                        case 1:
                            button2.Visible = true;
                            button2.Text = word;
                            switch (word)
                            {
                                case "Q":
                                    Qb_xpos = 1;
                                    Qb_ypos = 0;
                                    break;
                                case "W":
                                    Wb_xpos = 1;
                                    Wb_ypos = 0;
                                    break;
                                case "E":
                                    Eb_xpos = 1;
                                    Eb_ypos = 0;
                                    break;
                                case "R":
                                    Rb_xpos = 1;
                                    Rb_ypos = 0;
                                    break;
                            }
                            break;
                        case 2:
                            button3.Visible = true;
                            button3.Text = word;
                            switch (word)
                            {
                                case "Q":
                                    Qb_xpos = 2;
                                    Qb_ypos = 0;
                                    break;
                                case "W":
                                    Wb_xpos = 2;
                                    Wb_ypos = 0;
                                    break;
                                case "E":
                                    Eb_xpos = 2;
                                    Eb_ypos = 0;
                                    break;
                                case "R":
                                    Rb_xpos = 2;
                                    Rb_ypos = 0;
                                    break;
                            }
                            break;
                        case 3:
                            button4.Visible = true;
                            button4.Text = word;
                            switch (word)
                            {
                                case "Q":
                                    Qb_xpos = 3;
                                    Qb_ypos = 0;
                                    break;
                                case "W":
                                    Wb_xpos = 3;
                                    Wb_ypos = 0;
                                    break;
                                case "E":
                                    Eb_xpos = 3;
                                    Eb_ypos = 0;
                                    break;
                                case "R":
                                    Rb_xpos = 3;
                                    Rb_ypos = 0;
                                    break;
                            }
                            break;
                    }
                }
                else if (row_rand_num == 1)
                {
                    switch (i)
                    {
                        case 0:
                            button5.Visible = true;
                            button5.Text = word;
                            switch (word)
                            {
                                case "Q":
                                    Qb_xpos = 0;
                                    Qb_ypos = 1;
                                    break;
                                case "W":
                                    Wb_xpos = 0;
                                    Wb_ypos = 1;
                                    break;
                                case "E":
                                    Eb_xpos = 0;
                                    Eb_ypos = 1;
                                    break;
                                case "R":
                                    Rb_xpos = 0;
                                    Rb_ypos = 1;
                                    break;
                            }
                            break;
                        case 1:
                            button6.Visible = true;
                            button6.Text = word;
                            switch (word)
                            {
                                case "Q":
                                    Qb_xpos = 1;
                                    Qb_ypos = 1;
                                    break;
                                case "W":
                                    Wb_xpos = 1;
                                    Wb_ypos = 1;
                                    break;
                                case "E":
                                    Eb_xpos = 1;
                                    Eb_ypos = 1;
                                    break;
                                case "R":
                                    Rb_xpos = 1;
                                    Rb_ypos = 1;
                                    break;
                            }
                            break;
                        case 2:
                            button7.Visible = true;
                            button7.Text = word;
                            switch (word)
                            {
                                case "Q":
                                    Qb_xpos = 2;
                                    Qb_ypos = 1;
                                    break;
                                case "W":
                                    Wb_xpos = 2;
                                    Wb_ypos = 1;
                                    break;
                                case "E":
                                    Eb_xpos = 2;
                                    Eb_ypos = 1;
                                    break;
                                case "R":
                                    Rb_xpos = 2;
                                    Rb_ypos = 1;
                                    break;
                            }
                            break;
                        case 3:
                            button8.Visible = true;
                            button8.Text = word;
                            switch (word)
                            {
                                case "Q":
                                    Qb_xpos = 3;
                                    Qb_ypos = 1;
                                    break;
                                case "W":
                                    Wb_xpos = 3;
                                    Wb_ypos = 1;
                                    break;
                                case "E":
                                    Eb_xpos = 3;
                                    Eb_ypos = 1;
                                    break;
                                case "R":
                                    Rb_xpos = 3;
                                    Rb_ypos = 1;
                                    break;
                            }
                            break;
                    }
                }
            }
        }

        int now_b;
        private void button1_Click(object sender, EventArgs e)
        {
            now_b = 1;
            X_ScrollBar.Value = button1.Location.X / button1.Width;
            Y_ScrollBar.Value = button1.Location.Y / button1.Width;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            now_b = 2;
            X_ScrollBar.Value = button2.Location.X / button2.Width;
            Y_ScrollBar.Value = button2.Location.Y / button2.Width;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            now_b = 3;
            X_ScrollBar.Value = button3.Location.X / button3.Width;
            Y_ScrollBar.Value = button3.Location.Y / button3.Width;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            now_b = 4;
            X_ScrollBar.Value = button4.Location.X / button4.Width;
            Y_ScrollBar.Value = button4.Location.Y / button4.Width;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            now_b = 5;
            X_ScrollBar.Value = button5.Location.X / button5.Width;
            Y_ScrollBar.Value = button5.Location.Y / button5.Width;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            now_b = 6;
            X_ScrollBar.Value = button6.Location.X / button6.Width;
            Y_ScrollBar.Value = button6.Location.Y / button6.Width;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            now_b = 7;
            X_ScrollBar.Value = button7.Location.X / button7.Width;
            Y_ScrollBar.Value = button7.Location.Y / button7.Width;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            now_b = 8;
            X_ScrollBar.Value = button8.Location.X / button8.Width;
            Y_ScrollBar.Value = button8.Location.Y / button8.Width;

        }
        private void X_ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int temp_x;
            switch (now_b)
            {
                case 1:
                    temp_x = button1.Location.X;
                    button1.Location = new Point(X_ScrollBar.Value * button1.Width, button1.Location.Y);
                    switch (button1.Text)
                    {
                        case "Q":
                            if (temp_x < button1.Location.X)
                                Qb_xpos++;
                            else if (temp_x > button1.Location.X)
                                Qb_xpos--;
                            break;
                        case "W":
                            if (temp_x < button1.Location.X)
                                Wb_xpos++;
                            else if (temp_x > button1.Location.X)
                                Wb_xpos--;
                            break;
                        case "E":
                            if (temp_x < button1.Location.X)
                                Eb_xpos++;
                            else if (temp_x > button1.Location.X)
                                Eb_xpos--;
                            break;
                        case "R":
                            if (temp_x < button1.Location.X)
                                Rb_xpos++;
                            else if (temp_x > button1.Location.X)
                                Rb_xpos--;
                            break;
                    }
                    break;
                case 2:
                    temp_x = button2.Location.X;
                    button2.Location = new Point(X_ScrollBar.Value * button2.Width, button2.Location.Y);
                    switch (button2.Text)
                    {
                        case "Q":
                            if (temp_x < button2.Location.X)
                                Qb_xpos++;
                            else if (temp_x > button2.Location.X)
                                Qb_xpos--;
                            break;
                        case "W":
                            if (temp_x < button2.Location.X)
                                Wb_xpos++;
                            else if (temp_x > button2.Location.X)
                                Wb_xpos--;
                            break;
                        case "E":
                            if (temp_x < button2.Location.X)
                                Eb_xpos++;
                            else if (temp_x > button2.Location.X)
                                Eb_xpos--;
                            break;
                        case "R":
                            if (temp_x < button2.Location.X)
                                Rb_xpos++;
                            else if (temp_x > button2.Location.X)
                                Rb_xpos--;
                            break;
                    }
                    break;
                case 3:
                    temp_x = button3.Location.X;
                    button3.Location = new Point(X_ScrollBar.Value * button3.Width, button3.Location.Y);
                    switch (button3.Text)
                    {
                        case "Q":
                            if (temp_x < button3.Location.X)
                                Qb_xpos++;
                            else if (temp_x > button3.Location.X)
                                Qb_xpos--;
                            break;
                        case "W":
                            if (temp_x < button3.Location.X)
                                Wb_xpos++;
                            else if (temp_x > button3.Location.X)
                                Wb_xpos--;
                            break;
                        case "E":
                            if (temp_x < button3.Location.X)
                                Eb_xpos++;
                            else if (temp_x > button3.Location.X)
                                Eb_xpos--;
                            break;
                        case "R":
                            if (temp_x < button3.Location.X)
                                Rb_xpos++;
                            else if (temp_x > button3.Location.X)
                                Rb_xpos--;
                            break;
                    }
                    break;
                case 4:
                    temp_x = button4.Location.X;
                    button4.Location = new Point(X_ScrollBar.Value * button4.Width, button4.Location.Y);
                    switch (button4.Text)
                    {
                        case "Q":
                            if (temp_x < button4.Location.X)
                                Qb_xpos++;
                            else if (temp_x > button4.Location.X)
                                Qb_xpos--;
                            break;
                        case "W":
                            if (temp_x < button4.Location.X)
                                Wb_xpos++;
                            else if (temp_x > button4.Location.X)
                                Wb_xpos--;
                            break;
                        case "E":
                            if (temp_x < button4.Location.X)
                                Eb_xpos++;
                            else if (temp_x > button4.Location.X)
                                Eb_xpos--;
                            break;
                        case "R":
                            if (temp_x < button4.Location.X)
                                Rb_xpos++;
                            else if (temp_x > button4.Location.X)
                                Rb_xpos--;
                            break;
                    }
                    break;
                case 5:
                    temp_x = button5.Location.X;
                    button5.Location = new Point(X_ScrollBar.Value * button5.Width, button5.Location.Y);
                    switch (button5.Text)
                    {
                        case "Q":
                            if (temp_x < button5.Location.X)
                                Qb_xpos++;
                            else if (temp_x > button5.Location.X)
                                Qb_xpos--;
                            break;
                        case "W":
                            if (temp_x < button5.Location.X)
                                Wb_xpos++;
                            else if (temp_x > button5.Location.X)
                                Wb_xpos--;
                            break;
                        case "E":
                            if (temp_x < button5.Location.X)
                                Eb_xpos++;
                            else if (temp_x > button5.Location.X)
                                Eb_xpos--;
                            break;
                        case "R":
                            if (temp_x < button5.Location.X)
                                Rb_xpos++;
                            else if (temp_x > button5.Location.X)
                                Rb_xpos--;
                            break;
                    }
                    break;
                case 6:
                    temp_x = button6.Location.X;
                    button6.Location = new Point(X_ScrollBar.Value * button6.Width, button6.Location.Y);
                    switch (button6.Text)
                    {
                        case "Q":
                            if (temp_x < button6.Location.X)
                                Qb_xpos++;
                            else if (temp_x > button6.Location.X)
                                Qb_xpos--;
                            break;
                        case "W":
                            if (temp_x < button6.Location.X)
                                Wb_xpos++;
                            else if (temp_x > button6.Location.X)
                                Wb_xpos--;
                            break;
                        case "E":
                            if (temp_x < button6.Location.X)
                                Eb_xpos++;
                            else if (temp_x > button6.Location.X)
                                Eb_xpos--;
                            break;
                        case "R":
                            if (temp_x < button6.Location.X)
                                Rb_xpos++;
                            else if (temp_x > button6.Location.X)
                                Rb_xpos--;
                            break;
                    }
                    break;
                case 7:
                    temp_x = button7.Location.X;
                    button7.Location = new Point(X_ScrollBar.Value * button7.Width, button7.Location.Y);
                    switch (button7.Text)
                    {
                        case "Q":
                            if (temp_x < button7.Location.X)
                                Qb_xpos++;
                            else if (temp_x > button7.Location.X)
                                Qb_xpos--;
                            break;
                        case "W":
                            if (temp_x < button7.Location.X)
                                Wb_xpos++;
                            else if (temp_x > button7.Location.X)
                                Wb_xpos--;
                            break;
                        case "E":
                            if (temp_x < button7.Location.X)
                                Eb_xpos++;
                            else if (temp_x > button7.Location.X)
                                Eb_xpos--;
                            break;
                        case "R":
                            if (temp_x < button7.Location.X)
                                Rb_xpos++;
                            else if (temp_x > button7.Location.X)
                                Rb_xpos--;
                            break;
                    }
                    break;
                case 8:
                    temp_x = button8.Location.X;
                    button8.Location = new Point(X_ScrollBar.Value * button8.Width, button8.Location.Y);
                    switch (button8.Text)
                    {
                        case "Q":
                            if (temp_x < button8.Location.X)
                                Qb_xpos++;
                            else if (temp_x > button8.Location.X)
                                Qb_xpos--;
                            break;
                        case "W":
                            if (temp_x < button8.Location.X)
                                Wb_xpos++;
                            else if (temp_x > button8.Location.X)
                                Wb_xpos--;
                            break;
                        case "E":
                            if (temp_x < button8.Location.X)
                                Eb_xpos++;
                            else if (temp_x > button8.Location.X)
                                Eb_xpos--;
                            break;
                        case "R":
                            if (temp_x < button8.Location.X)
                                Rb_xpos++;
                            else if (temp_x > button8.Location.X)
                                Rb_xpos--;
                            break;
                    }
                    break;
            }
            if (Q_xpos == Qb_xpos && W_xpos == Wb_xpos && E_xpos == Eb_xpos && R_xpos == Rb_xpos && Q_ypos == Qb_ypos && W_ypos == Wb_ypos && E_ypos == Eb_ypos && R_ypos == Rb_ypos)
            {
                timer1.Enabled = false;
                DialogResult result;
                result = MessageBox.Show("Done!" + time_set.Text, "", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {

                }
            }
        }

        private void Y_ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int temp_y;
            switch (now_b)
            {
                case 1:
                    temp_y = button1.Location.Y;
                    button1.Location = new Point(button1.Location.X, Y_ScrollBar.Value * button1.Height + 30);
                    switch (button1.Text)
                    {
                        case "Q":
                            if (temp_y < button1.Location.Y)
                                Qb_ypos++;
                            else if (temp_y > button1.Location.Y)
                                Qb_ypos--;
                            break;
                        case "W":
                            if (temp_y < button1.Location.Y)
                                Wb_ypos++;
                            else if (temp_y > button1.Location.Y)
                                Wb_ypos--;
                            break;
                        case "E":
                            if (temp_y < button1.Location.Y)
                                Eb_ypos++;
                            else if (temp_y > button1.Location.Y)
                                Eb_ypos--;
                            break;
                        case "R":
                            if (temp_y < button1.Location.Y)
                                Rb_ypos++;
                            else if (temp_y > button1.Location.Y)
                                Rb_ypos--;
                            break;
                    }
                    break;
                case 2:
                    temp_y = button2.Location.Y;
                    button2.Location = new Point(button2.Location.X, Y_ScrollBar.Value * button2.Height + 30);
                    switch (button2.Text)
                    {
                        case "Q":
                            if (temp_y < button2.Location.Y)
                                Qb_ypos++;
                            else if (temp_y > button2.Location.Y)
                                Qb_ypos--;
                            break;
                        case "W":
                            if (temp_y < button2.Location.Y)
                                Wb_ypos++;
                            else if (temp_y > button2.Location.Y)
                                Wb_ypos--;
                            break;
                        case "E":
                            if (temp_y < button2.Location.Y)
                                Eb_ypos++;
                            else if (temp_y > button2.Location.Y)
                                Eb_ypos--;
                            break;
                        case "R":
                            if (temp_y < button2.Location.Y)
                                Rb_ypos++;
                            else if (temp_y > button2.Location.Y)
                                Rb_ypos--;
                            break;
                    }
                    break;
                case 3:
                    temp_y = button3.Location.Y;
                    button3.Location = new Point(button3.Location.X, Y_ScrollBar.Value * button3.Height + 30);
                    switch (button3.Text)
                    {
                        case "Q":
                            if (temp_y < button3.Location.Y)
                                Qb_ypos++;
                            else if (temp_y > button3.Location.Y)
                                Qb_ypos--;
                            break;
                        case "W":
                            if (temp_y < button3.Location.Y)
                                Wb_ypos++;
                            else if (temp_y > button3.Location.Y)
                                Wb_ypos--;
                            break;
                        case "E":
                            if (temp_y < button3.Location.Y)
                                Eb_ypos++;
                            else if (temp_y > button3.Location.Y)
                                Eb_ypos--;
                            break;
                        case "R":
                            if (temp_y < button3.Location.Y)
                                Rb_ypos++;
                            else if (temp_y > button3.Location.Y)
                                Rb_ypos--;
                            break;
                    }
                    break;
                case 4:
                    temp_y = button4.Location.Y;
                    button4.Location = new Point(button4.Location.X, Y_ScrollBar.Value * button4.Height + 30);
                    switch (button4.Text)
                    {
                        case "Q":
                            if (temp_y < button4.Location.Y)
                                Qb_ypos++;
                            else if (temp_y > button4.Location.Y)
                                Qb_ypos--;
                            break;
                        case "W":
                            if (temp_y < button4.Location.Y)
                                Wb_ypos++;
                            else if (temp_y > button4.Location.Y)
                                Wb_ypos--;
                            break;
                        case "E":
                            if (temp_y < button4.Location.Y)
                                Eb_ypos++;
                            else if (temp_y > button4.Location.Y)
                                Eb_ypos--;
                            break;
                        case "R":
                            if (temp_y < button4.Location.Y)
                                Rb_ypos++;
                            else if (temp_y > button4.Location.Y)
                                Rb_ypos--;
                            break;
                    }
                    break;
                case 5:
                    temp_y = button5.Location.Y;
                    button5.Location = new Point(button5.Location.X, Y_ScrollBar.Value * button5.Height + 30);
                    switch (button5.Text)
                    {
                        case "Q":
                            if (temp_y < button5.Location.Y)
                                Qb_ypos++;
                            else if (temp_y > button5.Location.Y)
                                Qb_ypos--;
                            break;
                        case "W":
                            if (temp_y < button5.Location.Y)
                                Wb_ypos++;
                            else if (temp_y > button5.Location.Y)
                                Wb_ypos--;
                            break;
                        case "E":
                            if (temp_y < button5.Location.Y)
                                Eb_ypos++;
                            else if (temp_y > button5.Location.Y)
                                Eb_ypos--;
                            break;
                        case "R":
                            if (temp_y < button5.Location.Y)
                                Rb_ypos++;
                            else if (temp_y > button5.Location.Y)
                                Rb_ypos--;
                            break;
                    }
                    break;
                case 6:
                    temp_y = button6.Location.Y;
                    button6.Location = new Point(button6.Location.X, Y_ScrollBar.Value * button6.Height + 30);
                    switch (button6.Text)
                    {
                        case "Q":
                            if (temp_y < button6.Location.Y)
                                Qb_ypos++;
                            else if (temp_y > button6.Location.Y)
                                Qb_ypos--;
                            break;
                        case "W":
                            if (temp_y < button6.Location.Y)
                                Wb_ypos++;
                            else if (temp_y > button6.Location.Y)
                                Wb_ypos--;
                            break;
                        case "E":
                            if (temp_y < button6.Location.Y)
                                Eb_ypos++;
                            else if (temp_y > button6.Location.Y)
                                Eb_ypos--;
                            break;
                        case "R":
                            if (temp_y < button6.Location.Y)
                                Rb_ypos++;
                            else if (temp_y > button6.Location.Y)
                                Rb_ypos--;
                            break;
                    }
                    break;
                case 7:
                    temp_y = button7.Location.Y;
                    button7.Location = new Point(button7.Location.X, Y_ScrollBar.Value * button7.Height + 30);
                    switch (button7.Text)
                    {
                        case "Q":
                            if (temp_y < button7.Location.Y)
                                Qb_ypos++;
                            else if (temp_y > button7.Location.Y)
                                Qb_ypos--;
                            break;
                        case "W":
                            if (temp_y < button7.Location.Y)
                                Wb_ypos++;
                            else if (temp_y > button7.Location.Y)
                                Wb_ypos--;
                            break;
                        case "E":
                            if (temp_y < button7.Location.Y)
                                Eb_ypos++;
                            else if (temp_y > button7.Location.Y)
                                Eb_ypos--;
                            break;
                        case "R":
                            if (temp_y < button7.Location.Y)
                                Rb_ypos++;
                            else if (temp_y > button7.Location.Y)
                                Rb_ypos--;
                            break;
                    }
                    break;
                case 8:
                    temp_y = button8.Location.Y;
                    button8.Location = new Point(button8.Location.X, Y_ScrollBar.Value * button8.Height + 30);
                    switch (button8.Text)
                    {
                        case "Q":
                            if (temp_y < button8.Location.Y)
                                Qb_ypos++;
                            else if (temp_y > button8.Location.Y)
                                Qb_ypos--;
                            break;
                        case "W":
                            if (temp_y < button8.Location.Y)
                                Wb_ypos++;
                            else if (temp_y > button8.Location.Y)
                                Wb_ypos--;
                            break;
                        case "E":
                            if (temp_y < button8.Location.Y)
                                Eb_ypos++;
                            else if (temp_y > button8.Location.Y)
                                Eb_ypos--;
                            break;
                        case "R":
                            if (temp_y < button8.Location.Y)
                                Rb_ypos++;
                            else if (temp_y > button8.Location.Y)
                                Rb_ypos--;
                            break;
                    }
                    break;
            }
            if (Q_xpos == Qb_xpos && W_xpos == Wb_xpos && E_xpos == Eb_xpos && R_xpos == Rb_xpos && Q_ypos == Qb_ypos && W_ypos == Wb_ypos && E_ypos == Eb_ypos && R_ypos == Rb_ypos)
            {
                timer1.Enabled = false;
                DialogResult result;
                result = MessageBox.Show("Done!" + time_set.Text, "", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {

                }
            }
        }
    }
}
