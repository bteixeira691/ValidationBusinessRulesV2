using ChainResponsibility.Interface;

namespace ChainResponsibility.Chain
{
    public class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual object Handler(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handler(request);
            }
            else
            {
                return null;
            }
        }
    }
}
