using System.Collections.Generic;
using System.Threading.Tasks;
using covid19_api.Models;

namespace covid19_api.Services
{
    /// <summary>
    /// Contract for the covid api
    /// </summary>
    public interface ICovidService
    {
        Task<List<CovidStatus>> GetStatus();

        Task<List<CovidStatus>> GetStatusByCountry(string countryCode);

        Task<IEnumerable<CovidPrediction>> GetPredictionByCountryAsync(string countryCode);
    }
}