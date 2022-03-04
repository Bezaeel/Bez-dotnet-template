using AutoMapper;
using BezTemp.Data.IRepositories;
using BezTemp.Service.Communication;
using Microsoft.Extensions.Logging;

namespace BezTemp.Service.Features.SampleFlow
{
    public class SampleRequest : ISampleRequest
    {
        private readonly ISampleRepository _sampleRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<SampleRequest> _logger;
        private ServiceResponse apiResponse;

        public SampleRequest(ISampleRepository sampleRepository, IMapper mapper, ILogger<SampleRequest> logger)
        {
            _sampleRepository = sampleRepository;
            _mapper = mapper;
            _logger = logger;
            apiResponse = new ServiceResponse();
        }
    }
}
