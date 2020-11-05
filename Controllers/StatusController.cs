using System.Collections.Generic;
using System.Threading.Tasks;
using covid19_api.Common.Constants;
using covid19_api.Models;
using covid19_api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace covid19_api.Controllers
{
    [Route(ApiConstants.DefaultController)]
    public class StatusController : ControllerFacade
    {
        private readonly ICovidService _covidService;

        public StatusController(ICovidService covidService)
        {
            _covidService = covidService;
        }

        /// <summary>
        /// Gets the statuses of covid.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public Task<IEnumerable<CovidStatus>> Get()
        {
            return _covidService.GetStatusAsync();
        }

        /// <summary>
        /// Gets the statuses of covid by specified country.
        /// </summary>
        /// <param name="country">The country.</param>
        /// <returns></returns>
        [HttpGet]
        [Route(ApiConstants.CountryParam)]
        public Task<IEnumerable<CovidStatus>> Get([FromRoute] string country)
        {
            return _covidService.GetStatusByCountryAsync(country);
        }
    }
}
