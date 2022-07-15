using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Factory
{
    //allows you to determine the class of something in runtime
    //basically the factory is just a class linked logically to one abstract class and you will use it to initialize the sublcasses
    public class FactoryMain
    {
        public static void Run()
        {

        AnimalFactory af = new AnimalFactory();
            Animal dog = af.CreateAnimal("Dog", 4);
            Animal chicken = af.CreateAnimal("Chicken", 2);
            Console.WriteLine(dog.Name+" is a "+dog.GetType());
            Console.WriteLine(chicken.Name+" is a "+chicken.GetType());
            //Animal error = af.CreateAnimal("Chicken", 3); would correctly throw an error
        }
        
    }
}
