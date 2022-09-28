namespace f74086381_practice8_2
{
    partial class Robot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_fileread = new System.Windows.Forms.TextBox();
            this.button_mode1 = new System.Windows.Forms.Button();
            this.button_mode2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.read_record = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_fileread
            // 
            this.textBox_fileread.Location = new System.Drawing.Point(13, 13);
            this.textBox_fileread.Multiline = true;
            this.textBox_fileread.Name = "textBox_fileread";
            this.textBox_fileread.Size = new System.Drawing.Size(526, 386);
            this.textBox_fileread.TabIndex = 0;
            // 
            // button_mode1
            // 
            this.button_mode1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_mode1.Location = new System.Drawing.Point(37, 414);
            this.button_mode1.Name = "button_mode1";
            this.button_mode1.Size = new System.Drawing.Size(470, 48);
            this.button_mode1.TabIndex = 1;
            this.button_mode1.Text = "模式一";
            this.button_mode1.UseVisualStyleBackColor = true;
            this.button_mode1.Click += new System.EventHandler(this.button_mode1_Click);
            // 
            // button_mode2
            // 
            this.button_mode2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_mode2.Location = new System.Drawing.Point(37, 475);
            this.button_mode2.Name = "button_mode2";
            this.button_mode2.Size = new System.Drawing.Size(470, 48);
            this.button_mode2.TabIndex = 2;
            this.button_mode2.Text = "模式二";
            this.button_mode2.UseVisualStyleBackColor = true;
            this.button_mode2.Click += new System.EventHandler(this.button_mode2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(574, 414);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(384, 48);
            this.progressBar1.TabIndex = 3;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(574, 475);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(384, 48);
            this.progressBar2.TabIndex = 4;
            // 
            // read_record
            // 
            this.read_record.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.read_record.Location = new System.Drawing.Point(586, 355);
            this.read_record.Name = "read_record";
            this.read_record.Size = new System.Drawing.Size(169, 31);
            this.read_record.TabIndex = 5;
            this.read_record.Text = "匯入聊天檔案";
            this.read_record.UseVisualStyleBackColor = true;
            this.read_record.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(965, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(965, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 7;
            // 
            // Robot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 535);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.read_record);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_mode2);
            this.Controls.Add(this.button_mode1);
            this.Controls.Add(this.textBox_fileread);
            this.Name = "Robot";
            this.Text = "機器人";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_fileread;
        private System.Windows.Forms.Button button_mode1;
        private System.Windows.Forms.Button button_mode2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button read_record;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}