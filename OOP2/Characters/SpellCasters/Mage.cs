using System;
using OOP2.Characters.Enumerations;
using OOP2.Characters.SpellCasters;

namespace OOP2
{
    public class Mage : Spellcaster
    {
        private const string DEFAULT_NAME = "Mage";
        private const Factions DEFAULT_FACTION = Factions.Spellcaster;

        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_MANA_POINTS = 20;
        private const int DEFAULT_HEALTH_POINTS = 100;

        private readonly Staff DEFAULT_WEAPON = new Staff();
        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();

        private ClothRobe bodyArmor;
        private Staff weapon;

        public ClothRobe BodyArmor
        {
            get
            {
                return bodyArmor;
            }
            set
            {
                bodyArmor = value;
            }
        }
        public Staff Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }

        public Mage()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
           
        }

        public Mage(string name, int level)
            : this(name, level, DEFAULT_MANA_POINTS)
        {
          
        }
        public Mage(string name, int level, int manaPoints)
            : base(name, level, manaPoints)
        {
            
            this.HealthPoints = DEFAULT_HEALTH_POINTS;
            this.Faction = DEFAULT_FACTION;
            
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public void FireWall()
        {
            throw new NotImplementedException();
        }

        public void Meditation()
        {
            throw new NotImplementedException();
        }
    }
}
