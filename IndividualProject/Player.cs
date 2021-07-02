using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    class Player
    {

        private string name;
        private int health = 20, maxhp = 20, damage = 5, potions = 2, gold = 10, churchVisit = 0;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public int Maxhp
        {
            get { return maxhp; }
            set { maxhp = value; }
        }
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public int Potions
        {
            get { return potions; }
            set { potions = value; }
        }
        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }
        public int ChurchVisit
        {
            get { return churchVisit; }
            set { churchVisit = value; }
        }


        //public string name;
        //public int health, maxhp, damage, potions, gold, churchVisit;
        //public Player()
        //{
        //    this.name = "";
        //    this.health = 20;
        //    this.maxhp = 20;
        //    this.damage = 2;
        //    this.potions = 2;
        //    this.gold = 10;
        //    this.churchVisit = 0;
        //}
        //public string name;
        //public int health = 20;
        //public int maxhp;
        //public int damage = 2;
        //public int potions = 2;
        //public int gold = 10;
        //public int churchVisit = 0;
    }
   
}
