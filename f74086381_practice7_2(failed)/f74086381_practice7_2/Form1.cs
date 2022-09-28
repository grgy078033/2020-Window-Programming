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

namespace f74086381_practice7_2
{
    public partial class Form1 : Form
    {
        int Car_width = 50;
        public int[,] record = new int[6, 6];
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = false;
        }
        string filename = @"..\Debug\test.map.txt";
        int time_count = 1;


        private void timer1_Tick(object sender, EventArgs e)
        {
            ++time_count;
            time_set.Text = "Used Time : " + time_count + " second";
        }
        Button[] b = new Button[100];
        Car car;
        int index = -1;
        int now_b;
        private void Form1_Load(object sender, EventArgs e)
        {
            car = new Car();
            timer1.Enabled = true;
            time_set.Text = "Used Time : " + time_count + " second";
            StreamReader sr = new StreamReader(filename);
            string map;
            while ((map = sr.ReadLine()) != null) // 讀取一行資料
            {
                ++index;
                b[index] = new Button();
                string[] data = map.Split(' ');

                b[index].Text = data[0]; // button.text = data[0];
                switch (data[1])// R : length = 2 * Car_width , color = Red;
                                // V : length = 3 * Car_width , color = LightBlue;
                                // B : length = 4 * Car_width , color = Yellow;
                {
                    case "R":
                        car = new RedCar();
                        break;
                    case "V":
                        car = new Van();
                        break;
                    case "B":
                        car = new Bus();
                        break;
                }
                if (data[2] == "0") // 縱向
                {
                    b[index].SetBounds(Convert.ToInt32(data[3]) * Car_width, 8 + Convert.ToInt32(data[4]) * Car_width, Car_width, car.get_length() * Car_width);
                }
                else if (data[2] == "1") // 橫向
                {
                    b[index].SetBounds(Convert.ToInt32(data[3]) * Car_width, 8 + Convert.ToInt32(data[4]) * Car_width, car.get_length() * Car_width, Car_width);
                }
                if (data[2] == "0") {
                    if (car.get_type() == "RedCar")
                    {
                        for (int i = 0; i < b[index].Height / 50; ++i)
                        {
                            record[(b[index].Location.X / 50), (b[index].Location.Y / 50) + i] = 2;
                        }
                    }
                    else if (car.get_type() == "Van" || car.get_type() == "Bus")
                    {
                        for (int i = 0; i < b[index].Height / 50; ++i)
                        {
                            record[(b[index].Location.X / 50), (b[index].Location.Y / 50) + i] = 1;
                        }
                    }
                }
                if (data[2] == "1")
                {
                    if (car.get_type() == "RedCar")
                    {
                        for (int i = 0; i < b[index].Width / 50; ++i)
                        {
                            record[(b[index].Location.X / 50) + i, (b[index].Location.Y / 50)] = 2;
                        }
                    }
                    else if (car.get_type() == "Van" || car.get_type() == "Bus")
                    {
                        for (int i = 0; i < b[index].Width / 50; ++i)
                        {
                            record[(b[index].Location.X / 50) + i, (b[index].Location.Y / 50)] = 1;
                        }
                    }
                }
                switch (car.get_color())
                {
                    case "Red":
                        b[index].BackColor = Color.Red;
                        break;
                    case "LightBlue":
                        b[index].BackColor = Color.LightBlue;
                        break;
                    case "Yellow":
                        b[index].BackColor = Color.Yellow;
                        break;
                }
                b[index].Visible = true;
                b[index].Enabled = true;
                b[index].BringToFront();
                b[index].Click += new EventHandler(btn_click);
                this.Controls.Add(b[index]);
            }
            groupBox1.SendToBack();
            sr.Close();

            for (int i = 0; i < 6; ++i)
            {
                for (int j = 0; j < 6; ++j)
                {
                    label2.Text += Convert.ToString(record[j, i]) + " ";
                }
                label2.Text += "\r\n";
            }
        }
        Button test = new Button();
        private void btn_click(object sender, EventArgs e)
        {
            now_b = Convert.ToInt32(((Button)(sender)).Text)-1;
        }
        private void button_restart_Click(object sender, EventArgs e)
        {
            time_count = 1; //重計時間
            car = new Car();
            timer1.Enabled = true;
            time_set.Text = "Used Time : " + time_count + " second";
            for(int i = 0; i < index; ++i)
            {
                this.Controls.Remove(b[i]);
            }
            StreamReader sr = new StreamReader(filename); //再導入一次map
            string map;
            index = -1;
            while ((map = sr.ReadLine()) != null) // 讀取一行資料
            {
                ++index;
                b[index] = new Button();
                string[] data = map.Split(' ');

                b[index].Text = data[0]; // button.text = data[0];
                switch (data[1])// R : length = 2 * Car_width , color = Red;
                                // V : length = 3 * Car_width , color = LightBlue;
                                // B : length = 4 * Car_width , color = Yellow;
                {
                    case "R":
                        car = new RedCar();
                        break;
                    case "V":
                        car = new Van();
                        break;
                    case "B":
                        car = new Bus();
                        break;
                }
                if (data[2] == "0") // 縱向
                    b[index].SetBounds(Convert.ToInt32(data[3]) * Car_width, 8 + Convert.ToInt32(data[4]) * Car_width, Car_width, car.get_length() * Car_width);
                else if (data[2] == "1") // 橫向
                    b[index].SetBounds(Convert.ToInt32(data[3]) * Car_width, 8 + Convert.ToInt32(data[4]) * Car_width, car.get_length() * Car_width, Car_width);
                switch (car.get_color())
                {
                    case "Red":
                        b[index].BackColor = Color.Red;
                        break;
                    case "LightBlue":
                        b[index].BackColor = Color.LightBlue;
                        break;
                    case "Yellow":
                        b[index].BackColor = Color.Yellow;
                        break;
                }
                b[index].Visible = true;
                b[index].Enabled = true;
                b[index].BringToFront();
                groupBox1.SendToBack();
                this.Controls.Add(b[index]);
            }
            for (int i = 0; i <= index; ++i)
            {
                b[i].Click += new EventHandler(btn_click);
            }
            sr.Close();
            label2.Text = "";
            for (int i = 0; i < 6; ++i)
            {
                for (int j = 0; j < 6; ++j)
                {
                    label2.Text += Convert.ToString(record[j, i]) + " ";
                }
                label2.Text += "\r\n";
            }
        }
        public int good_up = 0;
        public int good_left = 0;
        public int good_down = 0;
        public int good_right = 0;
        public int now_b_x = 0;
        public int now_b_y = 0;
        private void button_Up_Click(object sender, EventArgs e) //移動
        {
            good_up = 0;
            now_b_x = b[now_b].Location.X;
            if (b[now_b].Location.Y - Car_width < 8)
            {
            }
            else
            {
                for (int i = 0; i <= index; ++i)
                {
                    if (i == now_b)
                    {
                        good_up++;
                    }
                    else
                    {
                        if (b[now_b].Location.Y == b[i].Location.Y + b[i].Height)
                        {
                            for (int j = 0; j < b[now_b].Width / 50; j++, now_b_x += Car_width)
                            {
                                if (now_b_x >= b[i].Location.X && now_b_x + Car_width <= b[i].Location.X + b[i].Width)
                                {
                                        break;
                                }
                                else
                                    if (j == b[now_b].Width / 50 - 1)
                                        good_up++;
                            }
                        }
                        else
                        {
                            good_up++;
                        }
                    }
                    if (good_up == index + 1)
                        b[now_b].Location = new Point(b[now_b].Location.X, b[now_b].Location.Y - Car_width);
                }
            }
            label1.Text = index.ToString();
            if (b[now_b].Height >= 100)
            {
                if (b[now_b].Height == 100)
                {
                    record[b[now_b].Location.X / 50, b[now_b].Location.Y / 50 + b[now_b].Height / 50] = 0;
                    for (int i = 0; i < b[now_b].Height / 50; ++i)
                    {
                        record[(b[now_b].Location.X / 50), (b[now_b].Location.Y / 50) + i] = 2;
                    }
                }
                else if (b[now_b].Height > 100)
                {
                    record[b[now_b].Location.X / 50, b[now_b].Location.Y / 50 + b[now_b].Height / 50] = 0;
                    for (int i = 0; i < (b[now_b].Height / 50); ++i)
                    {
                        record[(b[now_b].Location.X / 50), (b[now_b].Location.Y / 50) + i] = 1;
                    }
                }
            }
            if (b[now_b].Width >= 100)
            {
                if (b[now_b].Width == 100)
                {
                    for (int i = 0; i < b[now_b].Width / 50; ++i)
                    {
                        record[b[now_b].Location.X / 50 + i, b[now_b].Location.Y / 50 + b[now_b].Height / 50] = 0;
                        record[(b[now_b].Location.X / 50) + i, (b[now_b].Location.Y / 50)] = 2;
                    }
                }
                else if (b[now_b].Width > 100)
                {
                    for (int i = 0; i < b[now_b].Width / 50; ++i)
                    {
                        record[b[now_b].Location.X / 50 + i, b[now_b].Location.Y / 50 + b[now_b].Height / 50] = 0;
                        record[(b[now_b].Location.X / 50) + i, (b[now_b].Location.Y / 50)] = 1;
                    }
                }
            }
            label2.Text = "";
            for (int i = 0; i < 6; ++i)
            {
                for (int j = 0; j < 6; ++j)
                {
                    label2.Text += Convert.ToString(record[j, i]) + " ";
                }
                label2.Text += "\r\n";
            }
        }
        

        private void button_Left_Click(object sender, EventArgs e)
        {
            good_left = 0;
            now_b_y = b[now_b].Location.Y;
            if (b[now_b].Location.X == 0)
            {
            }
            else
            {
                for (int i = 0; i <= index; ++i)
                {
                    if (i == now_b)
                    {
                        good_left++;
                    }
                    else
                    {
                        if (b[now_b].Location.X == b[i].Location.X + b[i].Width)
                        {
                            for (int j = 0; j < b[now_b].Height / 50; j++, now_b_y += Car_width)
                            {
                                if ((now_b_y >= b[i].Location.Y && now_b_y + Car_width <= b[i].Location.Y + b[i].Height))
                                {
                                    break;
                                }
                                else
                                {
                                    if (j == b[now_b].Height / 50 - 1)
                                    {
                                        good_left++;
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            good_left++;
                        }
                    }
                    if (good_left == index + 1)
                        b[now_b].Location = new Point(b[now_b].Location.X - Car_width, b[now_b].Location.Y);
                }
            }
            label2.Text = good_left.ToString();
            if (b[now_b].Height >= 100)
            {
                if (b[now_b].Height == 100)
                {
                    for (int i = 0; i < b[index].Height / 50; ++i)
                    {
                        record[(b[now_b].Location.X / 50), (b[now_b].Location.Y / 50)] = 2;
                    }
                }
                else if (b[now_b].Height > 100)
                {
                    for (int i = 0; i < b[index].Height / 50; ++i)
                    {
                        record[(b[now_b].Location.X / 50), (b[now_b].Location.Y / 50)] = 1;
                    }
                }
            }
            if (b[now_b].Width >= 100)
            {
                if (b[now_b].Width == 100)
                {
                    for (int i = 0; i < b[index].Width / 50; ++i)
                    {
                        record[(b[now_b].Location.X / 50), (b[now_b].Location.Y / 50) - i] = 2;
                    }
                }
                else if (b[now_b].Width > 100)
                {
                    for (int i = 0; i < b[index].Width / 50; ++i)
                    {
                        record[(b[now_b].Location.X / 50), (b[now_b].Location.Y / 50) - i] = 1;
                    }
                }
            }
            label2.Text = "";
            for (int i = 0; i < 6; ++i)
            {
                for (int j = 0; j < 6; ++j)
                {
                    label2.Text += Convert.ToString(record[j, i]) + " ";
                }
                label2.Text += "\r\n";
            }
        }

        private void button_Down_Click(object sender, EventArgs e)
        {
            label1.Text = index.ToString();
            good_down = 0;
            now_b_x = b[now_b].Location.X;
            if (b[now_b].Location.Y + b[now_b].Height > 258)
            {
            }
            else
            {
                for (int i = 0; i <= index; ++i)
                {
                    if (i == now_b)
                    {
                        good_down++;
                    }
                    else
                    {
                        if (b[now_b].Location.Y + b[now_b].Height == b[i].Location.Y)
                        {
                            for (int j = 0; j < b[now_b].Width / 50; j++, now_b_x += Car_width)
                            {
                                if ((now_b_x >= b[i].Location.X && now_b_x + Car_width <= b[i].Location.X + b[i].Width))
                                {
                                    break;
                                }
                                else
                                {
                                    if (j == b[now_b].Width / 50 - 1)
                                        good_down++;
                                }
                            }
                        }
                        else
                        {
                            good_down++;
                        }
                    }
                    if (good_down == index + 1)
                        b[now_b].Location = new Point(b[now_b].Location.X, b[now_b].Location.Y + Car_width);
                }
            }
            label2.Text = good_down.ToString();
            if (b[now_b].Height >= 100)
            {
                if (b[now_b].Height == 100)
                {
                    record[b[now_b].Location.X / 50, b[now_b].Location.Y / 50 + b[now_b].Height / 50] = 0;
                    for (int i = 0; i < b[now_b].Height / 50; ++i)
                    {
                        record[(b[now_b].Location.X / 50), (b[now_b].Location.Y / 50)] = 2;
                    }
                }
                else if (b[now_b].Height > 100)
                {
                    record[b[now_b].Location.X / 50, b[now_b].Location.Y / 50 + b[now_b].Height / 50] = 0;
                    for (int i = 0; i < (b[now_b].Height / 50); ++i)
                    {
                        record[(b[now_b].Location.X / 50), (b[now_b].Location.Y / 50)] = 1;
                    }
                }
            }
            if (b[now_b].Width >= 100)
            {
                if (b[now_b].Width == 100)
                {
                    for (int i = 0; i < b[now_b].Width / 50; ++i)
                    {
                        record[b[now_b].Location.X / 50 + i, (b[now_b].Location.Y / 50)] = 2;
                        record[b[now_b].Location.X / 50 + i, b[now_b].Location.Y / 50 - 1] = 0;
                    }
                }
                else if (b[now_b].Width > 100)
                {
                    for (int i = 0; i < b[now_b].Width / 50; ++i)
                    {
                        record[b[now_b].Location.X / 50 + i, (b[now_b].Location.Y / 50)] = 1;
                        record[b[now_b].Location.X / 50 + i, b[now_b].Location.Y / 50 - 1] = 0;
                    }
                }
            }
            label2.Text = "";
            for (int i = 0; i < 6; ++i)
            {
                for (int j = 0; j < 6; ++j)
                {
                    label2.Text += Convert.ToString(record[j, i]) + " ";
                }
                label2.Text += "\r\n";
            }
        }

        private void button_Right_Click(object sender, EventArgs e)
        {
            good_right = 0;
            now_b_y = b[now_b].Location.Y;
            record[b[now_b].Location.X / 50, b[now_b].Location.Y / 50 + b[now_b].Height / 50 - 1] = 0;
            if (b[now_b].Location.X == 250)
            {
            }
            else
            {
                for (int i = 0; i <= index; ++i)
                {
                    if (i == now_b)
                    {
                        good_right++;
                    }
                    else
                    {
                        if (b[now_b].Location.X + b[now_b].Width == b[i].Location.X)
                        {
                            for (int j = 0; j < b[now_b].Height / 50; j++, now_b_y += Car_width)
                            {
                                if ((now_b_y >= b[i].Location.Y && now_b_y + Car_width <= b[i].Location.Y + b[i].Height))
                                {
                                    break;
                                }
                                else
                                {
                                    if (j == b[now_b].Height / 50 - 1)
                                    {
                                        good_right++;
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            good_right++;
                        }
                    }
                    if (good_right == index + 1)
                        b[now_b].Location = new Point(b[now_b].Location.X + Car_width, b[now_b].Location.Y);
                }
            }
            label2.Text = good_right.ToString();
        }
        private void button_Import_Click(object sender, EventArgs e) //自動解答
        {
            OpenFileDialog import = new OpenFileDialog();
            import.Title = "Open";
            import.InitialDirectory = @"..\Debug";
            import.Filter = "All files（*.*）|*.*|All files(*.*)|*.* ";
            import.RestoreDirectory = true;
            string ans_filename = "";
            if (import.ShowDialog() == DialogResult.OK)
            {
                ans_filename = Path.GetFileNameWithoutExtension(import.FileName);
            }
            StreamReader sr2 = new StreamReader(ans_filename);
            string ans;
            while ((ans = sr2.ReadLine()) != null)
            {
                string[] ans_data = ans.Split(' ');
                label1.Text = ans_data[0] + " " + ans_data[1] + ans_data[3] + "\r\n";
            }
        }
    }
}
