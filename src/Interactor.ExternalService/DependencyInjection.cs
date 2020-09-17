using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interactor.ExternalService
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddExternalService(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
