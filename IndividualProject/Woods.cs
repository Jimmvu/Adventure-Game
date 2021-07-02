using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    class Woods
    {
        public static void woods()
        {
            Console.WriteLine("You are making your way through the dense woods when suddenly a wolf attacks you!");
            Console.ReadKey();
            Console.Clear();
            Encounters.Combat(false, "Wolf", 2, 6, true);
            fork();

        }
        public static void fork()
        {
            Console.WriteLine("As you traverse through the woods you reach a fork in the road. Which path do you take?");
            Console.WriteLine("(l)eft    (r)ight");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "l":
                case "left":
                    Console.WriteLine("There is a ogre in your path, you can't turn back now.");
                    Console.ReadKey(); Console.Clear();
                    Encounters.Combat(false, "Ogre", 10, 20, false);
                    Console.WriteLine("You managed to slay the ogre. Realizing you took the wrong path you turn back and take the right.");
                    Console.ReadKey(); Console.Clear();
                    Bridge.bridge();
                    break;
                case "r":
                case "right":
                    Console.WriteLine("You take the right path. You can see the Dragons lair up ahead past a bridge");
                    Console.WriteLine("A bandit ambushes you!");
                    Console.ReadKey(); Console.Clear();
                    Encounters.Combat(false, "Bandit", 2, 8, true);
                    break;
                default:
                    Console.WriteLine("Enter a valid response.");
                    fork();
                    break;
            }
            Console.WriteLine("You begin your trek across the bridge");
            Console.ReadKey(); Console.Clear(); ;
            Bridge.bridge();
        }
    }
}
