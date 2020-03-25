// <copyright file="Program.cs" company="Event UK">
// This source code is Copyright © Event UK and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Event UK
// </copyright>

namespace WebService
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;

    /// <summary>
    /// Program class that serves as the applications main entry point.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main entry point of application.
        /// </summary>
        /// <param name="args">Arguments passed in from the command line.</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Configure IHostBuilder.
        /// </summary>
        /// <param name="args">Default arguments.</param>
        /// <returns>The configured IHostBuilder object.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
