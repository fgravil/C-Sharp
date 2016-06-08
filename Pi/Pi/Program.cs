using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double pi = 0;
            int div = 1,cnt = 1;


            while(cnt != 11000)
            {
                if(cnt % 2 == 0)
                {
                    pi -= 4.0 / div;
                }
                else
                {
                    pi += 4.0 / div;
                }
                
                Console.WriteLine("{0}th Term: {1}", cnt,pi);

                div += 2;
                cnt++;
            }
            Console.WriteLine("\n3.14: 119th term, 3.141: 1688th term, 3.1415: 10794th term");
            Console.ReadLine();
        }
    }
}
