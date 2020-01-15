using Microsoft.Extensions.DependencyInjection;

namespace TaxiPriceCalculator
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ISpeedMonitorProvider, SpeedMonitorProvider>();
//            services.AddTransient<IOperationTransient, Operation>();
//            services.AddScoped<IOperationScoped, Operation>();
//            services.AddSingleton<IOperationSingleton, Operation>();
//            services.AddSingleton<IOperationSingletonInstance>(new Operation(Guid.Empty));
//
//            // OperationService depends on each of the other Operation types.
//            services.AddTransient<OperationService, OperationService>();
        }
    }
}