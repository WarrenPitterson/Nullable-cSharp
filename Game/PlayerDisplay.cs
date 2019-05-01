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

            if (player.DaysSincelastLogin == null)
            {
                Console.WriteLine("No value for DaysSinceLastLogin");
            }
            else
            {
                Console.WriteLine(player.DaysSincelastLogin);
            }

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
