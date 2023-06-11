﻿using Challenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Items
{
    class Potion : Item, IDrinkable
    {
        public int Drink()
        {
            return 5;
        }
        public override string ToString()
        {
            return "Potion";
        }
    }
}