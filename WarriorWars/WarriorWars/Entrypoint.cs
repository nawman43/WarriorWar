using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorWars.Enum;

namespace WarriorWars
{
    class Entrypoint
    {
        static Random rng = new Random();

        static void Main()
        {
            Warrior goodGuy = new Warrior("Link", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Ganon", Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0,10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
            }
        }
    }
}
