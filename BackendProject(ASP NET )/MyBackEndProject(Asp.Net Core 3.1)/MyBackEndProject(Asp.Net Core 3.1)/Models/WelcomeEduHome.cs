using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Models
{
    public class WelcomeEduHome
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
