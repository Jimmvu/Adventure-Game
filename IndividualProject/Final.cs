using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    class Final
    {
        public static void final()
        {
            Console.WriteLine("You make it to the gates of the castle and a giant door blocks your path. \n You try opening the door with no luck. It looks" +
                "like you have to enter a code to enter.");
            Door();
        }
        public static void Door()
        {
            //If code is entered incorrectly it calls the Door method again.
            Console.WriteLine("Enter the code:");
            string doorCode = Console.ReadLine();
            if (doorCode == "opsbna")
            {
                Console.WriteLine("The door suddenly opens and you make your way in.");
                Console.ReadKey();Console.Clear();
                Boss();
            }
            else
            {
                Console.WriteLine("You entered the wrong code.");
                Door();
                Console.ReadKey(); Console.Clear();
            }
        }
        public static void Boss()
        {
            Console.WriteLine("You feel the heat emminating from the fire breathing beast.You ready your blade, the journey is coming to an end.");
            Encounters.Combat(false, "Dragon", 5, 25, false);
            Console.ReadKey(); Console.Clear();
            Console.WriteLine("You defeated the Dragon. Congratulations You Win");
        }
    }
}
