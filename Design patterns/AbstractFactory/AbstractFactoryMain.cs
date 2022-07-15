using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.AbstractFactory
{
    public class AbstractFactoryMain
    {
        public static void Run()
        {
            IAnimalFactory factory;
            IAnimal animal;

            Console.WriteLine("Insert the gender: M/F");
            string res = Console.ReadLine();
            if (res == "M")
            {
                factory = new MaleFactory();
            }
            else if (res == "F")
            {
                factory = new FemaleFactory();
            }
            else
            {
                throw new Exception();
            }
            Console.WriteLine("Insert the animal:");
            res = Console.ReadLine();

            if (res == "Chicken")
            {
                animal = factory.CreateChicken();
            }
            else if (res == "Dog")
            {
                animal = factory.CreateDog();
            }
            else
            {
                throw new Exception();
            }
            Console.WriteLine(animal.GetType());





        }
    }
}
