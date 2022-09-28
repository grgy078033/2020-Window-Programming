namespace practice4_1
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
            this.Encode_button = new System.Windows.Forms.Button();
            this.Decode_button = new System.Windows.Forms.Button();
            this.Encode_Decode_button = new System.Windows.Forms.Button();
            this.record_button = new System.Windows.Forms.Button();
            this.OK_button = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.string_label = new System.Windows.Forms.Label();
            this.shift_label = new System.Windows.Forms.Label();
            this.string_textBox = new System.Windows.Forms.TextBox();
            this.shift_textBox = new System.Windows.Forms.TextBox();
            this.shift_for_decode_label = new System.Windows.Forms.Label();
            this.shift_for_decode_textBox = new System.Windows.Forms.TextBox();
            this.output_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Encode_button
            // 
            this.Encode_button.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.Encode_button.Location = new System.Drawing.Point(474, 99);
            this.Encode_button.Name = "Encode_button";
            this.Encode_button.Size = new System.Drawing.Size(265, 63);
            this.Encode_button.TabIndex = 0;
            this.Encode_button.Text = "加密";
            this.Encode_button.UseVisualStyleBackColor = true;
            this.Encode_button.Click += new System.EventHandler(this.Encode_button_Click);
            // 
            // Decode_button
            // 
            this.Decode_button.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.Decode_button.Location = new System.Drawing.Point(474, 179);
            this.Decode_button.Name = "Decode_button";
            this.Decode_button.Size = new System.Drawing.Size(265, 63);
            this.Decode_button.TabIndex = 1;
            this.Decode_button.Text = "解密";
            this.Decode_button.UseVisualStyleBackColor = true;
            this.Decode_button.Click += new System.EventHandler(this.Decode_button_Click);
            // 
            // Encode_Decode_button
            // 
            this.Encode_Decode_button.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.Encode_Decode_button.Location = new System.Drawing.Point(474, 262);
            this.Encode_Decode_button.Name = "Encode_Decode_button";
            this.Encode_Decode_button.Size = new System.Drawing.Size(265, 63);
            this.Encode_Decode_button.TabIndex = 2;
            this.Encode_Decode_button.Text = "解密後再加密";
            this.Encode_Decode_button.UseVisualStyleBackColor = true;
            this.Encode_Decode_button.Click += new System.EventHandler(this.Encode_Decode_button_Click);
            // 
            // record_button
            // 
            this.record_button.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.record_button.Location = new System.Drawing.Point(474, 346);
            this.record_button.Name = "record_button";
            this.record_button.Size = new System.Drawing.Size(265, 63);
            this.record_button.TabIndex = 3;
            this.record_button.Text = "歷史紀錄";
            this.record_button.UseVisualStyleBackColor = true;
            this.record_button.Click += new System.EventHandler(this.record_button_Click);
            // 
            // OK_button
            // 
            this.OK_button.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.OK_button.Location = new System.Drawing.Point(28, 346);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(265, 63);
            this.OK_button.TabIndex = 4;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title_label.Location = new System.Drawing.Point(21, 18);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(77, 38);
            this.title_label.TabIndex = 5;
            this.title_label.Text = "標題";
            // 
            // string_label
            // 
            this.string_label.AutoSize = true;
            this.string_label.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.string_label.Location = new System.Drawing.Point(21, 99);
            this.string_label.Name = "string_label";
            this.string_label.Size = new System.Drawing.Size(187, 38);
            this.string_label.TabIndex = 6;
            this.string_label.Text = "加(解)密字串";
            // 
            // shift_label
            // 
            this.shift_label.AutoSize = true;
            this.shift_label.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.shift_label.Location = new System.Drawing.Point(21, 262);
            this.shift_label.Name = "shift_label";
            this.shift_label.Size = new System.Drawing.Size(77, 38);
            this.shift_label.TabIndex = 7;
            this.shift_label.Text = "位移";
            // 
            // string_textBox
            // 
            this.string_textBox.Location = new System.Drawing.Point(254, 99);
            this.string_textBox.Name = "string_textBox";
            this.string_textBox.Size = new System.Drawing.Size(214, 25);
            this.string_textBox.TabIndex = 8;
            // 
            // shift_textBox
            // 
            this.shift_textBox.Location = new System.Drawing.Point(254, 262);
            this.shift_textBox.Name = "shift_textBox";
            this.shift_textBox.Size = new System.Drawing.Size(214, 25);
            this.shift_textBox.TabIndex = 10;
            // 
            // shift_for_decode_label
            // 
            this.shift_for_decode_label.AutoSize = true;
            this.shift_for_decode_label.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.shift_for_decode_label.Location = new System.Drawing.Point(21, 179);
            this.shift_for_decode_label.Name = "shift_for_decode_label";
            this.shift_for_decode_label.Size = new System.Drawing.Size(137, 38);
            this.shift_for_decode_label.TabIndex = 10;
            this.shift_for_decode_label.Text = "解密位移";
            // 
            // shift_for_decode_textBox
            // 
            this.shift_for_decode_textBox.Location = new System.Drawing.Point(254, 179);
            this.shift_for_decode_textBox.Name = "shift_for_decode_textBox";
            this.shift_for_decode_textBox.Size = new System.Drawing.Size(214, 25);
            this.shift_for_decode_textBox.TabIndex = 9;
            // 
            // output_label
            // 
            this.output_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.output_label.Location = new System.Drawing.Point(28, 60);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(440, 283);
            this.output_label.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shift_for_decode_textBox);
            this.Controls.Add(this.shift_for_decode_label);
            this.Controls.Add(this.shift_textBox);
            this.Controls.Add(this.string_textBox);
            this.Controls.Add(this.shift_label);
            this.Controls.Add(this.string_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.record_button);
            this.Controls.Add(this.Encode_Decode_button);
            this.Controls.Add(this.Decode_button);
            this.Controls.Add(this.Encode_button);
            this.Controls.Add(this.output_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Encode_button;
        private System.Windows.Forms.Button Decode_button;
        private System.Windows.Forms.Button Encode_Decode_button;
        private System.Windows.Forms.Button record_button;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label string_label;
        private System.Windows.Forms.Label shift_label;
        private System.Windows.Forms.TextBox string_textBox;
        private System.Windows.Forms.TextBox shift_textBox;
        private System.Windows.Forms.Label shift_for_decode_label;
        private System.Windows.Forms.TextBox shift_for_decode_textBox;
        private System.Windows.Forms.Label output_label;
    }
}

