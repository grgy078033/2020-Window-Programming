using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f74086381_practice4_2
{
    class Building
    {
        public Building()
        {
            set_type("");
        }
        protected int HP;
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

        public void set_type(string Type)
        {
            type = Type;
            switch (type) {
                case "TC":
                    set_HP(1000);
                    break;
                case "Barracks":
                    set_HP(500);
                    break;
                case "ArcheryRange":
                    set_HP(300);
                    break;
                case "Stable":
                    set_HP(300);
                    break;
                default:
                    set_HP(0);
                    break;
            }
        }
    }
}
