using DesignPatterns.Data;
namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public class Gate : BaseHandler
{
    public override bool Handle(Passenger request)
    {
        if (!request.hasTicket)
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
