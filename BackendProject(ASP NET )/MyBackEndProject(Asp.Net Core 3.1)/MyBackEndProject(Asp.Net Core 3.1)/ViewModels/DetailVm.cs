using MyBackEndProject_Asp.Net_Core_3._1_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.ViewModels
{
    public class DetailVm
    {
        public Course course { get; set; }
        public  List<Course> Courses { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
       
        public NewEvent newEvents { get; set; }

        public Teacher teacher { get; set; }
        public IEnumerable<Skills> Skills { get; set; }
        
        public Blog blog { get; set; }
      

        
    }
}
