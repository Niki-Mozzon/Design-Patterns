using DesignPatterns.Data;
namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public abstract class BaseHandler
    {
        protected BaseHandler _nextHandler;
        public BaseHandler SetNext(BaseHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        protected bool HasNext()
        {
            return _nextHandler is not null;
        }

        public abstract bool Handle(Passenger request);
        
    }
}
