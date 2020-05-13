using System;
using OOP2.Weapons.Sharp;

namespace OOP2
{
    public class Sword : Sharp
    {
     
        public Sword()
        {
            base.Damage = 10;
        }

        public void BloodThirst()
        {
            throw new NotImplementedException();
        }

      
    }
}
