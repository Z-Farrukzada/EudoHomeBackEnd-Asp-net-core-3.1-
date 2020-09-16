

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.DAL
{
    public class AppDbcontext : IdentityDbContext<User>
    {

        public AppDbcontext(DbContextOptions<AppDbcontext> options):base(options)
        {

        }

    
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
        public DbSet<NoticeProfession> NoticeProfessions { get; set; }
        public DbSet<EudoHomeChoose> EudoHomeChooses { get; set; }
        public DbSet<Logo> Logos { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<NewEvent> NewEvents { get; set; }
        public DbSet<NewManagmentBoard> NewManagmentBoards { get; set; }
        public DbSet<NewManagmentEvent> NewManagmentEvents { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogAndTeacher> BlogAndTeachers { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<WelcomeEduHome> WelcomeEduHomes { get; set; }

        public DbSet<TakeVideo> TakeVideos { get; set; }

        public DbSet<User> users { get; set; }
        public DbSet<UserCourses> userCourses { get; set; }

    }
 }
