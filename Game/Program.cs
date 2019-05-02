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

            PlayerCharacter Bob = new PlayerCharacter(new IronBonesDefence())
            {
                Name = "Bob"
            };

            PlayerCharacter Steve = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Steve"
            };

            Warren.Hit(30);
            Bob.Hit(30);
            Steve.Hit(30);

            Console.ReadKey();
            
        }
    }
}
