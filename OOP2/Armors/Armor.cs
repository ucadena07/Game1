﻿using System;
namespace OOP2.Armors
{
    public abstract class Armor
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
                    this.armorPoints = value;
                }
                else
                {
                    this.armorPoints = 0;
                    Console.WriteLine("Plese enter a number in the range of 1 to 10");
                }
            }
        }
    }
}
