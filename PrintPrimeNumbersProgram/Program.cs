using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPrimeNumbersProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Enter the Numbers:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("is Prime Number");
            }
            else
            {
                Console.WriteLine("is not a Prime Number");
            }
            Console.ReadLine();
        }
    }
}
