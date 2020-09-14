using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Models
{
    public class BlogAndTeacher
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
