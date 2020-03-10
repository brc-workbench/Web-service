using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebService.Data;
using WebService.Services;

namespace WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeneralContactController : ControllerBase
    {
        private readonly ILogger<GeneralContactController> _logger;
        private readonly IGeneralContactsService _generalContactService;

        public GeneralContactController(IGeneralContactsService generalContactService, ILogger<GeneralContactController> logger)
        {
            _logger = logger;
            _generalContactService = generalContactService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<GeneralContact>>> Get()
        {
            _logger.LogInformation($"Begin GET/generalcontact @ {DateTime.Now}");

            // Retrieve a locally generated random set of data
            //var summaries = await _weatherService.WeatherSummairesAsync();

            // Retrieve a static set of data from SQL
            var summaries = await _generalContactService.GeneralContatsFromDatabase();

            _logger.LogInformation($"End GET/generalcontact @ {DateTime.Now}");

            return Ok(summaries);
        }
    }
}