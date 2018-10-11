using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            begin:
            while (cont)
            {
                Console.WriteLine("Square & Cube calculator");
                Console.WriteLine("To start please enter a number:");
                int uNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Number\t\tSquared\t\tCubed");
                Console.WriteLine("======\t\t=======\t\t======");

                for (int x = 1; x <= uNum; x++)
                { 
                    Console.WriteLine("{0}\t\t{1}\t\t{2}", x, Math.Pow(x, 2), Math.Pow(x, 3));
                }
                repeat:
                Console.WriteLine("Would you like to continue with choosing another number? Y/N: ");
                string ans = Console.ReadLine();
                if (ans == "y" || ans == "Y")
                {
                    goto begin;
                }
                if (ans == "n" || ans == "N")
                {
                    Console.WriteLine("Good Bye");
                    Console.ReadKey();
                    cont = false;
                }
                else
                {
                    Console.WriteLine("Please choose 'Y' or 'N'");
                    goto repeat;
                }
            }
        }
    }
}
