using AutoMapper;
using BezTemp.Service.Features.SampleFlow;
using Moq;
using BezTemp.Service.Mappings;
using Microsoft.Extensions.Logging;

namespace BezTemp.Test
{
    public class SampleWorkflowUnitTests
    {
        private readonly IMapper mapper;
        private readonly Mock<ILogger<SampleRequest>> _logger;
        static Setup setup;

        public SampleWorkflowUnitTests()
        {
            setup = new Setup();
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new Configs());
            });
            mapper = mockMapper.CreateMapper();
            _logger = new Mock<ILogger<SampleRequest>>();
        }
    }

}