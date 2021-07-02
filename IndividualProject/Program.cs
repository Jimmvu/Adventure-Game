using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    class Program
    {
        //Creating a new player object
        public static Player currentPlayer = new Player();
        
        static void Main(string[] args)
        {
            //To keep the Main method short and concise, the only purpose is to call the first method Start()
            Start();
        }
        public static void Start()
        {
            Console.WriteLine("Welcome to Vu's Quest!");
            Console.WriteLine("Name: ");
            //The player's name is set to be equal to the user input. If they don't enter a name then name = unknown
            currentPlayer.Name = Console.ReadLine();
            if (currentPlayer.Name == "")
            {
                currentPlayer.Name = "Unknown";
                
            }
            Console.Clear();
            Console.WriteLine($"Welcome {currentPlayer.Name}! King Vu has tasked you to slay the dragon at the abandoned castle north of the town.");
            Console.ReadKey();
            Console.Clear();
            Town.town();
            currentPlayer.Maxhp = currentPlayer.Health;
        }
    }
}
