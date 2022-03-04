using System.ComponentModel.DataAnnotations;

namespace BezTemp.Service.Features.SampleFlow.Dtos
{
    public class SampleDTO
    {
        [Required(ErrorMessage ="fullname is required")]
        public string ConsumerFullName { get; set; }
        [Required(ErrorMessage ="address is required")]
        public string ConsumerAddress { get; set; }
    }
}
