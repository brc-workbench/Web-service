using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebService.Models;

namespace UnitTests
{
    [TestClass]
    public class WeatherForecasterTests
    {
        [TestMethod]
        public void GetFiveSummaries()
        {
            // Arrange
            var forecaster = new WeatherForecaster();

            // Act
            var weatherSummaries = forecaster.WeatherSummaires();

            // Assert
            Assert.IsTrue(weatherSummaries.Length == 5);
        }
    }
}
