using System;
namespace OOP2
{
    public class Chainlink
    {
        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
            set
            {
                if (value > 0 && value <= 100)
                {
                    armorPoints = value;
                }
                else
                {
                    armorPoints = 0;
                    Console.WriteLine("Plese enter a number in the range of 1 to 10");
                }
            }
        }

        public Chainlink()
        {

        }
    }
}
