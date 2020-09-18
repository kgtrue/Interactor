using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interactor.SearchService.Solr
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSearch(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
