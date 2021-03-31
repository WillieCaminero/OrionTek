using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;

namespace OrionTek.Domain.Utils
{
    public class AppSetting
    {
        /// <summary>
        /// Obtiene la configuracion desde el archivo de configuracion
        /// </summary>
        /// <returns></returns>
        public static IConfiguration Configuration { get; set; }

        public static void Configure(IHostEnvironment env)
        {
            string environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            // Read the appsetting.json file for the configuration details
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                .AddJsonFile($"appsettings.{environmentName}.json", optional: true, reloadOnChange: false);

            Configuration = builder.Build();
        }
    }
}
