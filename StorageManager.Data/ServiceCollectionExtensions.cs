using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StorageManager.Data;
using StorageManager.Data.Repositories;

namespace RecipeNotebook.Data
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Enregistrer RecipeContext avec les options SQLite et initialiser la base de données avec des données de test
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddSMDataService(this IServiceCollection services)
        {
            services.AddDbContext<SMContext>(options =>
            {
                string uri = "server=localhost;database=storage_manager;user=admin;password=SQL12345";
                options.UseMySql(uri, ServerVersion.AutoDetect(uri));
            }
            // Utiliser Transient pour éviter les problèmes de scope dans winforms
            , ServiceLifetime.Transient
            );

            // Enregistrer les repositories
            services.AddTransient<StorageRepository>();

            return services;
        }

        /// <summary>
        /// Appliquer les migrations au démarrage
        /// </summary>
        /// <param name="services"></param>
        public static void ApplyMigrationsForSMDataService(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<SMContext>();
                var pendingMigrations = dbContext.Database.GetPendingMigrations();
                if (pendingMigrations.Any())
                {
                    dbContext.Database.Migrate();
                }
            }
        }
    }
}
