using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Queens
{
    class Program
    {
        const int N = 8;
        static int[] position = new int[N];
        static int num = 0;

        static bool isSafe(int queen_number,int row_position)
        {
            for (int i = 0; i < queen_number; i++)
            {
                // Get another queen's row_position
                int other_row_pos = position[i];

                // Now check if they're in the same row or diagonals
                if (other_row_pos == row_position || // Same row
                    other_row_pos == row_position - (queen_number - i) || // Same diagonal
                    other_row_pos == row_position + (queen_number - i))   // Same diagonal
                    return false;
            }
            return true;
        }
        static void solve(int k)
        {
            if (k == N) // We placed N-1 queens (0 included), problem solved!
            {
                // Solution found!
                Console.Write("Solution: ");
                for (int i = 0; i < N; i++)
                    Console.Write("{0}",position[i]);
                Console.WriteLine();
                num++;

            }
            else
            {
                for (int i = 0; i < N; i++) // Generate ALL combinations
                {
                    // Before putting a queen (the k-th queen) into a row, test it for safeness
                    if (isSafe(k, i))
                    {
                        position[k] = i;
                        // Place another queen
                        solve(k + 1);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            solve(0);
            Console.WriteLine("\n{0} Solutions found.", num);
            Console.ReadLine();
        }
    }
}
