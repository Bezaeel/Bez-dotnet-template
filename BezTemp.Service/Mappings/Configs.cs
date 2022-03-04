using AutoMapper;
using BezTemp.Data.Models;
using BezTemp.Service.Features.SampleFlow.Dtos;

namespace BezTemp.Service.Mappings
{
    public class Configs : Profile
    {
        public Configs()
        {
            CreateMap<Sample, SampleDTO>().ReverseMap();
        }
    }
}
