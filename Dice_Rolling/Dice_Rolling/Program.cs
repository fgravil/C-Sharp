using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Rolling
{
    class Dice_Roll
    {
        static void Main(string[] args)
        {
            int[] tally = new int[11];
            int sum;
            float percent;
            Random random = new Random();

            for(int i=0; i < 36000; i++)
            {
                sum = random.Next(1, 7);
                sum += random.Next(1, 7);
                tally[sum - 2]++;
            }

            Console.WriteLine("{0}{1,6}{2,12}", "sum", "tally", "percentage");
            for(int i=0;i<tally.Length;i++)
            {
                percent = (float)tally[i] / 36000 * 100;
                Console.WriteLine("{0,3}{1,6}{2,12}", i + 2, tally[i], percent );
            }
            Console.ReadLine();
        }
    }
}
