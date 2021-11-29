using ChainResponsibility.Model;

namespace ChainResponsibility.Chain
{
    public class ValidationLastnameHandler : AbstractHandler
    {
        public override object Handler(object request)
        {
          
            if ((request as ValidationRequest).Lastname == string.Empty)
            {
                (request as ValidationRequest).ErrorList.Add("Lastname is empty");
            }

            return base.Handler(request);

        }
    }
}
