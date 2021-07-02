using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    class Bridge
    {
        public static void bridge()
        {
            string s = "anbspo";
            Console.WriteLine("There is a bridge troll blocking your path. 'Answer my riddle correctly and I'll let you through.Answer incorrectly and you die.'");
            Console.ReadKey(); Console.Clear();
            Console.WriteLine("What gets wetter as it dries?");
            Console.WriteLine("Enter your response");
            string input = Console.ReadLine().ToLower();
            //There are two ways to make it past. Answer the riddle correctly or kill the troll.
            switch (input)
            {
                case "":
                    Console.WriteLine("Enter a response");
                    Console.ReadKey(); Console.Clear();
                    bridge();
                    break;
                case "towel":
                case "a towel":
                    Console.WriteLine("Good job! The Bridge Troll allows you to keep moving forwards. As you pass the Bridge Troll says,\n'Don't forget this, you'll need it.");
                    Console.WriteLine("It hands you a piece of paper with a code transcribed on it.");
                    Console.WriteLine(Code(s));
                    Final.final();
                    break;
                default:
                    Console.WriteLine("'Wrong answer!' The troll readies his attack.");
                    Encounters.Combat(false, "Bridge Troll", 3, 12, true);
                    Console.WriteLine("He drops a piece of paper with a code trancribed on it. 'What does it do?' you wonder.");
                    Final.final();
                    break;
                
            }
        }
        // A return method utilizing an array to return the code.
        public static string Code(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
