using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Models
{
    public class Logo
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        public string Facebook { get; set; }
        public string Pinterset { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
    }
}
