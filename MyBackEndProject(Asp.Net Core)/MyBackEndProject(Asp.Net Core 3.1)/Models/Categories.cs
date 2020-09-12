using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
