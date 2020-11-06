using System.Collections.Generic;
using covid19_api.Models;
using System.Threading.Tasks;
using covid19_api.Common.Constants;
using Flurl;
using Flurl.Http;
using Microsoft.Extensions.Configuration;

namespace covid19_api.Services
{
    public class CovidService : ICovidService
    {
        private readonly string _baseUrl;

        public CovidService(IConfiguration config)
        {
            _baseUrl = config["Covid19ApiUrl"];
        }

        public async Task<List<CovidStatus>> GetStatus()
        {
            return await _baseUrl
                .AppendPathSegment("status")
                .GetJsonAsync<List<CovidStatus>>();
        }

        public Task<List<CovidStatus>> GetStatusByCountry(string countryCode)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets the prediction by country asynchronous.
        /// </summary>
        /// <param name="countryCode">The country code.</param>
        /// <returns></returns>
        public async Task<IEnumerable<CovidPrediction>> GetPredictionByCountryAsync(string countryCode)
        {
            var url = _baseUrl
                .AppendPathSegment(RouteConstants.ByPrediction)
                .AppendPathSegment(countryCode);

            var result = await url.GetJsonAsync<List<CovidPrediction>>().ConfigureAwait(false);

            return result;
        }
    }
}