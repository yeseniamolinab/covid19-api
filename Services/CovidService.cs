using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// Gets the status asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CovidStatus>> GetStatusAsync()
        {
            var url = _baseUrl.AppendPathSegment(RouteConstants.ByStatus);
            var result = await url.GetJsonAsync<List<CovidStatus>>().ConfigureAwait(false);

            return result;
        }

        /// <summary>
        /// Gets the status by country asynchronous.
        /// </summary>
        /// <param name="countryCode">The country code.</param>
        /// <returns></returns>
        public async Task<IEnumerable<CovidStatus>> GetStatusByCountryAsync(string countryCode)
        {
            var query = await _baseUrl
                .AppendPathSegment(RouteConstants.ByStatus)
                .GetJsonAsync<List<CovidStatus>>()
                .ConfigureAwait(false);

            query = query.Where(p => p.Country.Equals(countryCode.ToUpper())).ToList();

            return query;
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
                .AppendPathSegment(countryCode.ToUpper());

            var result = await url.GetJsonAsync<List<CovidPrediction>>().ConfigureAwait(false);

            return result;
        }
    }
}