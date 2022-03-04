using System;
using System.ComponentModel.DataAnnotations;
using BezTemp.Data.Models;

namespace BezTemp.Data.Models
{
    public class Sample : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string ConsumerFullname { get; set; }
        public string ConsumerAddress { get; set; }
    }
}