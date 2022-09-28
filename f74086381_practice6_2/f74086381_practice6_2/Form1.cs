using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f74086381_practice6_2
{
    public partial class Form1 : Form
    {
        int count = 1;
        bool die = false;
        bool skill_on = false;
        Random rd = new Random();
        int random = 0;
        monster monster = new monster();
        creature player;
        public Form1()
        {
            InitializeComponent();
            turn.Text = "1";
            turn.Visible = false;
            messege.Visible = false;
            player_name.Visible = false;
            player_HP.Visible = false;
            player_MP.Visible = false;
            player_ATK.Visible = false;
            monster_name.Visible = false;
            monster_HP.Visible = false;
            monster_MP.Visible = false;
            monster_ATK.Visible = false;
            button_attack.Visible = false;
            button_skill.Visible = false;
            button_continue.Visible = false;
        }
        private void Warrior_Click(object sender, EventArgs e)
        {
            player = new warrior();
            player.HP = 100;
            player.MP = 15;
            player.Attack = 20;
            monster.HP = 70;
            monster.MP = 10;
            monster.Attack = 20;
            player_HP.Text = "HP : " + player.HP;
            player_MP.Text = "MP : " + player.MP;
            player_ATK.Text = "ATK : " + player.Attack;
            monster_HP.Text = "HP : " + monster.HP;
            monster_MP.Text = "MP : " + monster.MP;
            monster_ATK.Text = "ATK : " + monster.Attack;
            player_name.Text = "戰士";
            messege.Visible = true;
            messege.Text = "敵人出現了" + "\r\n";
            player_name.Visible = true;
            player_HP.Visible = true;
            player_MP.Visible = true;
            player_ATK.Visible = true;
            monster_name.Visible = true;
            monster_HP.Visible = true;
            monster_MP.Visible = true;
            monster_ATK.Visible = true;
            button_attack.Visible = true;
            button_skill.Visible = true;
            button_continue.Visible = true;
            choose.Visible = false;
            choose_warrior.Visible = false;
            choose_tank.Visible = false;
            choose_ranger.Visible = false;
            turn.Text = "關卡:";
            turn.Visible = true;
            turn.Text = turn.Text + count;
        }

        private void choose_tank_Click(object sender, EventArgs e)
        {
            player = new tank();
            player.HP = 150;
            player.MP = 15;
            player.Attack = 15;
            monster.HP = 70;
            monster.MP = 10;
            monster.Attack = 20;
            player_HP.Text = "HP : " + player.HP;
            player_MP.Text = "MP : " + player.MP;
            player_ATK.Text = "ATK : " + player.Attack;
            monster_HP.Text = "HP : " + monster.HP;
            monster_MP.Text = "MP : " + monster.MP;
            monster_ATK.Text = "ATK : " + monster.Attack;
            player_name.Text = "坦克";
            messege.Visible = true;
            messege.Text = "敵人出現了" + "\r\n";
            player_name.Visible = true;
            player_HP.Visible = true;
            player_MP.Visible = true;
            player_ATK.Visible = true;
            monster_name.Visible = true;
            monster_HP.Visible = true;
            monster_MP.Visible = true;
            monster_ATK.Visible = true;
            button_attack.Visible = true;
            button_skill.Visible = true;
            button_continue.Visible = true;
            choose.Visible = false;
            choose_warrior.Visible = false;
            choose_tank.Visible = false;
            choose_ranger.Visible = false;
            turn.Text = "關卡:";
            turn.Visible = true;
            turn.Text = turn.Text + count;
        }
        private void choose_ranger_Click(object sender, EventArgs e)
        {
            player = new ranger();
            player.HP = 80;
            player.MP = 20;
            player.Attack = 25;
            monster.HP = 70;
            monster.MP = 10;
            monster.Attack = 20;
            player_HP.Text = "HP : " + player.HP;
            player_MP.Text = "MP : " + player.MP;
            player_ATK.Text = "ATK : " + player.Attack;
            monster_HP.Text = "HP : " + monster.HP;
            monster_MP.Text = "MP : " + monster.MP;
            monster_ATK.Text = "ATK : " + monster.Attack;
            player_name.Text = "遊俠";
            messege.Visible = true;
            messege.Text = "敵人出現了" + "\r\n";
            player_name.Visible = true;
            player_HP.Visible = true;
            player_MP.Visible = true;
            player_ATK.Visible = true;
            monster_name.Visible = true;
            monster_HP.Visible = true;
            monster_MP.Visible = true;
            monster_ATK.Visible = true;
            button_attack.Visible = true;
            button_skill.Visible = true;
            button_continue.Visible = true;
            choose.Visible = false;
            choose_warrior.Visible = false;
            choose_tank.Visible = false;
            choose_ranger.Visible = false;
            turn.Text = "關卡:";
            turn.Visible = true;
            turn.Text = turn.Text + count;
        }

        private void button_continue_Click(object sender, EventArgs e)
        {
            if (!die)
            {
                monster.HP = 70;
                monster.MP = 10;
                monster.Attack = 20;
                monster_HP.Text = "HP : " + monster.HP;
                monster_MP.Text = "MP : " + monster.MP;
                monster_ATK.Text = "ATK : " + monster.Attack;
                messege.Text = "敵人出現了\r\n";
                turn.Text = "關卡:";
                count++;
                turn.Text = turn.Text + count;
                button_attack.Enabled = true;
                button_skill.Enabled = true;
                button_continue.Enabled = false;
            }
            else
            {
                count = 1;
                turn.Visible = false;
                messege.Visible = false;
                player_name.Visible = false;
                player_HP.Visible = false;
                player_MP.Visible = false;
                player_ATK.Visible = false;
                monster_name.Visible = false;
                monster_HP.Visible = false;
                monster_MP.Visible = false;
                monster_ATK.Visible = false;
                button_attack.Visible = false;
                button_skill.Visible = false;
                button_continue.Visible = false;
                choose.Visible = true;
                choose_warrior.Visible = true;
                choose_tank.Visible = true;
                choose_ranger.Visible = true;
                button_attack.Enabled = true;
                button_skill.Enabled = true;
                button_continue.Enabled = false;
                die = false;
            }
        }

        private void button_attack_Click(object sender, EventArgs e)
        {
            switch (player_name.Text)
            {
                case "戰士":
                    messege.Text += "玩家攻擊\r\n敵人受到了20傷害\r\n";
                    monster_HP.Text = "HP : " + (monster.HP -= player.Attack);
                    if(monster.HP <= 0)
                    {
                        button_attack.Enabled = false;
                        button_skill.Enabled = false;
                        button_continue.Enabled = true;
                        messege.Text += "你贏了，你回復了體力和魔力\r\n";
                        player_HP.Text = "HP : " + (player.HP += 30);
                        player_MP.Text = "MP : " + (player.MP += 10);
                        break;
                    }
                    random = rd.Next(1, 10);
                    if(random == 1 || random == 2)
                    {
                        if (monster.MP == 0)
                        {
                            messege.Text += "魔物沒有魔力了\r\n";
                        }
                        else
                        {
                            messege.Text += "敵人使用了技能，強化了自己\r\n";
                            monster_HP.Text = "HP : " + (monster.HP += 20);
                            monster_MP.Text = "MP : " + (monster.MP -= 5);
                            monster_ATK.Text = "ATK : " + (monster.Attack += 10);
                        }
                    }
                    else
                    {
                        messege.Text += "敵人攻擊\r\n玩家受到了" + monster.Attack + "傷害\r\n";
                        player_HP.Text = "HP : " + (player.HP -= monster.Attack);
                        if(player.HP <= 0)
                        {
                            messege.Text += "你死了\r\n";
                            button_attack.Enabled = false;
                            button_skill.Enabled = false;
                            button_continue.Enabled = true;
                            die = true;
                        }
                    }
                    break;
                case "坦克":
                    messege.Text += "玩家攻擊\r\n敵人受到了15傷害\r\n";
                    monster_HP.Text = "HP : " + (monster.HP -= player.Attack);
                    if (monster.HP <= 0)
                    {
                        button_attack.Enabled = false;
                        button_skill.Enabled = false;
                        button_continue.Enabled = true;
                        messege.Text += "你贏了，你回復了體力和魔力\r\n";
                        player_HP.Text = "HP : " + (player.HP += 30);
                        player_MP.Text = "MP : " + (player.MP += 10);
                        break;
                    }
                    random = rd.Next(1, 10);
                    if (random == 1 || random == 2)
                    {
                        if (monster.MP == 0)
                        {
                            messege.Text += "魔物沒有魔力了\r\n";
                        }
                        else
                        {
                            messege.Text += "敵人使用了技能，強化了自己\r\n";
                            monster_HP.Text = "HP : " + (monster.HP += 20);
                            monster_MP.Text = "MP : " + (monster.MP -= 5);
                            monster_ATK.Text = "ATK : " + (monster.Attack += 10);
                        }
                    }
                    else
                    {
                        if (skill_on) // 有沒有開盾
                        {
                            messege.Text += "敵人攻擊\r\n玩家吸收了" + monster.Attack + "傷害\r\n";
                            player_HP.Text = "HP : " + (player.HP += monster.Attack);
                            skill_on = false;
                        }
                        else
                        {
                            messege.Text += "敵人攻擊\r\n玩家受到了" + monster.Attack + "傷害\r\n";
                            player_HP.Text = "HP : " + (player.HP -= monster.Attack);
                        }

                        if (player.HP <= 0)
                        {
                            messege.Text += "你死了\r\n";
                            button_attack.Enabled = false;
                            button_skill.Enabled = false;
                            button_continue.Enabled = true;
                            die = true;
                        }
                    }
                    break;
                case "遊俠":
                    messege.Text += "玩家攻擊\r\n敵人受到了25傷害\r\n";
                    monster_HP.Text = "HP : " + (monster.HP -= player.Attack);
                    if (monster.HP <= 0)
                    {
                        button_attack.Enabled = false;
                        button_skill.Enabled = false;
                        button_continue.Enabled = true;
                        messege.Text += "你贏了，你回復了體力和魔力\r\n";
                        player_HP.Text = "HP : " + (player.HP += 30);
                        player_MP.Text = "MP : " + (player.MP += 10);
                        break;
                    }
                    random = rd.Next(1, 10);
                    if (random == 1 || random == 2)
                    {
                        if (monster.MP == 0)
                        {
                            messege.Text += "魔物沒有魔力了\r\n";
                        }
                        else
                        {
                            messege.Text += "敵人使用了技能，強化了自己\r\n";
                            monster_HP.Text = "HP : " + (monster.HP += 20);
                            monster_MP.Text = "MP : " + (monster.MP -= 5);
                            monster_ATK.Text = "ATK : " + (monster.Attack += 10);
                        }
                    }
                    else
                    {
                        messege.Text += "敵人攻擊\r\n玩家受到了" + monster.Attack + "傷害\r\n";
                        player_HP.Text = "HP : " + (player.HP -= monster.Attack);
                        if (player.HP <= 0)
                        {
                            messege.Text += "你死了\r\n";
                            button_attack.Enabled = false;
                            button_skill.Enabled = false;
                            button_continue.Enabled = true;
                            die = true;
                        }
                    }
                    break;
            }
        }

        private void button_skill_Click(object sender, EventArgs e)
        {
            switch (player_name.Text)
            {
                case "戰士":
                    if (player.MP >= 5)
                    {
                        messege.Text += "玩家使用了技能，造成且吸收了20傷害\r\n敵人受到了20傷害\r\n";
                        player_HP.Text = "HP : " + (player.HP += player.Attack);
                        player_MP.Text = "MP : " + (player.MP -= 5);
                        monster_HP.Text = "HP : " + (monster.HP -= player.Attack);
                        if (monster.HP <= 0)
                        {
                            button_attack.Enabled = false;
                            button_skill.Enabled = false;
                            button_continue.Enabled = true;
                            messege.Text += "你贏了，你回復了體力和魔力\r\n";
                            player_HP.Text = "HP : " + (player.HP += 30);
                            player_MP.Text = "MP : " + (player.MP += 10);
                            break;
                        }
                    }
                    else
                    {
                        messege.Text += "玩家沒有魔力了\r\n";
                    }
                    random = rd.Next(1, 10);
                    if (random == 1 || random == 2)
                    {
                        if (monster.MP == 0)
                        {
                            messege.Text += "魔物沒有魔力了\r\n";
                        }
                        else
                        {
                            messege.Text += "敵人使用了技能，強化了自己\r\n";
                            monster_HP.Text = "HP : " + (monster.HP += 20);
                            monster_MP.Text = "MP : " + (monster.MP -= 5);
                            monster_ATK.Text = "ATK : " + (monster.Attack += 10);
                        }
                    }
                    else
                    {
                        messege.Text += "敵人攻擊\r\n玩家受到了" + monster.Attack + "傷害\r\n";
                        player_HP.Text = "HP : " + (player.HP -= monster.Attack);
                        if (player.HP <= 0)
                        {
                            messege.Text += "你死了\r\n";
                            button_attack.Enabled = false;
                            button_skill.Enabled = false;
                            button_continue.Enabled = true;
                            die = true;
                        }
                    }
                    break;
                case "坦克":
                    if (player.MP >= 5)
                    {
                        if (skill_on)
                        {
                            messege.Text += "玩家舉起了盾\r\n";
                            player_MP.Text = "MP : " + (player.MP -= 5); ;
                        }
                        else
                        {
                            messege.Text += "玩家舉起了盾\r\n";
                            player_MP.Text = "MP : " + (player.MP -= 5);
                            skill_on = true;
                        }
                    }
                    else
                    {
                        messege.Text += "玩家沒有魔力了\r\n";
                    }
                    random = rd.Next(1, 10);
                    if (random == 1 || random == 2)
                    {
                        if (monster.MP == 0)
                        {
                            messege.Text += "魔物沒有魔力了\r\n";
                        }
                        else
                        {
                            messege.Text += "敵人使用了技能，強化了自己\r\n";
                            monster_HP.Text = "HP : " + (monster.HP += 20);
                            monster_MP.Text = "MP : " + (monster.MP -= 5);
                            monster_ATK.Text = "ATK : " + (monster.Attack += 10);
                        }
                    }
                    else
                    {
                        if (skill_on) // 有沒有開盾
                        {
                            messege.Text += "敵人攻擊\r\n玩家吸收了" + monster.Attack + "傷害\r\n";
                            player_HP.Text = "HP : " + (player.HP += monster.Attack);
                            skill_on = false;
                        }
                        else
                        {
                            messege.Text += "敵人攻擊\r\n玩家受到了" + monster.Attack + "傷害\r\n";
                            player_HP.Text = "HP : " + (player.HP -= monster.Attack);
                        }

                        if (player.HP <= 0)
                        {
                            messege.Text += "你死了\r\n";
                            button_attack.Enabled = false;
                            button_skill.Enabled = false;
                            button_continue.Enabled = true;
                            die = true;
                        }
                    }
                    break;
                case "遊俠":
                    if (player.MP >= 5)
                    {
                        messege.Text += "玩家使用了技能\r\n敵人受到了" + player.Attack * 2 + "傷害\r\n";
                        player_MP.Text = "MP : " + (player.MP -= 5);
                        monster_HP.Text = "HP : " + (monster.HP -= (player.Attack * 2));
                        if (monster.HP <= 0)
                        {
                            button_attack.Enabled = false;
                            button_skill.Enabled = false;
                            button_continue.Enabled = true;
                            messege.Text += "你贏了，你回復了體力和魔力\r\n";
                            player_HP.Text = "HP : " + (player.HP += 30);
                            player_MP.Text = "MP : " + (player.MP += 10);
                            break;
                        }
                    }
                    else
                    {
                        messege.Text += "玩家沒有魔力了\r\n";
                    }
                    random = rd.Next(1, 10);
                    if (random == 1 || random == 2)
                    {
                        if (monster.MP == 0)
                        {
                            messege.Text += "魔物沒有魔力了\r\n";
                        }
                        else
                        {
                            messege.Text += "敵人使用了技能，強化了自己\r\n";
                            monster_HP.Text = "HP : " + (monster.HP += 20);
                            monster_MP.Text = "MP : " + (monster.MP -= 5);
                            monster_ATK.Text = "ATK : " + (monster.Attack += 10);
                        }
                    }
                    else
                    {
                        messege.Text += "敵人攻擊\r\n玩家受到了" + monster.Attack + "傷害\r\n";
                        player_HP.Text = "HP : " + (player.HP -= monster.Attack);
                        if (player.HP <= 0)
                        {
                            messege.Text += "你死了\r\n";
                            button_attack.Enabled = false;
                            button_skill.Enabled = false;
                            button_continue.Enabled = true;
                            die = true;
                        }
                    }
                    break;
            }
        }
    }
}
