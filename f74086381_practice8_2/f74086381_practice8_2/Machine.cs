using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f74086381_practice8_2
{
    class Machine
    {
        private string type = "";
        protected void set_type(string Type)
        {
            type = Type;
        }
        public string get_type()
        {
            return type;
        }
    }
}
