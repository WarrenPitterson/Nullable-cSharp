using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            player.Name = "Warren";
            player.DaysSincelastLogin = 101;

            PlayerDisplay.Write(player);

            Console.ReadLine();
            
        }
    }
}
