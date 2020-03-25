// <copyright file="GeneralContactController.cs" company="Event UK">
// This source code is Copyright © Event UK and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Event UK
// </copyright>

namespace WebService.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using WebService.Data;
    using WebService.Services;

    /// <summary>
    /// API for GeneralContact.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class GeneralContactController : ControllerBase
    {
        private readonly ILogger<GeneralContactController> _logger;
        private readonly IGeneralContactsService _generalContactService;

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralContactController"/> class.
        /// </summary>
        /// <param name="generalContactService">Service for data access.</param>
        /// <param name="logger">Default logger.</param>
        public GeneralContactController(IGeneralContactsService generalContactService, ILogger<GeneralContactController> logger)
        {
            _logger = logger;
            _generalContactService = generalContactService;
        }

        /// <summary>
        /// GET for all GeneralContact records.
        /// </summary>
        /// <returns>All contact records.</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<GeneralContact>>> Get()
        {
            _logger.LogInformation($"Begin GET/generalcontact @ {DateTime.Now}");

            // Retrieve a locally generated random set of data
            // var summaries = await _weatherService.WeatherSummairesAsync();

            // Retrieve a static set of data from SQL
            var summaries = await _generalContactService.GeneralContatsFromDatabase();

            _logger.LogInformation($"End GET/generalcontact @ {DateTime.Now}");

            return Ok(summaries);
        }
    }
}
