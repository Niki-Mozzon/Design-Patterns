using DesignPatterns.Data;

namespace DesignPatterns.Behavioral.Command
{
	public class Gardener : ICommand
    {
        public EAction Execute()
        {
            return EAction.MowLawn;
        }
    }

}
