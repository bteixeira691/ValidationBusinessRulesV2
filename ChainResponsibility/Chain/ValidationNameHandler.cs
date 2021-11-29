using ChainResponsibility.Model;

namespace ChainResponsibility.Chain
{
    public class ValidationNameHandler : AbstractHandler
    {
        public override object Handler(object request)
        {

            if ((request as ValidationRequest).Name == string.Empty)
            {
                (request as ValidationRequest).ErrorList.Add("Name is empty");
            }

            return base.Handler(request);

        }
    }
}
