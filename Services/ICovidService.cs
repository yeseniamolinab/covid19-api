using System.Collections.Generic;
using System.Threading.Tasks;
using covid19_api.Models;

namespace covid19_api.Services
{
    public interface ICovidService
    {
        Task<List<CovidStatus>> GetStatus();

        Task<List<CovidStatus>> GetStatusByCountry(string countryCode);

        Task<List<CovidPrediction>> GetPredictionByCountry(string countryCode);
    }
}