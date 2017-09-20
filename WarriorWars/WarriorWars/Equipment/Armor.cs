using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
     class Armor
    {
        private int GoodGuyArmor = 5;
        private int BadGuyArmor = 5;


        private int armorPoints;
        
        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
        }

        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    armorPoints = GoodGuyArmor;

                    break;

                case Faction.BadGuy:
                    armorPoints = BadGuyArmor;

                    break;
                default:
                    break;
            }
        }
    }
}