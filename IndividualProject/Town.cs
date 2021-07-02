using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    class Town
    {
        public static void town()
        {
            Console.WriteLine("You are in the town and an old man approaches you. 'My name is Harold he says'. What will you do?");
            Console.WriteLine("a. Talk to the old man / b. ignore him \nc. Attack him");

            string choice = Console.ReadLine().ToLower();
            // switch to determine the outcome of the decision
            switch (choice)
            {
                case "a":
                case "talk":
                    {
                        Console.WriteLine("You talk to the wise man.'When you reach a fork in your path, make sure to take the right path' he says.");
                        Console.ReadKey(); Console.Clear();
                        TownChoices();
                        break;
                    }
                case "b":
                case "ignore":
                    {
                        Console.WriteLine("You ignore him, 'He doesn't have any useful information for you anyways you think to yourself.'");
                        Console.ReadKey(); Console.Clear();
                        TownChoices();
                        break;
                    }
                case "c":
                case "attack":
                    {
                        Console.WriteLine("You attack him for some reason. Little did you know, the old man was actually Harold the Wise! 'Should have studied the art of Python' he says");
                        Encounters.Combat(false, "Harold The Wise", 20, 50, false);
                        break;
                    }
                default:
                    Console.WriteLine("You do absolutely nothing. Harold is impressed");
                    Console.ReadKey(); Console.Clear();
                    TownChoices();
                    break;
            }
            Console.ReadKey(); Console.Clear();

        }
        //Options while in town
        public static void TownChoices()
        {
            Console.WriteLine("What will you do now?");
            Console.WriteLine("-------------------");
            Console.WriteLine("(s)hop   (c)hurch");
            Console.WriteLine("(a)sk    (l)eave");
            Console.WriteLine("-------------------");
            string choice = Console.ReadLine().ToLower();
            //switch to guide player to next method
            switch (choice)
            {
                case "s":
                case "shop":
                    Console.WriteLine("You enter the dingy shop in search of wares. Take a look at my collection says the shop owner");
                    Console.ReadKey(); Console.Clear();
                    Shop.shop();
                    break;
                case "c":
                case "church":
                    //This is to prevent the player from going to the church over and over again to exploit the health gain.
                    if (Program.currentPlayer.ChurchVisit == 0)
                    {
                        Console.WriteLine("You enter the church and speak to the priest. 'You must be in need of healing says the priest.'.");
                        Program.currentPlayer.Health += 5;
                        Program.currentPlayer.Maxhp = Program.currentPlayer.Health;
                        Console.WriteLine("You are now blessed");
                        Console.ReadKey(); Console.Clear();
                        Program.currentPlayer.ChurchVisit++;
                        TownChoices();
                        Console.ReadKey();Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Theres no point going back there.");
                        Console.ReadKey(); Console.Clear();
                        TownChoices();
                        Console.ReadKey(); Console.Clear();
                        break;
                    }
                    //Unreachable, but the break is necessary
                    break;
                case "a":
                case "ask":
                    Console.WriteLine("You ask around the town for Wise Harold, unfortunately he'll be back at 10");
                    Console.ReadKey(); Console.Clear();
                    TownChoices();
                    break;
                case "l":
                case "leave":
                    Console.WriteLine("Theres no point in dwindling around town so you make your way up north past the town. \nYou make your way into the woods.");
                    Console.ReadKey(); Console.Clear();
                    Woods.woods();
                    break;
                default:
                    Console.WriteLine("Enter a valid response");
                    Console.ReadKey(); Console.Clear();
                    TownChoices();
                    break;
            }
            
        }
    }
}
