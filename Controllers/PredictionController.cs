using System.Collections.Generic;
using System.Threading.Tasks;
using covid19_api.Common.Constants;
using covid19_api.Models;
using covid19_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace covid19_api.Controllers
{
    [Route(ApiConstants.DefaultController)]
    public class PredictionController : BaseController
    {
        private readonly ICovidService _covidService;

        public PredictionController(ICovidService covidService)
        {
            _covidService = covidService;
        }

        /// <summary>
        /// Gets the specified country.
        /// </summary>
        /// <param name="country">The country.</param>
        /// <returns></returns>
        [HttpGet]
        [Route(RouteParamsConstants.Country)]
        public Task<IEnumerable<CovidPrediction>> Get([FromRoute] string country)
        {
            return _covidService.GetPredictionByCountryAsync(country);
        }
    }
}