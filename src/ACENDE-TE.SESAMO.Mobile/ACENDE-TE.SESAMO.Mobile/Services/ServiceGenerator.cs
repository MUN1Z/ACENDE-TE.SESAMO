using Refit;

namespace ACENDE_TE.SESAMO.Mobile.Services
{
    public class ServiceGenerator
    {
        public static IService GetService()
        {
            return RestService.For<IService>("http://192.168.43.13");
        }
    }
}
