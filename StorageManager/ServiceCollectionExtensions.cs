using Microsoft.Extensions.DependencyInjection;
using StorageManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeNotebook
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterForms(this IServiceCollection services)
        {
            services.AddTransient<LoadingScreen>();
            //services.AddTransient<Dashboard>();
        }
    }
}
