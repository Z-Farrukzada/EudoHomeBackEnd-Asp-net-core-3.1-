using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Models
{
    public class NewEvent
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
   
        public string EventTime { get; set; }
        public string EventAbout { get; set; }
   
        public bool IsDeleted { get; set; }
     
        public string EventPlace { get; set; }
        
        public string EventStart { get; set; }
       
        public string EventFinish { get; set; }

        public virtual  ICollection<NewManagmentEvent> NewManagmentEvents{ get; set; }
        [NotMapped]
        [Required]
        public IFormFile PhotoEvent { get; set; }
    }
}
