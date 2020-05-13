using System;
namespace OOP2.Characters.Melees
{
    public abstract class Melee : Character
    {
        private int abilityPoints;

        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    this.abilityPoints = 0;
                    Console.WriteLine("Please enter a number in the range of 0 to 10");
                }
            }
        }

        public Melee(string name, int level, int abilityPoints)
            : base(name, level)
        {

            base.Name = name;
            base.Level = level;
            this.AbilityPoints = abilityPoints;
        }
    }
}
