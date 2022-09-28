using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f74086381_practice6_2
{
    class creature
    {
        private int hp;
        private int mp;
        private int attack;

        public int HP
        {
            get { return hp; }
            set
            {
                hp = value;
            }
        }
        public int MP
        {
            get { return mp; }
            set
            {
                mp = value;
            }
        }
        public int Attack
        {
            get { return attack; }
            set
            {
                attack = value;
            }
        }
    }
}
