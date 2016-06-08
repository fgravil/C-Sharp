using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamonds
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowCnt;
            Console.Write("Please enter an odd number between 1-19 : ");
            rowCnt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i < rowCnt / 2; i++)
            {
                for(int j = 0; j < rowCnt / 2 - i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j < 1 + 2 * i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(int i = 0; i < rowCnt; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for(int i = rowCnt / 2; i > 0; i--)
            {
                for (int j = 0; j < rowCnt / 2 - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i -1 ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
