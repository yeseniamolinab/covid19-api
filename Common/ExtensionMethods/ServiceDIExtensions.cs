using covid19_api.Services;
using Microsoft.Extensions.DependencyInjection;

namespace covid19_api.Common.ExtensionMethods
{
    public static class ServiceDIExtensions
    {
        public static void AddServicesDI(this IServiceCollection serviceProvider)
        {
            serviceProvider.AddTransient<ICovidService, CovidService>();
        }
    }
}
