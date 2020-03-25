// <copyright file="WebServiceDBContext.cs" company="Event UK">
// This source code is Copyright © Event UK and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Event UK
// </copyright>

namespace WebService.Data
{
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// DB Context for application.
    /// </summary>
    public class WebServiceDBContext : DbContext
    {
        // private static readonly string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = WeatherForecaster";

        /// <summary>
        /// Initializes a new instance of the <see cref="WebServiceDBContext"/> class.
        /// </summary>
        /// <param name="options">Options for DBContext defined in Startup.cs file.</param>
        public WebServiceDBContext(DbContextOptions<WebServiceDBContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets a list of forecasts.
        /// </summary>
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        /// <summary>
        /// Gets or sets a list of contacts.
        /// </summary>
        public DbSet<GeneralContact> GeneralContacts { get; set; }
    }
}
