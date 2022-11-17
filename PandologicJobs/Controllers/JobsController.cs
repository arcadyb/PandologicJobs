
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PandologicJobs.Models;
using PandologicJobs.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


namespace PandologicJobs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobsController : ControllerBase
    {
        private IDataAccessService _jobsRepo;
 
        private readonly ILogger<JobsController> _logger;

        public JobsController(
            IDataAccessService da,
            ILogger<JobsController> logger
            )
        {
            _jobsRepo = da;
            _logger = logger;
        }
        [HttpGet]
        public async Task<GChartDataTable> Get(int pageId)
        {
           // throw new HttpRequestException("test exception");
            try
            {
                var ret = await _jobsRepo.GetPageGobs(pageId);
                return ret;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);

                throw new HttpRequestException(ex.Message);
            }
        }
 
    }
}
