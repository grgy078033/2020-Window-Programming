namespace f74086381_practice6_2
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
            this.choose = new System.Windows.Forms.Label();
            this.choose_warrior = new System.Windows.Forms.Button();
            this.choose_tank = new System.Windows.Forms.Button();
            this.choose_ranger = new System.Windows.Forms.Button();
            this.turn = new System.Windows.Forms.Label();
            this.player_name = new System.Windows.Forms.Label();
            this.monster_name = new System.Windows.Forms.Label();
            this.player_HP = new System.Windows.Forms.Label();
            this.monster_HP = new System.Windows.Forms.Label();
            this.player_MP = new System.Windows.Forms.Label();
            this.monster_MP = new System.Windows.Forms.Label();
            this.player_ATK = new System.Windows.Forms.Label();
            this.monster_ATK = new System.Windows.Forms.Label();
            this.button_attack = new System.Windows.Forms.Button();
            this.button_skill = new System.Windows.Forms.Button();
            this.button_continue = new System.Windows.Forms.Button();
            this.messege = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // choose
            // 
            this.choose.AutoSize = true;
            this.choose.Location = new System.Drawing.Point(25, 26);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(67, 15);
            this.choose.TabIndex = 0;
            this.choose.Text = "選擇職業";
            // 
            // choose_warrior
            // 
            this.choose_warrior.Location = new System.Drawing.Point(117, 22);
            this.choose_warrior.Name = "choose_warrior";
            this.choose_warrior.Size = new System.Drawing.Size(87, 29);
            this.choose_warrior.TabIndex = 1;
            this.choose_warrior.Text = "戰士";
            this.choose_warrior.UseVisualStyleBackColor = true;
            this.choose_warrior.Click += new System.EventHandler(this.Warrior_Click);
            // 
            // choose_tank
            // 
            this.choose_tank.Location = new System.Drawing.Point(230, 22);
            this.choose_tank.Name = "choose_tank";
            this.choose_tank.Size = new System.Drawing.Size(87, 29);
            this.choose_tank.TabIndex = 2;
            this.choose_tank.Text = "坦克";
            this.choose_tank.UseVisualStyleBackColor = true;
            this.choose_tank.Click += new System.EventHandler(this.choose_tank_Click);
            // 
            // choose_ranger
            // 
            this.choose_ranger.Location = new System.Drawing.Point(343, 22);
            this.choose_ranger.Name = "choose_ranger";
            this.choose_ranger.Size = new System.Drawing.Size(87, 29);
            this.choose_ranger.TabIndex = 3;
            this.choose_ranger.Text = "遊俠";
            this.choose_ranger.UseVisualStyleBackColor = true;
            this.choose_ranger.Click += new System.EventHandler(this.choose_ranger_Click);
            // 
            // turn
            // 
            this.turn.AutoSize = true;
            this.turn.Location = new System.Drawing.Point(787, 22);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(41, 15);
            this.turn.TabIndex = 4;
            this.turn.Text = "關卡:";
            // 
            // player_name
            // 
            this.player_name.AutoSize = true;
            this.player_name.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.player_name.Location = new System.Drawing.Point(23, 95);
            this.player_name.Name = "player_name";
            this.player_name.Size = new System.Drawing.Size(0, 34);
            this.player_name.TabIndex = 7;
            // 
            // monster_name
            // 
            this.monster_name.AutoSize = true;
            this.monster_name.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.monster_name.Location = new System.Drawing.Point(767, 95);
            this.monster_name.Name = "monster_name";
            this.monster_name.Size = new System.Drawing.Size(83, 34);
            this.monster_name.TabIndex = 8;
            this.monster_name.Text = "魔物";
            // 
            // player_HP
            // 
            this.player_HP.AutoSize = true;
            this.player_HP.Location = new System.Drawing.Point(28, 153);
            this.player_HP.Name = "player_HP";
            this.player_HP.Size = new System.Drawing.Size(0, 15);
            this.player_HP.TabIndex = 9;
            // 
            // monster_HP
            // 
            this.monster_HP.AutoSize = true;
            this.monster_HP.Location = new System.Drawing.Point(772, 153);
            this.monster_HP.Name = "monster_HP";
            this.monster_HP.Size = new System.Drawing.Size(0, 15);
            this.monster_HP.TabIndex = 10;
            // 
            // player_MP
            // 
            this.player_MP.AutoSize = true;
            this.player_MP.Location = new System.Drawing.Point(28, 194);
            this.player_MP.Name = "player_MP";
            this.player_MP.Size = new System.Drawing.Size(0, 15);
            this.player_MP.TabIndex = 11;
            // 
            // monster_MP
            // 
            this.monster_MP.AutoSize = true;
            this.monster_MP.Location = new System.Drawing.Point(772, 194);
            this.monster_MP.Name = "monster_MP";
            this.monster_MP.Size = new System.Drawing.Size(0, 15);
            this.monster_MP.TabIndex = 12;
            // 
            // player_ATK
            // 
            this.player_ATK.AutoSize = true;
            this.player_ATK.Location = new System.Drawing.Point(28, 233);
            this.player_ATK.Name = "player_ATK";
            this.player_ATK.Size = new System.Drawing.Size(0, 15);
            this.player_ATK.TabIndex = 13;
            // 
            // monster_ATK
            // 
            this.monster_ATK.AutoSize = true;
            this.monster_ATK.Location = new System.Drawing.Point(772, 233);
            this.monster_ATK.Name = "monster_ATK";
            this.monster_ATK.Size = new System.Drawing.Size(0, 15);
            this.monster_ATK.TabIndex = 14;
            // 
            // button_attack
            // 
            this.button_attack.Location = new System.Drawing.Point(29, 287);
            this.button_attack.Name = "button_attack";
            this.button_attack.Size = new System.Drawing.Size(137, 53);
            this.button_attack.TabIndex = 15;
            this.button_attack.Text = "攻擊";
            this.button_attack.UseVisualStyleBackColor = true;
            this.button_attack.Click += new System.EventHandler(this.button_attack_Click);
            // 
            // button_skill
            // 
            this.button_skill.Location = new System.Drawing.Point(28, 373);
            this.button_skill.Name = "button_skill";
            this.button_skill.Size = new System.Drawing.Size(137, 53);
            this.button_skill.TabIndex = 16;
            this.button_skill.Text = "技能";
            this.button_skill.UseVisualStyleBackColor = true;
            this.button_skill.Click += new System.EventHandler(this.button_skill_Click);
            // 
            // button_continue
            // 
            this.button_continue.Enabled = false;
            this.button_continue.Location = new System.Drawing.Point(773, 428);
            this.button_continue.Name = "button_continue";
            this.button_continue.Size = new System.Drawing.Size(137, 53);
            this.button_continue.TabIndex = 17;
            this.button_continue.Text = "繼續";
            this.button_continue.UseVisualStyleBackColor = true;
            this.button_continue.Click += new System.EventHandler(this.button_continue_Click);
            // 
            // messege
            // 
            this.messege.Location = new System.Drawing.Point(204, 64);
            this.messege.Multiline = true;
            this.messege.Name = "messege";
            this.messege.Size = new System.Drawing.Size(487, 426);
            this.messege.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 502);
            this.Controls.Add(this.messege);
            this.Controls.Add(this.button_continue);
            this.Controls.Add(this.button_skill);
            this.Controls.Add(this.button_attack);
            this.Controls.Add(this.monster_ATK);
            this.Controls.Add(this.player_ATK);
            this.Controls.Add(this.monster_MP);
            this.Controls.Add(this.player_MP);
            this.Controls.Add(this.monster_HP);
            this.Controls.Add(this.player_HP);
            this.Controls.Add(this.monster_name);
            this.Controls.Add(this.player_name);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.choose_ranger);
            this.Controls.Add(this.choose_tank);
            this.Controls.Add(this.choose_warrior);
            this.Controls.Add(this.choose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choose;
        private System.Windows.Forms.Button choose_warrior;
        private System.Windows.Forms.Button choose_tank;
        private System.Windows.Forms.Button choose_ranger;
        private System.Windows.Forms.Label turn;
        private System.Windows.Forms.Label player_name;
        private System.Windows.Forms.Label monster_name;
        private System.Windows.Forms.Label player_HP;
        private System.Windows.Forms.Label monster_HP;
        private System.Windows.Forms.Label player_MP;
        private System.Windows.Forms.Label monster_MP;
        private System.Windows.Forms.Label player_ATK;
        private System.Windows.Forms.Label monster_ATK;
        private System.Windows.Forms.Button button_attack;
        private System.Windows.Forms.Button button_skill;
        private System.Windows.Forms.Button button_continue;
        private System.Windows.Forms.TextBox messege;
    }
}

