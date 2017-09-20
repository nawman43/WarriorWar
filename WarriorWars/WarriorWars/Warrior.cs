using WarriorWars.Enum;
using WarriorWars.Equipment;
using System;
using System.Threading;

namespace WarriorWars
{
    class Warrior
    {
        private const int GoodGuyStartingHealth = 20;
        private const int BadGuyStartingHealth = 20;

        private readonly Faction FACTION;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }


        private Weapon weapon;
        private Armor armor;


        public Warrior(string name, Faction faction)
        {
            this.name = name;
            FACTION = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GoodGuyStartingHealth;

                    break;

                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BadGuyStartingHealth;

                    break;
                default:
                    break;
            }

        }

        public void Attack(Warrior enemy)
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoints;

            enemy.health = enemy.health - damage;

            if(enemy.health <= 0)
            {
                enemy.isAlive = false;
                Tools.ColorfulWriteLine($"{enemy.name} is dead!" , ConsoleColor.Red);
                Tools.ColorfulWriteLine($"{name} is victorious" , ConsoleColor.Green);
            }
            else
            {
                Console.WriteLine($"{name} attacked {enemy.name}. {damage} was inflicted to {enemy.name}, remaining health of {enemy.name} is {enemy.health}");
            }

            Thread.SpinWait(1);
        }
    }
}
