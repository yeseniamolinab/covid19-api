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
    public class StatusController : ControllerBase
    {
        private readonly ICovidService _covidService;

        public StatusController(ICovidService covidService)
        {
            _covidService = covidService;
        }

        [HttpGet]
        public async Task<IEnumerable<CovidStatus>> Get()
        {
            return await _covidService.GetStatus();
        }
    }
}