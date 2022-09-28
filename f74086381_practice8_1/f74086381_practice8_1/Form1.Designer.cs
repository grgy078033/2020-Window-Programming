namespace f74086381_practice8_1
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
            this.components = new System.ComponentModel.Container();
            this.textBox_content = new System.Windows.Forms.TextBox();
            this.textBox_enter = new System.Windows.Forms.TextBox();
            this.button_enter = new System.Windows.Forms.Button();
            this.button_photo = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.功能列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟聊天機器人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束程式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字體ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顏色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_content
            // 
            this.textBox_content.Location = new System.Drawing.Point(26, 37);
            this.textBox_content.Multiline = true;
            this.textBox_content.Name = "textBox_content";
            this.textBox_content.Size = new System.Drawing.Size(451, 361);
            this.textBox_content.TabIndex = 0;
            // 
            // textBox_enter
            // 
            this.textBox_enter.Location = new System.Drawing.Point(12, 420);
            this.textBox_enter.Name = "textBox_enter";
            this.textBox_enter.Size = new System.Drawing.Size(490, 25);
            this.textBox_enter.TabIndex = 1;
            // 
            // button_enter
            // 
            this.button_enter.Location = new System.Drawing.Point(402, 451);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(89, 32);
            this.button_enter.TabIndex = 2;
            this.button_enter.Text = "送出";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // button_photo
            // 
            this.button_photo.Location = new System.Drawing.Point(665, 409);
            this.button_photo.Name = "button_photo";
            this.button_photo.Size = new System.Drawing.Size(107, 36);
            this.button_photo.TabIndex = 3;
            this.button_photo.Text = "上傳照片";
            this.button_photo.UseVisualStyleBackColor = true;
            this.button_photo.Click += new System.EventHandler(this.button_photo_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.time.Location = new System.Drawing.Point(512, 43);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 25);
            this.time.TabIndex = 4;
            this.time.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.功能列ToolStripMenuItem,
            this.設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 功能列ToolStripMenuItem
            // 
            this.功能列ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟聊天機器人ToolStripMenuItem,
            this.結束程式ToolStripMenuItem});
            this.功能列ToolStripMenuItem.Name = "功能列ToolStripMenuItem";
            this.功能列ToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.功能列ToolStripMenuItem.Text = "功能列";
            // 
            // 開啟聊天機器人ToolStripMenuItem
            // 
            this.開啟聊天機器人ToolStripMenuItem.Name = "開啟聊天機器人ToolStripMenuItem";
            this.開啟聊天機器人ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.開啟聊天機器人ToolStripMenuItem.Text = "開啟聊天機器人";
            this.開啟聊天機器人ToolStripMenuItem.Click += new System.EventHandler(this.開啟聊天機器人ToolStripMenuItem_Click);
            // 
            // 結束程式ToolStripMenuItem
            // 
            this.結束程式ToolStripMenuItem.Name = "結束程式ToolStripMenuItem";
            this.結束程式ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.結束程式ToolStripMenuItem.Text = "結束程式";
            this.結束程式ToolStripMenuItem.Click += new System.EventHandler(this.結束程式ToolStripMenuItem_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字體ToolStripMenuItem,
            this.顏色ToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // 字體ToolStripMenuItem
            // 
            this.字體ToolStripMenuItem.Name = "字體ToolStripMenuItem";
            this.字體ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.字體ToolStripMenuItem.Text = "字體";
            this.字體ToolStripMenuItem.Click += new System.EventHandler(this.字體ToolStripMenuItem_Click);
            // 
            // 顏色ToolStripMenuItem
            // 
            this.顏色ToolStripMenuItem.Name = "顏色ToolStripMenuItem";
            this.顏色ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.顏色ToolStripMenuItem.Text = "顏色";
            this.顏色ToolStripMenuItem.Click += new System.EventHandler(this.顏色ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(517, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 495);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.button_photo);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.textBox_enter);
            this.Controls.Add(this.textBox_content);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_content;
        private System.Windows.Forms.TextBox textBox_enter;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.Button button_photo;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 功能列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟聊天機器人ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束程式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字體ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 顏色ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

