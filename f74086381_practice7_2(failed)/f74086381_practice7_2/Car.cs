using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f74086381_practice7_2
{
    public class Car
    {
        public Car() { }
        private int length;
        private string color;
        protected string type = "";
        public string row_column = "";
        public int get_length()
        {
            return length;
        }
        public void set_length(int Length)
        {
            length = Length;
        }
        public string get_color()
        {
            return color;
        }
        public void set_color(string Color)
        {
            color = Color;
        }
        public string get_type()
        {
            return type;
        }
        public void set_row_column(string Row_Column)
        {
            row_column = Row_Column;
        }
        public void set_button(string type)
        {
            switch (type)
            {
                case "RedCar":
                    set_length(2);
                    set_color("Red");
                    break;
                case "Van":
                    set_length(3);
                    set_color("LightBlue");
                    break;
                case "Bus":
                    set_length(4);
                    set_color("Yellow");
                    break;
            }
        }
    }
}
