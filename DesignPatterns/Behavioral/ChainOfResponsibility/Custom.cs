using DesignPatterns.Data;
namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Custom : BaseHandler
    {
        public override bool Handle(Passenger request)
        {
            if (!request.hasAllowedGoods)
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
