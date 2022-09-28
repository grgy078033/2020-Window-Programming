using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f74086381_practice2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i = 0, j = 0;
            Console.Write("輸入六邊形的寬度(n>=2)，輸入0離開:");
            n = int.Parse(Console.ReadLine());
            while(n != 0)
            {
                for (i = 0; i < n * 4 - 3; ++i)//first line
                {
                     if (i < n - 1)
                        Console.Write(" ");
                     else if (i >= n - 1 && i <= n * 3 - 3)
                        Console.Write("*");
                     else if (i > n * 3 - 3 && i < n * 4 - 4)
                        Console.Write(" ");
                     else if (i == n * 4 - 4)
                        Console.WriteLine();
                }
                for (i = 0; i < n * 2 - 3; ++i) 
                {
                    if(i == n - 2)//middle line
                    {
                        for(j = 0; j < n * 4 - 3; ++j)
                        {
                            if (j == 0)
                                Console.Write("*");
                            else if (j == n * 4 - 4)
                                Console.WriteLine("*");
                            else
                                Console.Write(" ");
                        }
                    }
                    else if (i < n - 2)//上半部
                    {
                        for(j = 0; j < n * 4 - 3; ++j)
                        {
                            if (j < n - i - 2)
                                Console.Write(" ");
                            else if (j == n - i - 2)//上左
                                Console.Write("*");
                            else if (j > n - i - 2 && j < n * 3 - 2 + i)
                                Console.Write(" ");
                            else if (j == n * 3 - 2 + i)//上右
                                Console.Write("*");
                            else if (j > n * 3 - 2 + i && j < n * 4 - 4)
                                Console.Write(" ");
                            else if (j == n * 4 - 4)
                                Console.WriteLine();
                        }
                    }
                    else if (i > n - 2)//下半部
                    {
                        for(j = 0; j < n * 4 - 3; ++j)
                        {
                            if (j < i + 2 - n)
                                Console.Write(" ");
                            else if (j == i + 2 - n)//下左
                                Console.Write("*");
                            else if (j > i + 2 - n && j < n * 5 - 6 - i)
                                Console.Write(" ");
                            else if (j == n * 5 - 6 - i)//下右
                                Console.Write("*");
                            else if (j > n * 5 - 6 - i && j < n * 4 - 4)
                                Console.Write(" ");
                            else if (j == n * 4 - 4)
                                Console.WriteLine();
                        }
                    }
                }
                for (i = 0; i < n * 4 - 3; ++i)//last line
                {
                    if (i < n - 1)
                        Console.Write(" ");
                    else if (i >= n - 1 && i <= n * 3 - 3)
                        Console.Write("*");
                    else if (i > n * 3 - 3 && i < n * 4 - 4)
                        Console.Write(" ");
                    else if (i == n * 4 - 4)
                        Console.WriteLine();
                }
                Console.Write("輸入六邊形的寬度(n>=2)，輸入0離開:");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Exit!");
            Console.ReadKey();
        }
    }
}
