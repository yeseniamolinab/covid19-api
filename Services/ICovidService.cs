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
        Task<IEnumerable<CovidStatus>> GetStatusAsync();

        Task<IEnumerable<CovidStatus>> GetStatusByCountryAsync(string countryCode);

        Task<IEnumerable<CovidPrediction>> GetPredictionByCountryAsync(string countryCode);
    }
}