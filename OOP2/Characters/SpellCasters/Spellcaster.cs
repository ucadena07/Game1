using System;
namespace OOP2.Characters.SpellCasters
{
    public abstract class Spellcaster : Character
    {
        private int manaPoints;

        public int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.manaPoints = value;
                }
                else
                {
                    this.manaPoints = 0;
                    Console.WriteLine("Please enter a number in the range of 0 to 10");
                }
            }
        }

        public Spellcaster(string name, int level, int abilityPoints)
            : base(name, level)
        {

            base.Name = name;
            base.Level = level;
            this.ManaPoints = manaPoints;
        }
    }
}
