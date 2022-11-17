using Microsoft.Extensions.Logging;
using Moq;
using PandologicJobs.Controllers;
using PandologicJobs.Models;
using PandologicJobs.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
    public class JobsControllerTest
    {
        JobsController _controller;
        private readonly Mock<IDataAccessService> _mockDataService;
        IDataAccessService _service;
        ILogger<DataAccessService> _loggerDa;
        ILogger<JobsController> _loggerJc;

        public JobsControllerTest()
        {
            //or use this short equivalent 
            _loggerJc = Mock.Of<ILogger<JobsController>>();
            _loggerDa = Mock.Of<ILogger<DataAccessService>>();
            _mockDataService = new Mock<IDataAccessService>();
            _service = new DataAccessService(_loggerDa);
            _controller = new JobsController(_mockDataService.Object, _loggerJc);

        }
        [Fact]
        public async Task GetJobsTestAsync()
        {
            _mockDataService.Setup(repo => repo.GetPageGobs(1))
                .Returns(Task.FromResult(new GChartDataTable() ));
            var result = await _controller.Get(1);
            //Assert

            Assert.IsType<GChartDataTable>(result);

        }
    }
}
