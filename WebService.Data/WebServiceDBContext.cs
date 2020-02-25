using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebService;

namespace WebService.Data
{
    public class WebServiceDBContext : DbContext
    {
        private static readonly string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = WeatherForecaster";

        public WebServiceDBContext(DbContextOptions<WebServiceDBContext> options)
            : base(options)
        {

        }
        
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    }
}
