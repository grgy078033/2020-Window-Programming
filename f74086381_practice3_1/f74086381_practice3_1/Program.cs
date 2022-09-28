using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f74086381_practice3_1
{
    class Program
    {
        static private void search (char[,] map, ref int[,] record, int x, int y, int n, int m) {
            int i = 0, j = 0;
            if (x < 0 || x >= n)
            {
                return;
            }
            else if (y < 0 || y >= m)
            {
                return;
            }
            else if (record[x, y] == 1)
            {
                return;
            }
            else if (map[x, y] == '*')
            {
                return;
            }
            record[x, y] = 1;
            
            for (i = x-1; i <= x+1; ++i)
            {
                for(j = y-1; j <= y+1; ++j)
                {
                    if (i == x && j == y)
                        continue;
                    else
                        search(map, ref record, i, j, n, m);
                }
            }
            return;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("input n, m(1 <= n <= 100, 1 <= m <= 100):");
            int n;
            n = int.Parse(Console.ReadLine());
            int m;
            m = int.Parse(Console.ReadLine());
            while (n < 1 || n > 100 || m < 1 || m > 100)
            {
                Console.WriteLine("out of range, try again:");
                n = int.Parse(Console.ReadLine());
                m = int.Parse(Console.ReadLine());
            }

            char[,] map = new char[n, m];
            int[,] record = new int[n, m];
            int i = 0;
            int j = 0;
            int river = 0;
            for(i = 0; i < n; ++i)
            {
                string str = Console.ReadLine();
                for(j = 0; j < m; ++j)
                {
                    map[i, j] = str[j];
                }
            }

            for(i = 0; i < n; ++i)
            {
                for(j = 0; j < m; ++j)
                {
                    if ((map[i, j] == '#') && (record[i, j] == 0))
                    {
                        search(map, ref record, i, j, n, m);
                        ++river;
                    }
                    
                }
            }
            Console.WriteLine(river);
            Console.WriteLine();
            Console.WriteLine("press any key to exit!");
            Console.ReadKey();
        }
    }
}
