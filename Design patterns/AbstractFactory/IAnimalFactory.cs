using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.AbstractFactory
{
    internal interface IAnimalFactory
    {

        IDog CreateDog();
        IChicken CreateChicken();


    }
}
