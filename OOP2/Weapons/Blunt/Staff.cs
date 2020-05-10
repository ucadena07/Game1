using System;
namespace OOP2
{
    public class Staff
    {
        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value > 1 && value <= 10)
                {
                    damage = value;
                }
                else
                {
                    Console.WriteLine("Please enter a number in the range of ( 1 - 10 )");
                }
            }
        }

        public Staff()
        {

        }
        public void Empower()
        {

        }
    }
}
