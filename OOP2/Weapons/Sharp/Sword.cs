using System;
namespace OOP2
{
    public class Sword
    {
        private int damage;

        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                if (value > 1 && value <= 10)
                {
                    this.damage = value;
                }
                else
                {
                    this.damage = 1;
                    Console.WriteLine("Please enter a number in the range of ( 1 - 10 )");
                }
            }
        }

        public Sword()
        {
            this.Damage = 10;
        }

        public void BloodThirst()
        {
            throw new NotImplementedException();
        }

      
    }
}
