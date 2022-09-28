using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice4_1
{
    public partial class Form1 : Form
    {
        public const int Encode = 0; // 加密
        public const int Decode = 1; // 解密
        public const int Encode_Decode = 2; // 解密後再加密
        public const int MainMenu = 3; // 回到首頁
        public int status; // 表示現在功能

        public string record_string; // 歷史紀錄字串
        public Form1()
        {
            InitializeComponent();
            Encode_button.Visible = true; // 加密按紐
            Decode_button.Visible = true; // 解密按紐
            Encode_Decode_button.Visible = true; // 解密後再加密按紐
            record_button.Visible = true; // 歷史紀錄按紐
            OK_button.Visible = false; // OK按紐
            title_label.Visible = false; // 標題 Label

            string_label.Visible = false; // 加解密字串 Label
            shift_label.Visible = false; // 位移 Label
            string_textBox.Visible = false; // 加解密字串 textBox
            shift_textBox.Visible = false; // 位移 textBox


            /*在這裡加入還需要的Label、Textbox*/
            shift_for_decode_label.Visible = false;
            shift_for_decode_textBox.Visible = false;
            output_label.Visible = false;
            /**********************************/
        }

        private void Encode_button_Click(object sender, EventArgs e)
        {
            //按 加密按紐
            Encode_button.Visible = false;
            Decode_button.Visible = false;
            Encode_Decode_button.Visible = false;
            record_button.Visible = false;
            OK_button.Visible = true;
            title_label.Visible = true;
            title_label.Text = "加密";
            string_label.Visible = true;
            shift_label.Visible = true;
            string_textBox.Visible = true;
            shift_textBox.Visible = true;
            status = Encode;
        }

        private void Decode_button_Click(object sender, EventArgs e)
        {
            //按 解密按紐
            Encode_button.Visible = false;
            Decode_button.Visible = false;
            Encode_Decode_button.Visible = false;
            record_button.Visible = false;
            OK_button.Visible = true;
            title_label.Visible = true;
            title_label.Text = "解密";
            string_label.Visible = true;
            shift_for_decode_label.Visible = true;
            string_textBox.Visible = true;
            shift_for_decode_textBox.Visible = true;
            status = Decode;
        }

        private void Encode_Decode_button_Click(object sender, EventArgs e)
        {
            //按 解密後再加密按紐
            Encode_button.Visible = false;
            Decode_button.Visible = false;
            Encode_Decode_button.Visible = false;
            record_button.Visible = false;
            OK_button.Visible = true;
            title_label.Visible = true;
            title_label.Text = "解密後再加密";
            string_label.Visible = true;
            shift_for_decode_label.Visible = true;
            string_textBox.Visible = true;
            shift_for_decode_textBox.Visible = true;
            shift_label.Visible = true;
            shift_textBox.Visible = true;
            status = Encode_Decode;
        }

        private void record_button_Click(object sender, EventArgs e)
        {
            //按 歷史紀錄按紐
            Encode_button.Visible = false;
            Decode_button.Visible = false;
            Encode_Decode_button.Visible = false;
            record_button.Visible = false;
            title_label.Visible = true;
            title_label.Text = "歷史紀錄";
            OK_button.Visible = true;
            output_label.Text = record_string;
            output_label.Visible = true;
            status = MainMenu;
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case Encode:
                    //顯示加密後字串
                    string_label.Visible = false;
                    shift_label.Visible = false;
                    string_textBox.Visible = false;
                    shift_textBox.Visible = false;
                    status = MainMenu; // 更改狀態為 回到主頁面
                    output_label.Text = Ceasar_Encode_Cipher(string_textBox.Text, int.Parse(shift_textBox.Text));
                    record_string += "***加密***\r\n"; // 加入歷史紀錄
                    record_string += "原字串:" + string_textBox.Text + "\r\n";
                    record_string += "新字串:" + output_label.Text + "\r\n" + "******\r\n";
                    output_label.Text = "加密後為:" + Ceasar_Encode_Cipher(string_textBox.Text, int.Parse(shift_textBox.Text));
                    output_label.Visible = true;
                    break;
                case Decode:
                    //顯示解密後字串
                    string_label.Visible = false;
                    shift_for_decode_label.Visible = false;
                    string_textBox.Visible = false;
                    shift_for_decode_textBox.Visible = false;
                    status = MainMenu; // 更改狀態為 回到主頁面
                    output_label.Text = Ceasar_Decode_Cipher(string_textBox.Text, int.Parse(shift_for_decode_textBox.Text));
                    record_string += "***解密***\r\n"; // 加入歷史紀錄
                    record_string += "原字串:" + string_textBox.Text + "\r\n";
                    record_string += "新字串:" + output_label.Text + "\r\n" + "******\r\n";
                    output_label.Text = "解密後為:" + Ceasar_Decode_Cipher(string_textBox.Text, int.Parse(shift_for_decode_textBox.Text));
                    output_label.Visible = true;
                    break;
                case Encode_Decode:
                    //顯示解密後再加密字串
                    string_label.Visible = false;
                    shift_for_decode_label.Visible = false;
                    string_textBox.Visible = false;
                    shift_for_decode_textBox.Visible = false;
                    shift_label.Visible = false;
                    shift_textBox.Visible = false;
                    status = MainMenu;
                    output_label.Text = "解密後為:" + Ceasar_Decode_Cipher(string_textBox.Text, int.Parse(shift_for_decode_textBox.Text)) + "\r\n";
                    output_label.Text += "再加密後為:" + Ceasar_Encode_Cipher(Ceasar_Decode_Cipher(string_textBox.Text, int.Parse(shift_for_decode_textBox.Text)), int.Parse(shift_textBox.Text));
                    output_label.Visible = true;
                    record_string += "***解密後再加密***\r\n";
                    record_string += "原字串:" + string_textBox.Text + "\r\n";
                    record_string += "解密後:" + Ceasar_Decode_Cipher(string_textBox.Text, int.Parse(shift_for_decode_textBox.Text)) + "\r\n";
                    record_string += "新字串(再加密):" + Ceasar_Encode_Cipher(Ceasar_Decode_Cipher(string_textBox.Text, int.Parse(shift_for_decode_textBox.Text)), int.Parse(shift_textBox.Text)) + "\r\n" + "******\r\n";
                    break;
                case MainMenu:
                    //回到主頁面
                    string_textBox.Text = "";
                    shift_for_decode_textBox.Text = "";
                    shift_textBox.Text = "";
                    Encode_button.Visible = true;
                    Decode_button.Visible = true;
                    Encode_Decode_button.Visible = true;
                    record_button.Visible = true;
                    title_label.Visible = false;
                    OK_button.Visible = false;
                    output_label.Visible = false;
                    break;
            }
        }
        public string Ceasar_Encode_Cipher(string input, int shift) // 凱薩密碼加密 輸入字串與位移
        {
            int positive_shift; // shift 改為正數
            if (shift < 0)
                positive_shift = shift * (-1) % 26;
            else
                positive_shift = shift % 26;
            string output = ""; // 輸出字串
            /*這裡是凱薩密碼加密演算法*/
            for(int i = 0; i < input.Length; ++i)
            {
                if (input[i] == ' ') // 空格
                {
                    output += " ";
                    continue;
                }
                else if (input[i] <= 90) // 大寫
                {
                    if(input[i] + positive_shift > 90) // 超過Z
                    {
                        output += Convert.ToChar(input[i] + positive_shift - 90 + 64).ToString();
                    }
                    else
                    {
                        output += Convert.ToChar(input[i] + positive_shift).ToString();
                    }
                }
                else // 小寫
                {
                    if(input[i] + positive_shift > 122) // 超過z
                    {
                        output += Convert.ToChar(input[i] + positive_shift - 122 + 96).ToString();
                    }
                    else
                    {
                        output += Convert.ToChar(input[i] + positive_shift).ToString();
                    }
                }
            }
            /******************************/
            return output;
        }
        public string Ceasar_Decode_Cipher(string input, int shift) // 凱薩密碼加密 輸入字串與位移
        {
            int positive_shift; // shift 改為正數
            if (shift < 0)
                positive_shift = (shift * (-1)) % 26;
            else
                positive_shift = shift % 26;
            string output = ""; // 輸出字串
            /*這裡是凱薩密碼解密演算法*/
            for (int i = 0; i < input.Length; ++i)
            {
                if (input[i] == ' ') // 空格
                {
                    output += " ";
                    continue;
                }
                else if (input[i] <= 90) // 大寫
                {
                    if (input[i] - positive_shift < 65) // 超過A
                    {
                        output += Convert.ToChar(input[i] - positive_shift - 65 + 91).ToString();
                    }
                    else
                    {
                        output += Convert.ToChar(input[i] - positive_shift).ToString();
                    }
                }
                else // 小寫
                {
                    if (input[i] - positive_shift < 97) // 超過a
                    {
                        output += Convert.ToChar(input[i] - positive_shift - 97 + 123).ToString();
                    }
                    else
                    {
                        output += Convert.ToChar(input[i] - positive_shift).ToString();
                    }
                }
            }
            /******************************/
            return output;
        }
    }
}
