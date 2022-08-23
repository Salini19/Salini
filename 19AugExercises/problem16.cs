using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19August
{
    internal class problem16
    {
        static void Main(string[] args)
        {
            int points = 100;
            string shoot;
            int action = 1;

            for (action = 1; action <= 4; action++)
            {
                Console.WriteLine("Enter Hit or Miss");
                shoot = Console.ReadLine();

                if (shoot == "hit")
                {
                    points += 10;
                }
                if (shoot == "miss")
                {
                    points -= 20;
                }
            }

            Console.WriteLine("total points: {0}", points);
            Console.ReadLine();
        }
    }
}
