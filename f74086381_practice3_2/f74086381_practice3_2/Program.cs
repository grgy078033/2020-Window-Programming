using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f74086381_practice3_2
{
    class Program
    {
        static private bool check_prime(int num1, int num2)
        {
            int sum = num1 + num2;
            int i;
            if (sum == 3)
                return true;
            else
            {
                if (sum % 2 == 0)
                    return false;
                for(i = 3; i < sum; i += 2)
                {
                    if(sum % i == 0)
                        return false;
                }
            }
            return true;
        }

        static private void swap(ref int num1, ref int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }

        static private void permutation(ref int[] ring, int start, int n)
        { //list[i] ~ list[n] permutation
            int i, j;
            if (start == n-1)
            {
                for (i = 0; i < n; ++i)
                {
                    if(i == n - 1)
                    {
                        if(check_prime(ring[0], ring[i]))
                        {
                            for(j = 0; j < n; ++j)
                            {
                                Console.Write(ring[j]);
                                Console.Write(" ");
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (check_prime(ring[i], ring[i + 1]))
                            continue;
                        else
                            break;
                    }
                }
            }
            else
            { //i < n
                for (j = start; j < n; ++j)
                {
                    swap(ref ring[start], ref ring[j]); //list[j] as head
                    permutation(ref ring, start + 1, n); //list[i+1] ~ list[n] permutation
                    swap(ref ring[start], ref ring[j]); //return to the original list
                }
            }
        }
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            Console.WriteLine("please enter a even integer n(2 <= n <= 16):");
            int n;
            n = int.Parse(Console.ReadLine());
            while(n < 2 || n > 16 || (n % 2) != 0)
            {
                Console.WriteLine("you input a wrong number, please try again:");
                n = int.Parse(Console.ReadLine());
            }
            int[] ring = new int[n];

            for (i = 0; i < n; ++i)
            {
                ring[i] = i + 1;
            }

            permutation(ref ring, 1, n);
            
            Console.ReadKey();
        }
    }
}
