﻿using System;
using OOP2.Weapons.Blunt;

namespace OOP2
{
    public class Staff : Blunt
    {
       
        public Staff()
        {
            base.Damage = 10;
        }
        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
