using DesignPatterns.Creational.Command.Data;

namespace DesignPatterns.Creational.Command
{
    public class Gardener : ICommand
    {
        public EAction Execute()
        {
            return EAction.MowLawn;
        }
    }

}
