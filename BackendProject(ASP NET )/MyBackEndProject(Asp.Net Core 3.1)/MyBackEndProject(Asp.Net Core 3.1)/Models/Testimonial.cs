using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
       
        [Required]
        public string BackgroundImage { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }
        [MaxLength(50)]
        public string Job { get; set; }
        public string CourseName { get; set; }
    }
}
