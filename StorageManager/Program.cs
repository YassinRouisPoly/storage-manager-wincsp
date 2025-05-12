using DevExpress.Mvvm.POCO;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using RecipeNotebook;
using RecipeNotebook.Data;
using StorageManager.Data.Entities;
using StorageManager.Data.Repositories;
using StorageManager.Data.Services;

namespace StorageManager
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            services.AddSMDataService();
            services.ApplyMigrationsForSMDataService();

            services.RegisterServices();
            services.RegisterRepositories();
            services.RegisterForms();

            ServiceProvider = services.BuildServiceProvider();

            var splash = ServiceProvider.GetRequiredService<DashboardScreen>();

            var backupService = ServiceProvider.GetRequiredService<BackupService>();
            var timer = new System.Timers.Timer(TimeSpan.FromDays(1).TotalMilliseconds);
            timer.Elapsed += (sender, e) => backupService.CreateBackup();
            timer.Start();

            Application.Run(splash);
        }

        public static void RegisterForms(this IServiceCollection services)
        {
            services.AddTransient<LoadingScreen>();
            services.AddTransient<LoginScreen>();
            services.AddTransient<DashboardScreen>();
        }

        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<AuthenticationService>();
            services.AddSingleton<LoggingService>();
            services.AddSingleton<BackupService>();
        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddSingleton<CategoriesRepository>();
            services.AddSingleton<ReferencesRepository>();
            services.AddSingleton<UsersRepository>();
        }
    }
}