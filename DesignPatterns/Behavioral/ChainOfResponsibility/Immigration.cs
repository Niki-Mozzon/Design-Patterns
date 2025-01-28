using DesignPatterns.Data;
namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Immigration : BaseHandler
    {
        public override bool Handle(Passenger request)
        {
            if (!request.hasPassport)
            {
                return false;
            }
            else if (HasNext())
            {
                return _nextHandler.Handle(request);
            }
                return true;
        }
    }
}
