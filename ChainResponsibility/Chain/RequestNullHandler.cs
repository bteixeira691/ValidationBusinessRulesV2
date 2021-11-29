namespace ChainResponsibility.Chain
{
    public class RequestNullHandler : AbstractHandler
    {
        public override object Handler(object request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request), "Request cannot be null");

            return base.Handler(request);
        }
    }
}
