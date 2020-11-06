using System.Collections.Generic;
using covid19_api.Models;
using System.Threading.Tasks;
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
    }
}