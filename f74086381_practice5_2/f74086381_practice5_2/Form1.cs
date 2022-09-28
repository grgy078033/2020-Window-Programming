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
        public string left_type = "";
        public string right_type = "";
        public string radioButton_base = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void left_bytes_CheckedChanged(object sender, EventArgs e)
        {
            left_type = "bytes";
        }

        private void left_kibibytes_CheckedChanged(object sender, EventArgs e)
        {
            left_type = "kibibytes";
        }

        private void left_mebibytes_CheckedChanged(object sender, EventArgs e)
        {
            left_type = "mebibytes";
        }

        private void left_gibibytes_CheckedChanged(object sender, EventArgs e)
        {
            left_type = "gibibytes";
        }

        private void right_bytes_CheckedChanged(object sender, EventArgs e)
        {
            right_type = "bytes";
        }

        private void right_kibibytes_CheckedChanged(object sender, EventArgs e)
        {
            right_type = "kibibytes";
        }

        private void right_mebibytes_CheckedChanged(object sender, EventArgs e)
        {
            right_type = "mebibytes";
        }

        private void right_gibibytes_CheckedChanged(object sender, EventArgs e)
        {
            right_type = "gibibytes";
        }

        private void button_convert_bytes_Click(object sender, EventArgs e)
        {
            try
            {
                double enter_num = Convert.ToDouble(textBox_enter_bytes.Text);

                switch (left_type)
                {
                    case "bytes":
                        if (right_type == "bytes")
                        {
                            textBox_bytes_result.Text = Convert.ToString(enter_num);
                        }
                        else if (right_type == "kibibytes")
                        {
                            textBox_bytes_result.Text = Convert.ToString(enter_num / 1024);
                        }
                        else if (right_type == "mebibytes")
                        {
                            textBox_bytes_result.Text = Convert.ToString(enter_num / 1024 / 1024);
                        }
                        else if (right_type == "gibibytes")
                        {
                            textBox_bytes_result.Text = Convert.ToString(enter_num / 1024 / 1024 / 1024);
                        }
                        break;
                    case "kibibytes":
                        if (right_type == "bytes")
                        {
                            textBox_bytes_result.Text = Convert.ToString(enter_num * 1024);
                        }
                        else if (right_type == "kibibytes")
                        {
                            textBox_bytes_result.Text = Convert.ToString(enter_num);
                        }
                        else if (right_type == "mebibytes")
                        {
                            textBox_bytes_result.Text = Convert.ToString(enter_num / 1024);
                        }
                        else if (right_type == "gibibytes")
                        {
                            textBox_bytes_result.Text = Convert.ToString(enter_num / 1024 / 1024);
                        }
                        break;
                    case "mebibytes":
                        if (right_type == "bytes")
                        {
                            textBox_bytes_result.Text = Convert.ToString(enter_num * 1024 * 1024);
                        }
                        else if (right_type == "kibibytes")
                        {
                            textBox_bytes_result.Text = Convert.ToString(enter_num * 1024);
                        }
                        else if (right_type == "mebibytes")
                        {
                            textBox_bytes_result.Text = Convert.ToString(enter_num);
                        }
                        else if (right_type == "gibibytes")
                        {
                            textBox_bytes_result.Text = Convert.ToString(enter_num / 1024);
                        }
                        break;
                    case "gibibytes":
                        if (right_type == "bytes")
                        {
                            textBox_bytes_result.Text = Convert.ToString(enter_num * 1024 * 1024 * 1024);
                        }
                        else if (right_type == "kibibytes")
                        {
                            textBox_bytes_result.Text = Convert.ToString(enter_num * 1024 * 1024);
                        }
                        else if (right_type == "mebibytes")
                        {
                            textBox_bytes_result.Text = Convert.ToString(enter_num * 1024);
                        }
                        else if (right_type == "gibibytes")
                        {
                            textBox_bytes_result.Text = Convert.ToString(enter_num);
                        }
                        break;
                }
            }
            catch(FormatException)
            {
                if (textBox_enter_bytes.Text != "")
                {
                    DialogResult result;
                    result = MessageBox.Show("輸入格式有誤!", "錯誤", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        textBox_enter_bytes.Text = "";
                        textBox_bytes_result.Text = "";
                    }
                }
            }
        }

        private void radioButton_binary_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_base = "binary";
        }

        private void radioButton_octal_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_base = "octal";
        }

        private void radioButton_decimal_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_base = "decimal";
        }

        private void radioButton_hexadecimal_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_base = "hexadecimal";
        }

        private void button_convert_string_Click(object sender, EventArgs e)
        {
            result.Text = "";
            switch (radioButton_base)
            {
                case "binary":
                    bool binary_wrong = false;
                    foreach(char c in textBox_enter_string.Text)
                    {
                        if(Convert.ToInt32(c)-48 < 0 || Convert.ToInt32(c)-48 > 1) // 不是0、1
                        {
                            DialogResult error;
                            error = MessageBox.Show("來源不符合進位制規則", "錯誤", MessageBoxButtons.OK);
                            if (error == DialogResult.OK)
                            {
                                binary_wrong = true;
                                textBox_enter_string.Text = "";
                                result.Text = "";
                                break;
                            }
                        }
                    }

                    if (binary_wrong == false)
                    {
                        if (checkBox_binary.Checked == true) // to binary
                        {
                            result.Text += "二進位     = " + textBox_enter_string.Text + "\n";
                        }
                        if (checkBox_octal.Checked == true) // to octal
                        {
                            result.Text += "八進位     = " + Convert.ToString(Convert.ToInt32(textBox_enter_string.Text, 2), 8) + "\n";
                        }
                        if (checkBox_decimal.Checked == true) // to decimal
                        {
                            result.Text += "十進位     = " + Convert.ToInt32(textBox_enter_string.Text, 2) + "\n"; ;
                        }
                        if (checkBox_hexadecimal.Checked == true) // to hexadecimal
                        {
                            result.Text += "十六進位 = " + Convert.ToString(Convert.ToInt32(textBox_enter_string.Text, 2), 16).ToUpper() + "\n";
                        }
                    }
                    break;
                case "octal":
                    bool octal_wrong = false;
                    foreach (char c in textBox_enter_string.Text)
                    {
                        if (Convert.ToInt32(c) - 48 < 0 || Convert.ToInt32(c) - 48 > 7) // 不在0~7
                        {
                            DialogResult error;
                            error = MessageBox.Show("來源不符合進位制規則", "錯誤", MessageBoxButtons.OK);
                            if (error == DialogResult.OK)
                            {
                                octal_wrong = true;
                                textBox_enter_string.Text = "";
                                result.Text = "";
                                break;
                            }
                        }
                    }

                    if (octal_wrong == false)
                    {
                        if (checkBox_binary.Checked == true) // to binary
                        {
                            result.Text += "二進位     = " + Convert.ToString(Convert.ToInt32(textBox_enter_string.Text, 8), 2) + "\n";
                        }
                        if (checkBox_octal.Checked == true) // to octal
                        {
                            result.Text += "八進位     = " + textBox_enter_string.Text + "\n";
                        }
                        if (checkBox_decimal.Checked == true) // to decimal
                        {
                            result.Text += "十進位     = " + Convert.ToInt32(textBox_enter_string.Text, 8) + "\n";
                        }
                        if (checkBox_hexadecimal.Checked == true) // to hexadecimal
                        {
                            result.Text += "十六進位 = " + Convert.ToString(Convert.ToInt32(textBox_enter_string.Text, 8), 16).ToUpper() + "\n"; ;
                        }
                    }
                    break;
                case "decimal":
                    bool decimal_wrong = false;
                    foreach (char c in textBox_enter_string.Text)
                    {
                        if (Convert.ToInt32(c) - 48 < 0 || Convert.ToInt32(c) - 48 > 9) // 不在0~9
                        {
                            DialogResult error;
                            error = MessageBox.Show("來源不符合進位制規則", "錯誤", MessageBoxButtons.OK);
                            if (error == DialogResult.OK)
                            {
                                decimal_wrong = true;
                                textBox_enter_string.Text = "";
                                result.Text = "";
                                break;
                            }
                        }
                    }

                    if (decimal_wrong == false)
                    {
                        if (checkBox_binary.Checked == true) // to binary
                        {
                            result.Text += "二進位     = " + Convert.ToString(Convert.ToInt32(textBox_enter_string.Text), 2) + "\n";
                        }
                        if (checkBox_octal.Checked == true) // to octal
                        {
                            result.Text += "八進位     = " + Convert.ToString(Convert.ToInt32(textBox_enter_string.Text), 8) + "\n";
                        }
                        if (checkBox_decimal.Checked == true) // to decimal
                        {
                            result.Text += "十進位     = " + textBox_enter_string.Text + "\n";
                        }
                        if (checkBox_hexadecimal.Checked == true) // to hexadecimal
                        {
                            result.Text += "十六進位 = " + Convert.ToString(Convert.ToInt32(textBox_enter_string.Text), 16).ToUpper() + "\n";
                        }
                    }
                    break;
                case "hexadecimal":
                    bool hex_wrong = false;
                    foreach (char c in textBox_enter_string.Text)
                    {
                        if (Convert.ToInt32(c) - 48 < 0 || Convert.ToInt32(c) - 48 > 9) // 不在0~9
                        {
                            if(Convert.ToInt32(c) - 65 < 0 || Convert.ToInt32(c) - 65 > 5) // 不在A~F
                            {
                                if(Convert.ToInt32(c) - 97 < 0 || Convert.ToInt32(c) - 97 > 5) //不在a~f
                                {
                                    DialogResult error1;
                                    error1 = MessageBox.Show("來源不符合進位制規則", "錯誤", MessageBoxButtons.OK);
                                    if (error1 == DialogResult.OK)
                                    {
                                        hex_wrong = true;
                                        textBox_enter_string.Text = "";
                                        result.Text = "";
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    if (hex_wrong == false)
                    {
                        if (checkBox_binary.Checked == true) // to binary
                        {
                            result.Text += "二進位     = " + Convert.ToString(Convert.ToInt32(textBox_enter_string.Text, 16), 2) + "\n";
                        }
                        if (checkBox_octal.Checked == true) // to octal
                        {
                            result.Text += "八進位     = " + Convert.ToString(Convert.ToInt32(textBox_enter_string.Text, 16), 8) + "\n"; ;
                        }
                        if (checkBox_decimal.Checked == true) // to decimal
                        {
                            result.Text += "十進位     = " + Convert.ToInt32(textBox_enter_string.Text, 16) + "\n";
                        }
                        if (checkBox_hexadecimal.Checked == true) // to hexadecimal
                        {
                            result.Text += "十六進位 = " + textBox_enter_string.Text.ToUpper() + "\n";
                        }
                    }
                    break;
            }
        }
    }
}
