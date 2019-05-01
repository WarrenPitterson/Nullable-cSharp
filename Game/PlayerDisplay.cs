using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class PlayerDisplay
    {
        public static void Write(PlayerCharacter player)
        {
            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player name is null or all whitespace");
            }
            else
            {
                Console.WriteLine(player.Name);
            }

            //int days = player.DaysSincelastLogin.GetValueOrDefault(-1);
            //int days = player.DaysSincelastLogin.HasValue ? player.DaysSincelastLogin.Value: -1;
            int days = player.DaysSincelastLogin ?? -1;

            Console.WriteLine($"{days} days since last login");

            //if (player.DaysSincelastLogin.HasValue)
            //{
            //    Console.WriteLine(player.DaysSincelastLogin.Value);            }
            //else
            //{
            //    Console.WriteLine("No value for DaysSinceLastLogin");
            //}

            if (player.DateofBirth == null)
            {
                Console.WriteLine("No date of birth given");
            }
            else
            {
                Console.WriteLine(player.DateofBirth);
            }

            if (player.IsNew == null)
            {
                Console.WriteLine("Player skill level is unknown");
            }
            else if (player.IsNew == true)
            {
                Console.WriteLine("Player is new");
            }
            else
            {
                Console.WriteLine("Player is pro!");
            }
        }
    }
}
