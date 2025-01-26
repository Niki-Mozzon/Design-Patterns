
namespace DesignPatterns.Creational.Factory
{
    public class Factory
    {
        public Animal CreateAnimal(int legs)
        {
            switch (legs)
            {
                case 2:
                    return new Biped(legs);
                case 4:
                    return new Quadruped(legs);
                default:
                    throw new Exception();
            }
        }
    }
}
