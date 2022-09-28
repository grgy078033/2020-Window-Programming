using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f74086381_practice2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sort = new int[9999999];
            int i, j, temp, m = 0;
            int n = 0;
            int temp_front = 0, temp_behind = 0;
            Console.WriteLine("請輸入整數序列(輸入空行結束):");
            while (true)//insert a sequence
            {
                try
                {
                    sort[n] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    break;
                }
                ++n;
            }

            int[] find_m = new int[n];
            Console.WriteLine("序列排序結果:");
            for (i = 0; i < n; ++i)//assign sort[n] to find_m[n]
                find_m[i] = sort[i];
            
            for (i = 0; i < n; ++i)
            {//bubble sorting of find_m[n]
                for (j = i; j < n; ++j)
                {
                    if (find_m[i] > find_m[j])
                    {
                        temp = find_m[i];
                        find_m[i] = find_m[j];
                        find_m[j] = temp;
                    }
                }
                if (i == (n - 1))
                    m = find_m[i / 2];
            }
            
            for(i = 0; i < n; ++i)//sorting
            {
                for(j = i; j < n; ++j)
                {
                    if ((sort[i] - m) < 0)//assign temp_fornt
                        temp_front -= (sort[i] - m);
                    else
                        temp_front = (sort[i] - m);

                    if ((sort[j] - m) < 0)//assign temp_behind
                        temp_behind -= (sort[j] - m);
                    else
                        temp_behind = (sort[j] - m);

                    if(temp_front < temp_behind)
                    {
                        temp = sort[i];
                        sort[i] = sort[j];
                        sort[j] = temp;
                    }
                    else if(temp_front == temp_behind)
                    {
                        if(sort[i] < sort[j])
                        {
                            temp = sort[i];
                            sort[i] = sort[j];
                            sort[j] = temp;
                        }
                    }
                    temp_front = 0;
                    temp_behind = 0;
                }
            }

            for (i = 0; i < n; ++i)//output the result
                Console.WriteLine(sort[i]);

            Console.ReadKey();//pause the screen
        }
    }
}
