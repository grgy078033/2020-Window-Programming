using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f74086381_practice7_2
{
    public class RedCar : Car
    {
        public RedCar()
        {
            type = "RedCar";
            set_button(type);
        }
        public string get_type()
        {
            return type;
        }

    }
}
