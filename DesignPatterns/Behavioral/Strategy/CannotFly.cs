namespace DesignPatterns.Behavioral.Strategy
{
    public class CannotFly : IFliable
    {
        public bool Fly()
        {
            return false;
        }
    }

}
