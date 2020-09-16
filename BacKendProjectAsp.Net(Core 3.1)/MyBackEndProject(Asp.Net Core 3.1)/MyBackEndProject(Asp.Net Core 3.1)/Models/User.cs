
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Models
{
    public class User:IdentityUser
    {
       
        public string FullName { get; set; }
        public bool Studentoreacher { get; set; }
        public bool IsActivated { get; set; }

        public string UserThoughts { get; set; }
        public virtual ICollection<UserCourses> UserCourses { get; set; }
    }
}
