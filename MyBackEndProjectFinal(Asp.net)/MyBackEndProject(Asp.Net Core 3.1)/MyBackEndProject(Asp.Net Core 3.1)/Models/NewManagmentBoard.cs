using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Models
{
    public class NewManagmentBoard
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        
        public string Surname { get; set; }
        public string Position { get; set; }
        [Required]
        public string Image { get; set; }
        
        public virtual ICollection<NewManagmentEvent> NewManagmentEvents { get; set; }
        [NotMapped]
        [Required]
        public IFormFile PhotoSpeaker { get; set; }


    }
}
