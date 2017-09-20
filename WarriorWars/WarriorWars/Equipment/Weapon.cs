using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Weapon
    {
        private const int GoodGuyDamage = 10;
        private const int BadGuyDamage = 10;

        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
            
        }

        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    damage = GoodGuyDamage;
                    break;
                case Faction.BadGuy:
                    damage = BadGuyDamage;
                    break;
                default:
                    break;
            }
        }
    }
}
