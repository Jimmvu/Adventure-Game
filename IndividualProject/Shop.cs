using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    class Shop
    {
        // Player use limited gold to purchase equipment. leave option to go back to town.
        public static void shop()
        {
            Console.WriteLine($"{Program.currentPlayer.Gold} g");
            Console.WriteLine("-------------------------");
            Console.WriteLine("(s)word 10g  (p)otions 2g");
            Console.WriteLine("(a)rmor 5g   (l)eave");
            Console.WriteLine("-------------------------");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                // adds 3 damage to player damage output
                case "s":
                case "sword":
                    if (Program.currentPlayer.Gold >= 10)
                    {
                        Console.WriteLine("Thank you for your patronage!");
                        Program.currentPlayer.Damage += 3;
                        Program.currentPlayer.Gold -= 10;
                        Console.ReadKey(); Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough gold.");
                        Console.ReadKey(); Console.Clear();
                    }
                    shop();
                    break;

                case "a":
                case "armor":
                    //adds health to player health pool
                    if (Program.currentPlayer.Gold >= 5)
                    {
                        Console.WriteLine("Thank you for your patronage!");
                        Program.currentPlayer.Health += 5;
                        Program.currentPlayer.Maxhp = Program.currentPlayer.Health;
                        Program.currentPlayer.Gold -= 5;
                        Console.ReadKey(); Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough gold.");
                        Console.ReadKey(); Console.Clear();
                    }
                    shop();
                    break;

                case "p":
                case "potion":
                    // adds potions to amount of player potions
                    if (Program.currentPlayer.Gold >= 5)
                    {
                        Console.WriteLine("Thank you for your patronage!");
                        Program.currentPlayer.Potions += 1;
                        Program.currentPlayer.Gold -= 2;
                        Console.ReadKey(); Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough gold.");
                        Console.ReadKey(); Console.Clear();
                    }
                    shop();
                    break;
                case "l":
                case "leave":
                    //returns to town
                    Console.WriteLine("See you next time!");
                    Town.TownChoices();
                    Console.ReadKey(); Console.Clear();
                    break;
                default:
                    Console.WriteLine("Enter a valid response.");
                    Console.ReadKey(); Console.Clear();
                    shop();
                    break;
            }
        }
    }
}
