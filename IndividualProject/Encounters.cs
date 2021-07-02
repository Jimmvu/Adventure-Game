using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    class Encounters
    {
        static Random rand = new Random();

        //Encounter Tools
        public static void Combat(bool random, string name, int power, int health, bool escapeable)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {

            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while (h > 0)
            {
                Console.WriteLine(n);
                Console.WriteLine($"HP: {h}");
                Console.WriteLine("+++++++++++++++++++++++++++++");
                Console.WriteLine("| (A)ttack (D)efend  (auto) |");
                Console.WriteLine("|  (R)un    (H)eal          |");
                Console.WriteLine("+++++++++++++++++++++++++++++");
                Console.WriteLine(" Potions: " + Program.currentPlayer.Potions + " Health: " + Program.currentPlayer.Health+"/"+Program.currentPlayer.Maxhp);
                string input = Console.ReadLine().ToLower();
                if (input == "a" || input == "attack")
                {
                    //Attack / You attack / Enemy attack
                    Console.WriteLine($"You attack the {n} and it strikes you back");
                    int damage = p;
                    int attack = rand.Next(1, Program.currentPlayer.Damage);
                    Console.WriteLine("You lose " + damage + "health and deal " + attack + "damage");
                    Program.currentPlayer.Health -= damage;
                    h -= attack;
                    if (Program.currentPlayer.Health <= 0)
                    {

                        Console.WriteLine($"You have been slained by {n} Game Over!");
                        System.Environment.Exit(0);

                    }
                }
                else if (input == "d" || input == "defend")
                {
                    //Defend / Enemy attack
                    Console.WriteLine("You defend.");
                    int damage = (p / 2);
                    Console.WriteLine($"You lose {damage} health");
                    Program.currentPlayer.Health -= damage;
                }
                else if (input == "r" || input == "run")
                {
                    //Run, if true the battle is escapeable, otherwise it is not
                    if (escapeable == true)
                    {
                        // fail to run / Enemy attack
                        if (rand.Next(0, 2) == 0)
                        {
                            Console.WriteLine("You fail to run away");
                            int damage = p;
                            Console.WriteLine("You lose " + damage + "health and are unable to escape");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("You escape!");
                            Console.ReadKey();
                            break;

                        }
                    }
                    if (escapeable == false)
                    {
                        Console.WriteLine("You fail to run away");
                        int damage = p;
                        Console.WriteLine("You lose " + damage + "health and are unable to escape");
                        Console.ReadKey();
                    }
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //Heal
                    if (Program.currentPlayer.Potions == 0)
                    {
                        int damage = p;
                        Console.WriteLine("You have no more potions");
                        Console.WriteLine($"The enemy strikes and you take {damage} damage!");
                        Program.currentPlayer.Health -= damage;
                    }
                    else
                    {
                        //This is to ensure that the player cannot overheal
                        Console.WriteLine("You take a chug of your potions.");
                        int potionv = 5;
                        Console.WriteLine("You gain " + potionv + " health");
                        Program.currentPlayer.Health += potionv;
                        if (Program.currentPlayer.Health >= Program.currentPlayer.Maxhp)
                        {
                            Program.currentPlayer.Health = Program.currentPlayer.Maxhp;
                        }
                    }
                    Console.ReadKey();
                }
                //auto battler
                else if (input.ToLower() == "auto")
                {
                    while (h > 0)
                    {
                        Console.WriteLine($"You attack the {n} and it strikes you back");
                        int damage = p;
                        int attack = rand.Next(1, Program.currentPlayer.Damage);
                        Console.WriteLine("You lose " + damage + "health and deal " + attack + "damage");
                        Program.currentPlayer.Health -= damage;
                        h -= attack;
                        if (Program.currentPlayer.Health <= 0)
                        {

                            Console.WriteLine($"You have been slained by {n} Game Over!");
                            System.Environment.Exit(0);

                        }
                    }
                    Console.WriteLine($"You have {Program.currentPlayer.Health} hp remaining");
                }
                else
                {
                    Console.WriteLine("Enter a valid response");
                }
                Console.ReadKey();
            }
            Console.WriteLine($"You have slained the {n}.");
            Console.ReadKey(); Console.Clear();
        }

    }
}
