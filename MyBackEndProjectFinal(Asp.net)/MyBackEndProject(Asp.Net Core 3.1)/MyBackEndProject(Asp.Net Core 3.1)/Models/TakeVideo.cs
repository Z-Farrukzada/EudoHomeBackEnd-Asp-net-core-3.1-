using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Models
{
    public class TakeVideo
    {
        public int Id { get; set; }

        [Required]
       
        public string Video { get; set; }
        public string Title { get; set; }
    }
}
