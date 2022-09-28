using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f74086381_practice4_2
{
    class Unit
    {
        public Unit()
        {
            set_type("");
        }
        protected int HP;
        protected int attack;
        protected string type;
        
        public int get_HP()
        {
            return HP;
        }
        public void set_HP(int hp)
        {
            HP = hp;
        }
        public string get_type()
        {
            return type;
        }
        public int get_attack()
        {
            return attack;
        }

        public void set_attack(int Attack)
        {
            attack = Attack;
        }
        public void set_type(string Type)
        {
            type = Type;
            switch (type)
            {
                case "Villager":
                    set_HP(50);
                    set_attack(2);
                    break;
                case "Militia":
                    set_HP(100);
                    set_attack(10);
                    break;
                case "Archer":
                    set_HP(75);
                    set_attack(15);
                    break;
                case "Scout":
                    set_HP(80);
                    set_attack(5);
                    break;
                default:
                    set_HP(0);
                    set_attack(0);
                    break;
            }
        }
    }
}
