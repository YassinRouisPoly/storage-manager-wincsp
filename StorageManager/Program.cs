using Microsoft.Extensions.DependencyInjection;
using RecipeNotebook;
using RecipeNotebook.Data;

namespace StorageManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.Run(new LoadingScreen());
        }
    }
}