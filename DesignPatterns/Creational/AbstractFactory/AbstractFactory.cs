namespace DesignPatterns.Creational.AbstractFactory
{
    public class AbstractFactory
    {
        public IAnimal CreateAnimal(char gender, string type)
        {
            IAnimalFactory factory;
            IAnimal animal;

            if (gender == 'M')
            {
                factory = new MaleFactory();
            }
            else if (gender == 'F')
            {
                factory = new FemaleFactory();
            }
            else
            {
                throw new Exception();
            }
            if (type == "Chicken")
            {
                animal = factory.CreateChicken();
            }
            else if (type == "Dog")
            {
                animal = factory.CreateDog();
            }
            else
            {
                throw new Exception();
            }
            return animal;
        }
    }
}
