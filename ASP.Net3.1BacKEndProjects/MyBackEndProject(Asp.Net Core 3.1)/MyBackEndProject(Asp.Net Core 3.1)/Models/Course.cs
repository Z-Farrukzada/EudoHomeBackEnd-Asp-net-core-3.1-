using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string CourseName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public string ClassDuration { get; set; }
        [Required]
        public string SkillLevel { get; set; }
        [Required]
        public string Language { get; set; }
        [Required]
        public int StudentCapacity { get; set; }
        [Required]
        public string Assetsments { get; set; }
        [Required]
        public double CoursePrice { get; set; }
        [Required]
        public string StartCourse { get; set; }
        public string AboutCourse { get; set; }
        public string HowDoApply { get; set; }
        public string Certification { get; set;  }
        public int CategoriesId { get; set; }
        public Categories Categories { get; set; }
        public virtual ICollection<UserCourses> UserCourses { get; set; }
    }
}
