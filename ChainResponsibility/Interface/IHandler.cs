using ChainResponsibility.Model;

namespace ChainResponsibility.Interface
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object Handler(object request);
    }
}
