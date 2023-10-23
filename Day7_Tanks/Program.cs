using ClassLibrary1.WordOfTanks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Tanks
{
    class Program
    {
        static void Main()
        {
            Tank[] t34Tanks = new Tank[5];
            Tank[] panteraTanks = new Tank[5];


            for (int i = 0; i < 5; i++)
            {
                t34Tanks[i] = new Tank("Т-57");
                panteraTanks[i] = new Tank("Pantera");
            }

            for (int i = 0; i < 5; i++)
            {
                bool t34Wins = t34Tanks[i] ^ panteraTanks[i];

                if (t34Wins)
                {
                    Console.WriteLine($"Бой {i + 1}: Т-57 победил Pantera");
                }
                else
                {
                    Console.WriteLine($"Бой {i + 1}: Pantera победил Т-57");
                }
                Console.ReadKey();
            }
        }
    }
}
