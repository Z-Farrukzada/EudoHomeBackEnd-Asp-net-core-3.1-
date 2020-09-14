using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string BlogWriteTime { get; set; }
        public string CommentCount { get; set; }
        
        public string Blogname { get; set; }
        public virtual ICollection<BlogAndTeacher> BlogAndTeachers { get; set; }
    }
}
