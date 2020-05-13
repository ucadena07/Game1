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
            
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
            
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Score = 0;
        }

        public int ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public override int Attack()
        {
            return this.Fireball();
        }

        public override int Defend()
        {
            return this.Meditation();
        }

        public int Fireball()
        {
            return base.Weapon.Damage + 10;
        }

        public int Meditation()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int SpecialAttack()
        {
            return this.ArcaneWrath();
        }
    }
}
