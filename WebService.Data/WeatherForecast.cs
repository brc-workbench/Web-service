// <copyright file="WeatherForecast.cs" company="Event UK">
// This source code is Copyright © Event UK and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Event UK
// </copyright>

namespace WebService.Data
{
    using System;

    /// <summary>
    /// Sample class to demonstrate EF code first object definitions.
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Gets or sets the Record PK.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the date of the forecast.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the C temp.
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Gets the F temp calculated from the C temp.
        /// </summary>
        public int TemperatureF => 32 + (int)(this.TemperatureC / 0.5556);

        /// <summary>
        /// Gets or sets the weather summary.
        /// </summary>
        public string Summary { get; set; }
    }
}
