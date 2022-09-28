using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsProgrammingProject
{
    public partial class Form1 : Form
    {
        bool b_delete_class = false;
        bool b_sort_class = false;
        bool statistic = false;
        int mon1;
        int mon2;
        string temp_year;
        string temp_month;
        string temp_class;
        List<Button> b_list = new List<Button>();
        List<RadioButton> rb_list = new List<RadioButton>();
        int[] depId;
        //時間函數
        DateTime dt = DateTime.Now;
        //指定階層為1(初始)
        int layer = 1;
        //要連接資料庫所需要的 SqlConnection 物件
        SqlConnection dataConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|track.mdf;Integrated Security=True");
        private void DBinsert()
        {
            dataConnection.Open();

            SqlCommand mySqlCmd = new SqlCommand("Insert", dataConnection);
            mySqlCmd.CommandType = CommandType.StoredProcedure;

            mySqlCmd.Parameters.AddWithValue("@param1", Class_comboBox.Text);
            mySqlCmd.Parameters.AddWithValue("@param2", Item_textBox.Text);
            mySqlCmd.Parameters.AddWithValue("@param3", Price_textBox.Text);
            mySqlCmd.Parameters.AddWithValue("@param4", Year_comboBox.Text);
            mySqlCmd.Parameters.AddWithValue("@param5", Month_comboBox.Text);
            mySqlCmd.Parameters.AddWithValue("@param6", Day_comboBox.Text);
            mySqlCmd.Parameters.AddWithValue("@param7", Else_textBox.Text);
            mySqlCmd.ExecuteNonQuery();

            dataConnection.Close();
        }
        void FirstHide()
        {
            //label
            Time_label.Visible = false;
            Class_label.Visible = false;
            Item_label.Visible = false;
            Price_label.Visible = false;
            Else_label.Visible = false;
            Year_label.Visible = false;
            Month_label.Visible = false;
            Day_label.Visible = false;
            //comboBox
            Class_comboBox.Visible = false;
            Year_comboBox.Visible = false;
            Month_comboBox.Visible = false;
            Day_comboBox.Visible = false;
            //textBox
            Item_textBox.Visible = false;
            Price_textBox.Visible = false;
            Else_textBox.Visible = false;
            Perform_textBox.Visible = false;
            //pictureBox
            Setting_pictureBox.Visible = false;
            Add_pictureBox.Visible = false;
        }

        void FirstShow()
        {
            //label
            Time_label.Visible = true;
            Class_label.Visible = true;
            Item_label.Visible = true;
            Price_label.Visible = true;
            Else_label.Visible = true;
            Year_label.Visible = true;
            Month_label.Visible = true;
            Day_label.Visible = true;
            Title_label.Visible = false;
            //comboBox
            Class_comboBox.Visible = true;
            Year_comboBox.Visible = true;
            Month_comboBox.Visible = true;
            Day_comboBox.Visible = true;
            //textBox
            Item_textBox.Visible = true;
            Price_textBox.Visible = true;
            Else_textBox.Visible = true;
            Perform_textBox.Visible = true;
            //pictureBox
            Setting_pictureBox.Visible = true;
            Add_pictureBox.Visible = true;
            //layer
            layer = 1;
        }

        void SecondHide()
        {
            //label
            Search_label.Visible = false;
            Cust_label.Visible = false;
            Statistic_label.Visible = false;
            Budget_label.Visible = false;
            ClassSetting_label.Visible = false;
            Game_label.Visible = false;
            Line1_label.Visible = false;//adjust
            //pictureBox
            Search_pictureBox.Visible = false;
            Cust_pictureBox.Visible = false;
            Statistic_pictureBox.Visible = false;
            Budget_pictureBox.Visible = false;
            ClassSetting_pictureBox.Visible = false;
            Game_pictureBox.Visible = false;
            //Button
            Back_btn.Visible = false;
        }

        void SecondShow()
        {
            //label
            Title_label.Text = "設定";
            Title_label.Visible = true;
            Search_label.Visible = true;
            Cust_label.Visible = true;
            Statistic_label.Visible = true;
            Budget_label.Visible = true;
            ClassSetting_label.Visible = true;
            Game_label.Visible = true;
            Line1_label.Visible = true;//adjust
            //pictureBox
            Search_pictureBox.Visible = true;
            Cust_pictureBox.Visible = true;
            Statistic_pictureBox.Visible = true;
            Budget_pictureBox.Visible = true;
            ClassSetting_pictureBox.Visible = true;
            Game_pictureBox.Visible = true;
            //Button
            Back_btn.Visible = true;
            //layer
            layer = 2;
        }

        void ClassHide()
        {
            Class_label.Visible = false;
            Year_label.Visible = false;
            Month_label.Visible = false;
            //comboBox
            Class_comboBox.Visible = false;
            Year_comboBox.Visible = false;
            Month_comboBox.Visible = false;
            //dataGridView
            Class_dataGridView.Visible = false;
            //checkbox
            class_checkbox.Visible = false;
        }

        void ClassShow()
        {
            Title_label.Text = "搜尋紀錄";
            layer = 3;
            SecondHide();
            Back_btn.Visible = true;
            //label
            Class_label.Visible = true;
            Year_label.Visible = true;
            Month_label.Visible = true;
            //comboBox
            Class_comboBox.Visible = true;
            Year_comboBox.Visible = true;
            Month_comboBox.Visible = true;
            //dataGridView
            Class_dataGridView.Visible = true;
            //checkbox
            class_checkbox.Visible = true;
        }
        void setClassShow()
        {
            Title_label.Text = "設定類別";
            sort_class.Visible = true;
            delete_class.Visible = true;
        }
        void setClassHide()
        {
            sort_class.Visible = false;
            delete_class.Visible = false;
        }
        void chartShow()
        {
            data_chart.Visible = true;
            Year_comboBox.Visible = true;
            Month_comboBox.Visible = true;
            Year_comboBox.Text = dt.Year.ToString();
            Month_comboBox.Text = dt.Month.ToString();
            Year_label.Visible = true;
            Month_label.Visible = true;
            Pie_radioButtom.Visible = true;
            Bar_radioButtom.Visible = true;
            Line_radioButtom.Visible = true;
            Histogram_radioButtom.Visible = true;
        }
        void chartHide()
        {
            data_chart.Visible = false;
            Year_comboBox.Visible = false;
            Month_comboBox.Visible = false;
            Year_label.Visible = false;
            Month_label.Visible = false;
            Pie_radioButtom.Visible = false;
            Bar_radioButtom.Visible = false;
            Line_radioButtom.Visible = false;
            Histogram_radioButtom.Visible = false;
        }
        void budgetShow()
        {
            budget_textbox.Visible = true;
            set_budget_buttom.Visible = true;
            current_month_budget.Visible = true;
            budgetSet_label.Visible = true;
            money1.Visible = true;
            money2.Visible = true;
            budget_progressBar.Visible = true;
        }
        void budgetHide()
        {
            budget_textbox.Visible = false;
            set_budget_buttom.Visible = false;
            current_month_budget.Visible = false;
            budgetSet_label.Visible = false;
            money1.Visible = false;
            money2.Visible = false;
            budget_progressBar.Visible = false;
        }

        public Form1()
        {
            InitializeComponent();
            ProgressBar_label.BackColor = Color.GhostWhite;
            DateTime dt = DateTime.Now;
            Time_label.Text = dt.ToLongDateString().ToString();
            //hide
            chartHide();
            budgetHide();
            Year_comboBox.Visible = true;
            Month_comboBox.Visible = true;
            Year_label.Visible = true;
            Month_label.Visible = true;
            SecondHide();
            class_checkbox.Visible = false;
            Class_dataGridView.Visible = false;
            Title_label.Visible = false;
            sort_class.Visible = false;
            delete_class.Visible = false;
            label_sort_exp1.Visible = false;
            label_sort_exp2.Visible = false;
            Sort_comboBox.Visible = false;
            //從資料庫中抓類別到combobox
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|track.mdf;Integrated Security=True";
            SqlDataAdapter daDep = new SqlDataAdapter("SELECT * FROM 記帳", cn);
            DataSet ds = new DataSet();
            daDep.Fill(ds, "記帳");
            depId = new int[ds.Tables["記帳"].Rows.Count];
            for (int i = 0; i < ds.Tables["記帳"].Rows.Count; i++)
            {
                //Class
                string newClassItem = ds.Tables["記帳"].Rows[i]["類別"].ToString();
                try
                {
                    foreach (string item in Class_comboBox.Items)
                    {
                        Class_comboBox.Items.Remove(newClassItem);
                    }
                }
                catch { }
                Class_comboBox.Items.Add(ds.Tables["記帳"].Rows[i]["類別"].ToString());
            }
            //介面調整隱藏
            font_label.Visible = false;
            color_label.Visible = false;
            example_label.Visible = false;
        }

        //layer = 1 ----------------------------------------
        private void Add_pictureBox_Click(object sender, EventArgs e)
        {
            temp_class = Class_comboBox.Text;
            temp_year = Year_comboBox.Text;
            temp_month = Month_comboBox.Text;
            if (Class_comboBox.Text == "" || Item_textBox.Text == "" || Price_textBox.Text == "")
            {
                DialogResult wrong_input;
                wrong_input = MessageBox.Show("資料輸入有缺失", "", MessageBoxButtons.OK);
                if (wrong_input == DialogResult.OK) { }
            }
            else
            {
                Perform_textBox.Text += Year_comboBox.Text + "-" + Month_comboBox.Text + "-" + Day_comboBox.Text + " " + Class_comboBox.Text + " " + Item_textBox.Text + " $" + Price_textBox.Text + " " + Else_textBox.Text + "\r\n";
            }
            //將資料輸入資料庫
            DBinsert();
            string newItem = Class_comboBox.Text;
            try
            {
                foreach (string item in Class_comboBox.Items)
                {
                    Class_comboBox.Items.Remove(newItem);
                }
            }
            catch { };
            Class_comboBox.Items.Add(newItem);
            Class_comboBox.Text = newItem;
        }

        private void Add_Item(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                string newItem = Class_comboBox.Text;
                Class_comboBox.Items.Add(newItem);
            }
        }

        private void Setting_pictureBox_Click(object sender, EventArgs e)
        {
            FirstHide();
            SecondShow();
        }

        //layer = 2 ----------------------------------------
        private void Back_btn_Click(object sender, EventArgs e)
        {
            if(layer == 4)
            {
                layer = 3;
                setClassShow();
                label_sort_exp1.Visible = false;
                label_sort_exp2.Visible = false;
                Sort_comboBox.Visible = false;
                int class_num = Class_comboBox.Items.Count;
                for (int i = 0; i < class_num; i++)
                {
                    if(b_delete_class == true)
                        b_list[i].Visible = false;
                    else if(b_sort_class == true)
                        rb_list[i].Visible = false;
                }
                b_delete_class = false;
                b_sort_class = false;
            }
            else if (layer == 3)
            {
                SecondShow();
                ClassHide();
                setClassHide();
                chartHide();
                budgetHide();
                statistic = false;
            }
            else if (layer == 2)
            {
                FirstShow();
                SecondHide();
            }
            Class_comboBox.Text = temp_class;
            Month_comboBox.Text = temp_month;
            Year_comboBox.Text = temp_year;
            Class_comboBox.Enabled = true;
            //介面調整
            font_label.Visible = false;
            color_label.Visible = false;
            example_label.Visible = false;
        }

        //layer = 3 ----------------------------------------

        //search
        private void Search_pictureBox_Click(object sender, EventArgs e)
        {
            ClassShow();
            //從資料庫中抓類別到combobox
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|track.mdf;Integrated Security=True";
            SqlDataAdapter daDep = new SqlDataAdapter("SELECT * FROM 記帳", cn);
            DataSet ds = new DataSet();
            daDep.Fill(ds, "記帳");
            depId = new int[ds.Tables["記帳"].Rows.Count];
            Class_comboBox.Text = (ds.Tables["記帳"].Rows[0]["類別"].ToString());
            Year_comboBox.Text = dt.Year.ToString();
            Month_comboBox.Text = dt.Month.ToString();
        }

        //statistic
        private void Statistic_pictureBox_Click(object sender, EventArgs e)
        {
            chartShow();
            layer = 3;
            statistic = true;
            Title_label.Text = "支出分析";
            SecondHide();
            Back_btn.Visible = true;
            DataSet ds = new DataSet();
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|track.mdf;Integrated Security=True");
            String find = "SELECT DISTINCT 類別 FROM 記帳 " + " WHERE 月 = " + "'" + Month_comboBox.Text + "'" + " AND 年 = " + "'" + Year_comboBox.Text + "'";
            SqlDataAdapter daEmp = new SqlDataAdapter(find, cn);
            daEmp.Fill(ds, "記帳");
            //抓取資料進List
            List<string> xData = new List<string>();
            List<int> yData = new List<int>();
            DataSet ds_sum = new DataSet();
            cn.Open();
            foreach (DataRow datarow in ds.Tables["記帳"].Rows)
            {
                xData.Add(datarow["類別"].ToString());
                find = "SELECT SUM(價格) FROM 記帳 " + " WHERE 類別 = " + "'" + datarow["類別"].ToString() + "'" + " AND 年 = " + "'" + Year_comboBox.Text + "'" + " AND 月 = " + "'" + Month_comboBox.Text + "'";
                SqlDataAdapter dAdapter = new SqlDataAdapter(find, cn);
                DataTable source = new DataTable();
                dAdapter.Fill(source);
                yData.Add(Convert.ToInt32(source.Rows[0][0]));
            }
            cn.Close();
            data_chart.Series[0]["PieLabelStyle"] = "Outside";//將文字移到外側 
            data_chart.Series[0]["PieLineColor"] = "Black";//繪製黑色的連線。
            data_chart.Series[0].Points.DataBindXY(xData, yData);
        }

        //budget
        private void Budget_pictureBox_Click(object sender, EventArgs e)
        {
            budgetShow();
            layer = 3;
            Title_label.Text = "顯示預算";
            SecondHide();
            DataSet ds = new DataSet();
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|track.mdf;Integrated Security=True");
            cn.Open();
            Back_btn.Visible = true;
            string find = "SELECT SUM(價格) FROM 記帳 " + " WHERE 月 = " + "'" + dt.Month.ToString() + "'" + " AND 年 = " + "'" + dt.Year.ToString() + "'"; ;
            SqlDataAdapter dAdapter = new SqlDataAdapter(find, cn);
            DataTable source = new DataTable();
            dAdapter.Fill(source);
            money1.Text = Convert.ToInt32(source.Rows[0][0]) + "$";
            mon1 = Convert.ToInt32(source.Rows[0][0]);
            cn.Close();
        }

        //classsetting
        private void ClassSetting_pictureBox_Click(object sender, EventArgs e)
        {
            layer = 3;
            Title_label.Text = "設定類別";
            SecondHide();
            Back_btn.Visible = true;
            setClassShow();
        }

        //cust
        private void Cust_pictureBox_Click(object sender, EventArgs e)
        {
            Title_label.Text = "介面調整";
            SecondHide();
            Back_btn.Visible = true;
            font_label.Visible = true;
            color_label.Visible = true;
            example_label.Visible = true;
            layer = 3;
        }

        //game
        private void Game_pictureBox_Click(object sender, EventArgs e)
        {
            game game_form = new game();
            //this.Visible = false;
            game_form.Visible = true;
        }

        private void Year_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //search
            if (Class_comboBox.Enabled == true)
            {
                DataSet ds = new DataSet();
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|track.mdf;Integrated Security=True");
                String find = "SELECT * FROM 記帳 WHERE 類別 = " + "'" + Class_comboBox.Text + "'" + " AND 月 = " + "'" + Month_comboBox.Text + "'" + " AND 年 = " + "'" + Year_comboBox.Text + "'";
                SqlDataAdapter daEmp = new SqlDataAdapter(find, cn);
                daEmp.Fill(ds, "記帳");
                Class_dataGridView.DataSource = ds.Tables["記帳"];
            }
            else
            {
                DataSet ds = new DataSet();
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|track.mdf;Integrated Security=True");
                String find = "SELECT * FROM 記帳 WHERE 年 = " + "'" + Year_comboBox.Text + "'" + " AND 月 = " + "'" + Month_comboBox.Text + "'";
                SqlDataAdapter daEmp = new SqlDataAdapter(find, cn);
                daEmp.Fill(ds, "記帳");
                Class_dataGridView.DataSource = ds.Tables["記帳"];
            }
            //statistic
            if (statistic == true)
            {
                DataSet ds = new DataSet();
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|track.mdf;Integrated Security=True");
                String find = "SELECT DISTINCT 類別 FROM 記帳 " + " WHERE 月 = " + "'" + Month_comboBox.Text + "'" + " AND 年 = " + "'" + Year_comboBox.Text + "'";
                SqlDataAdapter daEmp = new SqlDataAdapter(find, cn);
                daEmp.Fill(ds, "記帳");
                //抓取資料進List
                List<string> xData = new List<string>();
                List<int> yData = new List<int>();
                cn.Open();
                foreach (DataRow datarow in ds.Tables["記帳"].Rows)
                {
                    xData.Add(datarow["類別"].ToString());
                    find = "SELECT SUM(價格) FROM 記帳 " + " WHERE 類別 = " + "'" + datarow["類別"].ToString() + "'" + " AND 年 = " + "'" + Year_comboBox.Text + "'" + " AND 月 = " + "'" + Month_comboBox.Text + "'";
                    SqlDataAdapter dAdapter = new SqlDataAdapter(find, cn);
                    DataTable source = new DataTable();
                    dAdapter.Fill(source);
                    yData.Add(Convert.ToInt32(source.Rows[0][0]));
                }
                cn.Close();
                data_chart.Series[0]["PieLabelStyle"] = "Outside";//將文字移到外側 
                data_chart.Series[0]["PieLineColor"] = "Black";//繪製黑色的連線。
                data_chart.Series[0].Points.DataBindXY(xData, yData);
            }
        }

        private void Month_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_comboBox.Enabled == true)
            {
                DataSet ds = new DataSet();
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|track.mdf;Integrated Security=True");
                String find = "SELECT * FROM 記帳 WHERE 類別 = " + "'" + Class_comboBox.Text + "'" + " AND 月 = " + "'" + Month_comboBox.Text + "'" + " AND 年 = " + "'" + Year_comboBox.Text + "'";
                SqlDataAdapter daEmp = new SqlDataAdapter(find, cn);
                daEmp.Fill(ds, "記帳");
                Class_dataGridView.DataSource = ds.Tables["記帳"];
            }
            else
            {
                DataSet ds = new DataSet();
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|track.mdf;Integrated Security=True");
                String find = "SELECT * FROM 記帳 WHERE 年 = " + "'" + Year_comboBox.Text + "'" + " AND 月 = " + "'" + Month_comboBox.Text + "'";
                SqlDataAdapter daEmp = new SqlDataAdapter(find, cn);
                daEmp.Fill(ds, "記帳");
                Class_dataGridView.DataSource = ds.Tables["記帳"];
            }
            if (statistic == true)
            {
                DataSet ds = new DataSet();
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|track.mdf;Integrated Security=True");
                String find = "SELECT DISTINCT 類別 FROM 記帳 " + " WHERE 月 = " + "'" + Month_comboBox.Text + "'" + " AND 年 = " + "'" + Year_comboBox.Text + "'";
                SqlDataAdapter daEmp = new SqlDataAdapter(find, cn);
                daEmp.Fill(ds, "記帳");
                //抓取資料進List
                List<string> xData = new List<string>();
                List<int> yData = new List<int>();
                cn.Open();
                foreach (DataRow datarow in ds.Tables["記帳"].Rows)
                {
                    xData.Add(datarow["類別"].ToString());
                    find = "SELECT SUM(價格) FROM 記帳 " + " WHERE 類別 = " + "'" + datarow["類別"].ToString() + "'" + " AND 年 = " + "'" + Year_comboBox.Text + "'" + " AND 月 = " + "'" + Month_comboBox.Text + "'";
                    SqlDataAdapter dAdapter = new SqlDataAdapter(find, cn);
                    DataTable source = new DataTable();
                    dAdapter.Fill(source);
                    yData.Add(Convert.ToInt32(source.Rows[0][0]));
                }
                cn.Close();
                data_chart.Series[0]["PieLabelStyle"] = "Outside";//將文字移到外側 
                data_chart.Series[0]["PieLineColor"] = "Black";//繪製黑色的連線。
                data_chart.Series[0].Points.DataBindXY(xData, yData);
            }
        }

        private void Class_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|track.mdf;Integrated Security=True");
            String find = "SELECT * FROM 記帳 WHERE 類別 = " + "'" + Class_comboBox.Text + "'" + " AND 月 = " + "'" + Month_comboBox.Text + "'" + " AND 年 = " + "'" + Year_comboBox.Text + "'";
            SqlDataAdapter daEmp = new SqlDataAdapter(find, cn);
            daEmp.Fill(ds, "記帳");
            Class_dataGridView.DataSource = ds.Tables["記帳"];
        }

        private void class_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(class_checkbox.Checked == true)
            {
                Class_comboBox.Enabled = true;
                DataSet ds = new DataSet();
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|track.mdf;Integrated Security=True");
                String find = "SELECT * FROM 記帳 WHERE 類別 = " + "'" + Class_comboBox.Text + "'" + " AND 月 = " + "'" + Month_comboBox.Text + "'" + " AND 年 = " + "'" + Year_comboBox.Text + "'";
                SqlDataAdapter daEmp = new SqlDataAdapter(find, cn);
                daEmp.Fill(ds, "記帳");
                Class_dataGridView.DataSource = ds.Tables["記帳"];
            }
            else
            {
                Class_comboBox.Enabled = false;
                DataSet ds = new DataSet();
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|track.mdf;Integrated Security=True");
                String find = "SELECT * FROM 記帳 WHERE 年 = " + "'" + Year_comboBox.Text + "'" + " AND 月 = " + "'" + Month_comboBox.Text + "'";
                SqlDataAdapter daEmp = new SqlDataAdapter(find, cn);
                daEmp.Fill(ds, "記帳");
                Class_dataGridView.DataSource = ds.Tables["記帳"];
            }
        }

        private void font_label_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                example_label.Font = fontDialog1.Font;
                Perform_textBox.Font = fontDialog1.Font;
            }
        }

        private void color_label_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                example_label.ForeColor = colorDialog1.Color;
                Perform_textBox.ForeColor = colorDialog1.Color;
            }
        }

        private void delete_class_Click(object sender, EventArgs e)
        {
            b_delete_class = true;
            Title_label.Text = "刪除類別";
            layer = 4;
            setClassHide();
            //動作
            b_list.Clear();
            int class_num = Class_comboBox.Items.Count;
            for (int i = 0; i < class_num; i++)
            {
                Button button = new Button();
                b_list.Add(button);

                b_list[i].Text = Class_comboBox.Items[i].ToString();
                b_list[i].Location = new Point(260, 50 + i * 35);
                b_list[i].Size = new Size(100, 30);
                b_list[i].ForeColor = Color.Black;
                b_list[i].Font = new Font(b_list[i].Font.Name, 11);
                this.Controls.Add(b_list[i]);

                int index = i;
                b_list[i].Click += (s, args) => Delete_Click(index, class_num);
            }
        }
        private void Delete_Click(int tar_index, int class_num)
        {
            DialogResult result;
            result = MessageBox.Show("確定刪除類別「" + b_list[tar_index].Text.ToString() + "」？",
                                    "刪除類別", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Class_comboBox.Items.RemoveAt(tar_index);

                for (int i = 0; i < class_num; i++)
                {
                    this.Controls.Remove(b_list[i]);
                }
                b_list.Clear();
                class_num = Class_comboBox.Items.Count;

                for (int i = 0; i < class_num; i++)
                {
                    Button button = new Button();
                    b_list.Add(button);

                    b_list[i].Text = Class_comboBox.Items[i].ToString();
                    b_list[i].Location = new Point(260, 50 + i * 35);
                    b_list[i].Size = new Size(100, 30);
                    b_list[i].ForeColor = Color.Black;
                    b_list[i].Font = new Font(b_list[i].Font.Name, 11);
                    this.Controls.Add(b_list[i]);

                    int index = i;
                    b_list[i].Click += (s, args) => Delete_Click(index, class_num);
                }
            }
        }

        private void sort_class_Click(object sender, EventArgs e)
        {
            b_sort_class = true;
            Title_label.Text = "類別排序";
            layer = 4;
            setClassHide();
            label_sort_exp1.Visible = true;
            label_sort_exp2.Visible = true;
            Sort_comboBox.Visible = true;
            //動作
            rb_list.Clear();
            int class_num = Class_comboBox.Items.Count;
            Sort_comboBox.Items.Clear();
            for (int i = 0; i < class_num; i++)
            {
                Sort_comboBox.Items.Add(i + 1);
            }

            for (int i = 0; i < class_num; i++)
            {
                RadioButton radioButton = new RadioButton();
                rb_list.Add(radioButton);

                rb_list[i].Text = Class_comboBox.Items[i].ToString();
                rb_list[i].Location = new Point(260, 95 + i * 25);
                rb_list[i].Size = new Size(80, 30);
                rb_list[i].ForeColor = Color.Black;
                rb_list[i].Font = new Font(rb_list[i].Font.Name, 10);
                this.Controls.Add(rb_list[i]);

                int index = i;
                string text = rb_list[i].Text;
                rb_list[i].Click += (s, args) => Sort_Click(index, text, Sort_comboBox.Text, class_num);
            }
        }
        private void Sort_Click(int ori_index, string ori_text, string target_str, int class_num)
        {
            if (target_str == "")
            {
                DialogResult result;
                result = MessageBox.Show("請先選擇順序",
                                        "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                for (int i = 0; i < class_num; i++)
                {
                    rb_list[i].Checked = false;
                }
            }
            else
            {
                DialogResult result;
                result = MessageBox.Show("確定將類別「" + rb_list[ori_index].Text.ToString() + "」排至第" + target_str + "個？",
                                        "類別排序", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int target = Convert.ToInt32(target_str, 10);
                    Class_comboBox.Items.RemoveAt(ori_index);
                    Class_comboBox.Items.Insert(target - 1, ori_text);
                    Sort_comboBox.Text = "";

                    for (int i = 0; i < class_num; i++)
                    {
                        this.Controls.Remove(rb_list[i]);
                    }
                    rb_list.Clear();
                    for (int i = 0; i < class_num; i++)
                    {
                        RadioButton radioButton = new RadioButton();
                        rb_list.Add(radioButton);

                        rb_list[i].Text = Class_comboBox.Items[i].ToString();
                        rb_list[i].Location = new Point(260, 95 + i * 25);
                        rb_list[i].Size = new Size(80, 30);
                        rb_list[i].ForeColor = Color.Black;
                        rb_list[i].Font = new Font(rb_list[i].Font.Name, 10);
                        this.Controls.Add(rb_list[i]);

                        int index = i;
                        string text = rb_list[i].Text;
                        rb_list[i].Click += (s, args) => Sort_Click(index, text, Sort_comboBox.Text, class_num);
                    }
                }
                else
                {
                    for (int i = 0; i < class_num; i++)
                    {
                        rb_list[i].Checked = false;
                    }
                }
            }
        }

        private void Pie_radioButtom_CheckedChanged(object sender, EventArgs e)
        {
            data_chart.Series[0].ChartType = SeriesChartType.Pie;
        }

        private void Bar_radioButtom_CheckedChanged(object sender, EventArgs e)
        {
            data_chart.Series[0].ChartType = SeriesChartType.Bar;
        }

        private void Line_radioButtom_CheckedChanged(object sender, EventArgs e)
        {
            data_chart.Series[0].ChartType = SeriesChartType.Line;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            data_chart.Series[0].ChartType = SeriesChartType.Column;
        }

        private void set_budget_buttom_Click(object sender, EventArgs e)
        {
            budgetSet_label.Text += budget_textbox.Text + "$";
        }

        private void set_budget_buttom_Click_1(object sender, EventArgs e)
        {
            mon2 = Convert.ToInt32(budget_textbox.Text);
            if(budget_textbox.Text == "")
            {
                DialogResult wrong_input;
                wrong_input = MessageBox.Show("需填入數字!", "", MessageBoxButtons.OK);
                if (wrong_input == DialogResult.OK) { }
            }
            else
                money2.Text = budget_textbox.Text + "$";
            //progressBar
            budget_progressBar.Minimum = 0;
            budget_progressBar.Maximum = mon2;
            if(mon2 > mon1)
            {
                budget_progressBar.Value = mon2;
                for(int i = 0; i < mon2; i++)
                {
                    budget_progressBar.PerformStep();
                }
                budget_progressBar.Value = mon1;
                budget_progressBar.Step = (mon2 - mon1) / 100;
                Graphics g = budget_progressBar.CreateGraphics();
                //progressBar text
                ProgressBar_label.Text = money1.Text + "/" + money2.Text + "";
            }
            else if(mon1 > mon2)
            {
                try
                {
                    DialogResult wrong_input;
                    wrong_input = MessageBox.Show("預算爆表啦!!!", "", MessageBoxButtons.OK);
                    if (wrong_input == DialogResult.OK) { }
                }
                catch { };
            }
        }
    }
}
