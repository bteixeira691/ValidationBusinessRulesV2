using ChainResponsibility.Model;

namespace ChainResponsibility.Chain
{
    public class ValidationIdHandler : AbstractHandler
    {
        public override object Handler(object request)
        {

            if ((request as ValidationRequest).Id == Guid.Empty || (request as ValidationRequest).Id == null)
            {
                (request as ValidationRequest).ErrorList.Add("Name is empty");
            }

            return base.Handler(request);

        }
    }
}
