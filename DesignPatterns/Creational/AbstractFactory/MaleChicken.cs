﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class MaleChicken : IChicken
    {
        public bool MakeEgg()
        {
            return false;
        }
    }
}
