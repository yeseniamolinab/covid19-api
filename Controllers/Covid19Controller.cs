using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using covid19_api.Models;
using covid19_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace covid19_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Covid19Controller : ControllerBase
    {
        private readonly ICovidService _covidService;

        public Covid19Controller(ICovidService covidService)
        {
            _covidService = covidService;
        }
        
        [HttpGet]
        [Route("status")]
        public async Task<IEnumerable<CovidStatus>> GetStatus()
        {
            return await _covidService.GetStatus();
        }
    }
}