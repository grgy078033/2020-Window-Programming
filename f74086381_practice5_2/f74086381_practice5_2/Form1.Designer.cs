namespace f74086381_practice5_2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Page = new System.Windows.Forms.TabControl();
            this.Byte_convertion = new System.Windows.Forms.TabPage();
            this.textBox_bytes_result = new System.Windows.Forms.TextBox();
            this.button_convert_bytes = new System.Windows.Forms.Button();
            this.textBox_enter_bytes = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.right_bytes = new System.Windows.Forms.RadioButton();
            this.right_gibibytes = new System.Windows.Forms.RadioButton();
            this.right_kibibytes = new System.Windows.Forms.RadioButton();
            this.right_mebibytes = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.left_gibibytes = new System.Windows.Forms.RadioButton();
            this.left_mebibytes = new System.Windows.Forms.RadioButton();
            this.left_kibibytes = new System.Windows.Forms.RadioButton();
            this.left_bytes = new System.Windows.Forms.RadioButton();
            this.Base_convertion = new System.Windows.Forms.TabPage();
            this.checkBox_hexadecimal = new System.Windows.Forms.CheckBox();
            this.checkBox_decimal = new System.Windows.Forms.CheckBox();
            this.checkBox_octal = new System.Windows.Forms.CheckBox();
            this.checkBox_binary = new System.Windows.Forms.CheckBox();
            this.radioButton_hexadecimal = new System.Windows.Forms.RadioButton();
            this.radioButton_decimal = new System.Windows.Forms.RadioButton();
            this.radioButton_octal = new System.Windows.Forms.RadioButton();
            this.radioButton_binary = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_convert_string = new System.Windows.Forms.Button();
            this.textBox_enter_string = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.Page.SuspendLayout();
            this.Byte_convertion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Base_convertion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Page
            // 
            this.Page.Controls.Add(this.Byte_convertion);
            this.Page.Controls.Add(this.Base_convertion);
            this.Page.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Page.Location = new System.Drawing.Point(-3, -2);
            this.Page.Name = "Page";
            this.Page.SelectedIndex = 0;
            this.Page.Size = new System.Drawing.Size(587, 452);
            this.Page.TabIndex = 0;
            // 
            // Byte_convertion
            // 
            this.Byte_convertion.Controls.Add(this.textBox_bytes_result);
            this.Byte_convertion.Controls.Add(this.button_convert_bytes);
            this.Byte_convertion.Controls.Add(this.textBox_enter_bytes);
            this.Byte_convertion.Controls.Add(this.groupBox2);
            this.Byte_convertion.Controls.Add(this.groupBox1);
            this.Byte_convertion.Location = new System.Drawing.Point(4, 28);
            this.Byte_convertion.Name = "Byte_convertion";
            this.Byte_convertion.Padding = new System.Windows.Forms.Padding(3);
            this.Byte_convertion.Size = new System.Drawing.Size(579, 420);
            this.Byte_convertion.TabIndex = 0;
            this.Byte_convertion.Text = "資料單位轉換";
            this.Byte_convertion.UseVisualStyleBackColor = true;
            // 
            // textBox_bytes_result
            // 
            this.textBox_bytes_result.Enabled = false;
            this.textBox_bytes_result.Location = new System.Drawing.Point(328, 350);
            this.textBox_bytes_result.Name = "textBox_bytes_result";
            this.textBox_bytes_result.Size = new System.Drawing.Size(214, 27);
            this.textBox_bytes_result.TabIndex = 4;
            // 
            // button_convert_bytes
            // 
            this.button_convert_bytes.Location = new System.Drawing.Point(246, 350);
            this.button_convert_bytes.Name = "button_convert_bytes";
            this.button_convert_bytes.Size = new System.Drawing.Size(75, 27);
            this.button_convert_bytes.TabIndex = 3;
            this.button_convert_bytes.Text = "->";
            this.button_convert_bytes.UseVisualStyleBackColor = true;
            this.button_convert_bytes.Click += new System.EventHandler(this.button_convert_bytes_Click);
            // 
            // textBox_enter_bytes
            // 
            this.textBox_enter_bytes.Location = new System.Drawing.Point(38, 350);
            this.textBox_enter_bytes.Name = "textBox_enter_bytes";
            this.textBox_enter_bytes.Size = new System.Drawing.Size(202, 27);
            this.textBox_enter_bytes.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.right_bytes);
            this.groupBox2.Controls.Add(this.right_gibibytes);
            this.groupBox2.Controls.Add(this.right_kibibytes);
            this.groupBox2.Controls.Add(this.right_mebibytes);
            this.groupBox2.Location = new System.Drawing.Point(332, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "目標";
            // 
            // right_bytes
            // 
            this.right_bytes.AutoSize = true;
            this.right_bytes.Location = new System.Drawing.Point(20, 41);
            this.right_bytes.Name = "right_bytes";
            this.right_bytes.Size = new System.Drawing.Size(67, 23);
            this.right_bytes.TabIndex = 7;
            this.right_bytes.TabStop = true;
            this.right_bytes.Text = "Bytes";
            this.right_bytes.UseVisualStyleBackColor = true;
            this.right_bytes.CheckedChanged += new System.EventHandler(this.right_bytes_CheckedChanged);
            // 
            // right_gibibytes
            // 
            this.right_gibibytes.AutoSize = true;
            this.right_gibibytes.Location = new System.Drawing.Point(20, 180);
            this.right_gibibytes.Name = "right_gibibytes";
            this.right_gibibytes.Size = new System.Drawing.Size(95, 23);
            this.right_gibibytes.TabIndex = 4;
            this.right_gibibytes.TabStop = true;
            this.right_gibibytes.Text = "Gibibytes";
            this.right_gibibytes.UseVisualStyleBackColor = true;
            this.right_gibibytes.CheckedChanged += new System.EventHandler(this.right_gibibytes_CheckedChanged);
            // 
            // right_kibibytes
            // 
            this.right_kibibytes.AutoSize = true;
            this.right_kibibytes.Location = new System.Drawing.Point(20, 88);
            this.right_kibibytes.Name = "right_kibibytes";
            this.right_kibibytes.Size = new System.Drawing.Size(93, 23);
            this.right_kibibytes.TabIndex = 6;
            this.right_kibibytes.TabStop = true;
            this.right_kibibytes.Text = "Kibibytes";
            this.right_kibibytes.UseVisualStyleBackColor = true;
            this.right_kibibytes.CheckedChanged += new System.EventHandler(this.right_kibibytes_CheckedChanged);
            // 
            // right_mebibytes
            // 
            this.right_mebibytes.AutoSize = true;
            this.right_mebibytes.Location = new System.Drawing.Point(20, 133);
            this.right_mebibytes.Name = "right_mebibytes";
            this.right_mebibytes.Size = new System.Drawing.Size(102, 23);
            this.right_mebibytes.TabIndex = 5;
            this.right_mebibytes.TabStop = true;
            this.right_mebibytes.Text = "Mebibytes";
            this.right_mebibytes.UseVisualStyleBackColor = true;
            this.right_mebibytes.CheckedChanged += new System.EventHandler(this.right_mebibytes_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.left_gibibytes);
            this.groupBox1.Controls.Add(this.left_mebibytes);
            this.groupBox1.Controls.Add(this.left_kibibytes);
            this.groupBox1.Controls.Add(this.left_bytes);
            this.groupBox1.Location = new System.Drawing.Point(38, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "來源";
            // 
            // left_gibibytes
            // 
            this.left_gibibytes.AutoSize = true;
            this.left_gibibytes.Location = new System.Drawing.Point(19, 180);
            this.left_gibibytes.Name = "left_gibibytes";
            this.left_gibibytes.Size = new System.Drawing.Size(95, 23);
            this.left_gibibytes.TabIndex = 3;
            this.left_gibibytes.TabStop = true;
            this.left_gibibytes.Text = "Gibibytes";
            this.left_gibibytes.UseVisualStyleBackColor = true;
            this.left_gibibytes.CheckedChanged += new System.EventHandler(this.left_gibibytes_CheckedChanged);
            // 
            // left_mebibytes
            // 
            this.left_mebibytes.AutoSize = true;
            this.left_mebibytes.Location = new System.Drawing.Point(19, 133);
            this.left_mebibytes.Name = "left_mebibytes";
            this.left_mebibytes.Size = new System.Drawing.Size(102, 23);
            this.left_mebibytes.TabIndex = 2;
            this.left_mebibytes.TabStop = true;
            this.left_mebibytes.Text = "Mebibytes";
            this.left_mebibytes.UseVisualStyleBackColor = true;
            this.left_mebibytes.CheckedChanged += new System.EventHandler(this.left_mebibytes_CheckedChanged);
            // 
            // left_kibibytes
            // 
            this.left_kibibytes.AutoSize = true;
            this.left_kibibytes.Location = new System.Drawing.Point(19, 88);
            this.left_kibibytes.Name = "left_kibibytes";
            this.left_kibibytes.Size = new System.Drawing.Size(93, 23);
            this.left_kibibytes.TabIndex = 1;
            this.left_kibibytes.TabStop = true;
            this.left_kibibytes.Text = "Kibibytes";
            this.left_kibibytes.UseVisualStyleBackColor = true;
            this.left_kibibytes.CheckedChanged += new System.EventHandler(this.left_kibibytes_CheckedChanged);
            // 
            // left_bytes
            // 
            this.left_bytes.AutoSize = true;
            this.left_bytes.Location = new System.Drawing.Point(19, 41);
            this.left_bytes.Name = "left_bytes";
            this.left_bytes.Size = new System.Drawing.Size(67, 23);
            this.left_bytes.TabIndex = 0;
            this.left_bytes.TabStop = true;
            this.left_bytes.Text = "Bytes";
            this.left_bytes.UseVisualStyleBackColor = true;
            this.left_bytes.CheckedChanged += new System.EventHandler(this.left_bytes_CheckedChanged);
            // 
            // Base_convertion
            // 
            this.Base_convertion.Controls.Add(this.result);
            this.Base_convertion.Controls.Add(this.checkBox_hexadecimal);
            this.Base_convertion.Controls.Add(this.checkBox_decimal);
            this.Base_convertion.Controls.Add(this.checkBox_octal);
            this.Base_convertion.Controls.Add(this.checkBox_binary);
            this.Base_convertion.Controls.Add(this.radioButton_hexadecimal);
            this.Base_convertion.Controls.Add(this.radioButton_decimal);
            this.Base_convertion.Controls.Add(this.radioButton_octal);
            this.Base_convertion.Controls.Add(this.radioButton_binary);
            this.Base_convertion.Controls.Add(this.label2);
            this.Base_convertion.Controls.Add(this.label1);
            this.Base_convertion.Controls.Add(this.button_convert_string);
            this.Base_convertion.Controls.Add(this.textBox_enter_string);
            this.Base_convertion.Location = new System.Drawing.Point(4, 28);
            this.Base_convertion.Name = "Base_convertion";
            this.Base_convertion.Padding = new System.Windows.Forms.Padding(3);
            this.Base_convertion.Size = new System.Drawing.Size(579, 420);
            this.Base_convertion.TabIndex = 1;
            this.Base_convertion.Text = "進位制轉換";
            this.Base_convertion.UseVisualStyleBackColor = true;
            // 
            // checkBox_hexadecimal
            // 
            this.checkBox_hexadecimal.AutoSize = true;
            this.checkBox_hexadecimal.Location = new System.Drawing.Point(444, 140);
            this.checkBox_hexadecimal.Name = "checkBox_hexadecimal";
            this.checkBox_hexadecimal.Size = new System.Drawing.Size(91, 23);
            this.checkBox_hexadecimal.TabIndex = 11;
            this.checkBox_hexadecimal.Text = "十六進位";
            this.checkBox_hexadecimal.UseVisualStyleBackColor = true;
            // 
            // checkBox_decimal
            // 
            this.checkBox_decimal.AutoSize = true;
            this.checkBox_decimal.Location = new System.Drawing.Point(327, 140);
            this.checkBox_decimal.Name = "checkBox_decimal";
            this.checkBox_decimal.Size = new System.Drawing.Size(76, 23);
            this.checkBox_decimal.TabIndex = 10;
            this.checkBox_decimal.Text = "十進位";
            this.checkBox_decimal.UseVisualStyleBackColor = true;
            // 
            // checkBox_octal
            // 
            this.checkBox_octal.AutoSize = true;
            this.checkBox_octal.Location = new System.Drawing.Point(212, 140);
            this.checkBox_octal.Name = "checkBox_octal";
            this.checkBox_octal.Size = new System.Drawing.Size(76, 23);
            this.checkBox_octal.TabIndex = 9;
            this.checkBox_octal.Text = "八進位";
            this.checkBox_octal.UseVisualStyleBackColor = true;
            // 
            // checkBox_binary
            // 
            this.checkBox_binary.AutoSize = true;
            this.checkBox_binary.Location = new System.Drawing.Point(102, 140);
            this.checkBox_binary.Name = "checkBox_binary";
            this.checkBox_binary.Size = new System.Drawing.Size(76, 23);
            this.checkBox_binary.TabIndex = 8;
            this.checkBox_binary.Text = "二進位";
            this.checkBox_binary.UseVisualStyleBackColor = true;
            // 
            // radioButton_hexadecimal
            // 
            this.radioButton_hexadecimal.AutoSize = true;
            this.radioButton_hexadecimal.Location = new System.Drawing.Point(445, 86);
            this.radioButton_hexadecimal.Name = "radioButton_hexadecimal";
            this.radioButton_hexadecimal.Size = new System.Drawing.Size(90, 23);
            this.radioButton_hexadecimal.TabIndex = 7;
            this.radioButton_hexadecimal.TabStop = true;
            this.radioButton_hexadecimal.Text = "十六進位";
            this.radioButton_hexadecimal.UseVisualStyleBackColor = true;
            this.radioButton_hexadecimal.CheckedChanged += new System.EventHandler(this.radioButton_hexadecimal_CheckedChanged);
            // 
            // radioButton_decimal
            // 
            this.radioButton_decimal.AutoSize = true;
            this.radioButton_decimal.Location = new System.Drawing.Point(327, 86);
            this.radioButton_decimal.Name = "radioButton_decimal";
            this.radioButton_decimal.Size = new System.Drawing.Size(75, 23);
            this.radioButton_decimal.TabIndex = 6;
            this.radioButton_decimal.TabStop = true;
            this.radioButton_decimal.Text = "十進位";
            this.radioButton_decimal.UseVisualStyleBackColor = true;
            this.radioButton_decimal.CheckedChanged += new System.EventHandler(this.radioButton_decimal_CheckedChanged);
            // 
            // radioButton_octal
            // 
            this.radioButton_octal.AutoSize = true;
            this.radioButton_octal.Location = new System.Drawing.Point(212, 86);
            this.radioButton_octal.Name = "radioButton_octal";
            this.radioButton_octal.Size = new System.Drawing.Size(75, 23);
            this.radioButton_octal.TabIndex = 5;
            this.radioButton_octal.TabStop = true;
            this.radioButton_octal.Text = "八進位";
            this.radioButton_octal.UseVisualStyleBackColor = true;
            this.radioButton_octal.CheckedChanged += new System.EventHandler(this.radioButton_octal_CheckedChanged);
            // 
            // radioButton_binary
            // 
            this.radioButton_binary.AutoSize = true;
            this.radioButton_binary.Location = new System.Drawing.Point(102, 86);
            this.radioButton_binary.Name = "radioButton_binary";
            this.radioButton_binary.Size = new System.Drawing.Size(75, 23);
            this.radioButton_binary.TabIndex = 4;
            this.radioButton_binary.TabStop = true;
            this.radioButton_binary.Text = "二進位";
            this.radioButton_binary.UseVisualStyleBackColor = true;
            this.radioButton_binary.CheckedChanged += new System.EventHandler(this.radioButton_binary_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "目標";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "來源";
            // 
            // button_convert_string
            // 
            this.button_convert_string.Location = new System.Drawing.Point(433, 35);
            this.button_convert_string.Name = "button_convert_string";
            this.button_convert_string.Size = new System.Drawing.Size(112, 27);
            this.button_convert_string.TabIndex = 1;
            this.button_convert_string.Text = "convert";
            this.button_convert_string.UseVisualStyleBackColor = true;
            this.button_convert_string.Click += new System.EventHandler(this.button_convert_string_Click);
            // 
            // textBox_enter_string
            // 
            this.textBox_enter_string.Location = new System.Drawing.Point(102, 35);
            this.textBox_enter_string.Name = "textBox_enter_string";
            this.textBox_enter_string.Size = new System.Drawing.Size(280, 27);
            this.textBox_enter_string.TabIndex = 0;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.result.Location = new System.Drawing.Point(98, 201);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 25);
            this.result.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 444);
            this.Controls.Add(this.Page);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Page.ResumeLayout(false);
            this.Byte_convertion.ResumeLayout(false);
            this.Byte_convertion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Base_convertion.ResumeLayout(false);
            this.Base_convertion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Page;
        private System.Windows.Forms.TabPage Byte_convertion;
        private System.Windows.Forms.TabPage Base_convertion;
        private System.Windows.Forms.TextBox textBox_enter_string;
        private System.Windows.Forms.TextBox textBox_bytes_result;
        private System.Windows.Forms.Button button_convert_bytes;
        private System.Windows.Forms.TextBox textBox_enter_bytes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_convert_string;
        private System.Windows.Forms.RadioButton right_bytes;
        private System.Windows.Forms.RadioButton right_gibibytes;
        private System.Windows.Forms.RadioButton right_kibibytes;
        private System.Windows.Forms.RadioButton right_mebibytes;
        private System.Windows.Forms.RadioButton left_gibibytes;
        private System.Windows.Forms.RadioButton left_mebibytes;
        private System.Windows.Forms.RadioButton left_kibibytes;
        private System.Windows.Forms.RadioButton left_bytes;
        private System.Windows.Forms.CheckBox checkBox_hexadecimal;
        private System.Windows.Forms.CheckBox checkBox_decimal;
        private System.Windows.Forms.CheckBox checkBox_octal;
        private System.Windows.Forms.CheckBox checkBox_binary;
        private System.Windows.Forms.RadioButton radioButton_hexadecimal;
        private System.Windows.Forms.RadioButton radioButton_decimal;
        private System.Windows.Forms.RadioButton radioButton_octal;
        private System.Windows.Forms.RadioButton radioButton_binary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result;
    }
}

