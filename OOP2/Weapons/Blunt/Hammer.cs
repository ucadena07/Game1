using System;
namespace OOP2
{
    public class Hammer
    {
        private int damage;

        public int  Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value > 1 && value <= 10)
                {
                    this.damage = value;
                }
                else
                {
                    this.damage = 0;
                    Console.WriteLine("Please enter a number in the range of ( 1 - 10 )");
                }
            }
        }

        public Hammer()
        {
            this.Damage = 10;
        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
