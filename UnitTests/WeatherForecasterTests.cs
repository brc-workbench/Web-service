using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebService.Data;
using WebService.Services;

namespace UnitTests
{
    [TestClass]
    public class WeatherForecasterTests
    {
        [TestMethod]
        public void GenerateFiveRandomSummaries()
        {
            // Arrange
            var builder = new DbContextOptionsBuilder<WebServiceDBContext>();
            builder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = WeatherForecaster");

            using (var dbContext = new WebServiceDBContext(builder.Options))
            {
                var forecaster = new WeatherForecaster(dbContext);

                // Act
                var weatherSummaries = forecaster.WeatherSummaires();

                // Assert
                Assert.IsTrue(weatherSummaries.Length == 5);
            };
        }

        //[TestMethod]
        public void GetFiveSummariesFromDatabase()
        {
            // Arrange
            var builder = new DbContextOptionsBuilder<WebServiceDBContext>();
            builder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = WeatherForecaster");
            
            using (var dbContext = new WebServiceDBContext(builder.Options))
            {
                var forecaster = new WeatherForecaster(dbContext);

                // Act
                var weatherSummaries = forecaster.WeatherSummariesFromDatabase().Result;

                // Assert
                Assert.IsTrue(weatherSummaries.Count == 5);
            };
        }
    }
}
