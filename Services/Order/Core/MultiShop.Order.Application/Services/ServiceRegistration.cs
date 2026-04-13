using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace MultiShop.Order.Application.Services
{
    public static class ServiceRegistration
    {
        public static void AddApplicationService(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
                cfg.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly));
        }
    }
}