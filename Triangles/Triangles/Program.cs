using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 10; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                for(int j=0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 10; k > i; k--){
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for(int i = 0; i < 10; i++)
            {
                for(int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
            
        }
    }
}
