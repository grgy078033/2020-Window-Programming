using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f74086381_practice3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int i = 0;
            int j = 0;
            char[,] map = new char[n, m];
            for(i = 0; i < n; ++i)
            {
                for(j = 0; j < m; ++j)
                {
                    map[i,j] = Convert.ToChar(Console.Read());
                }
            }
            for(i = 0; i < n; ++i)
            {
                for(j = 0; j < m; ++j)
                {
                    Console.Write(map[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
