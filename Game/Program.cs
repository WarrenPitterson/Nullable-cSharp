using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter Warren = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Warren"
            };

            PlayerCharacter Bob = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Bob"
            };

            PlayerCharacter Steve = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Steve"
            };


            Warren.Hit(10);
            Bob.Hit(20);
            Steve.Hit(30);

            Console.ReadLine();
            
        }
    }
}
