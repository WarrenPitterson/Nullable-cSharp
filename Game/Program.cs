using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            player.Name = "Warren"; 
            player.DaysSincelastLogin = null;

            PlayerDisplay.Write(player);

            Console.ReadLine();
            
        }
    }
}
