using System;
using OOP2.Weapons.Sharp;

namespace OOP2
{
    public class Axe : Sharp
    {

        public Axe()
        {
            base.Damage = 10;
        }

        public void HackSlash()
        {
            throw new NotImplementedException();
        }
    }
}
