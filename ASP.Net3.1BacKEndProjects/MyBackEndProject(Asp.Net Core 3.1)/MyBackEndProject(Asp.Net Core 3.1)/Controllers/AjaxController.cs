using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Controllers
{
    public class AjaxController : Controller
    {
        
        public readonly AppDbcontext _db;

        public AjaxController(AppDbcontext db)
        {
            _db = db;
        }

        public IActionResult Search(string search,string hidden)
        {
           

            if (hidden == "course")
            {
                IEnumerable<Course> list = new List<Course>();
                list = _db.Courses.Where(x => x.CourseName.Contains(search))
                     .OrderByDescending(c => c.Id).Take(10);
                return Ok(list);
            }
            else if (hidden == "event")
            {
                IEnumerable<NewEvent> listevent = new List<NewEvent>();
                listevent = _db.NewEvents.Where(e => e.Name.Contains(search))
                    .OrderByDescending(c => c.Id).Take(10);
                return Ok(listevent);
            }
            else if (hidden == "teacher")
            {
                IEnumerable<Teacher> listteacher = new List<Teacher>();
                listteacher = _db.Teachers.Where(x => x.Name.Contains(search))
                     .OrderByDescending(c => c.Id).Take(10);
                return Ok(listteacher);
            }else if (hidden == "blog")
            {
                IEnumerable<Blog> listblog = new List<Blog>();
                listblog = _db.Blogs.Where(x => x.Blogname.Contains(search))
                     .OrderByDescending(c => c.Id).Take(10);
                return Ok(listblog);
            }

            return View();

        }
    }
}