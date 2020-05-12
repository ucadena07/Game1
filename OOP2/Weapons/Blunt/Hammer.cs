using System;
using OOP2.Weapons.Blunt;

namespace OOP2
{
    public class Hammer : Blunt
    {
       
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
