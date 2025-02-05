﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class MaleFactory : IAnimalFactory
    {
        public IChicken CreateChicken()
        {
            return new MaleChicken();
        }

        public IDog CreateDog()
        {
            return new MaleDog();
        }
    }
}
