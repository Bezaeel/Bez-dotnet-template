using AutoMapper;
using BezTemp.Service.Features.SampleFlow;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BezTemp.API.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SampleController : ControllerBase
    {
        private readonly ISampleRequest _sampleRequest;
        private readonly IMapper _mapper;
        private readonly ILogger<SampleController> _logger;
        public SampleController(ISampleRequest sampleRequest, IMapper mapper, ILogger<SampleController> logger)
        {
            _sampleRequest = sampleRequest;
            _mapper = mapper;
            _logger = logger;
        }
    }
}