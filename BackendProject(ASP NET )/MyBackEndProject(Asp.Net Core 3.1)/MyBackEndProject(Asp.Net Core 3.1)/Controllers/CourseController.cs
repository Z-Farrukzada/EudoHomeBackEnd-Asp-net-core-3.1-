using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;
using MyBackEndProject_Asp.Net_Core_3._1_.ViewModels;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbcontext _db;
        public CourseController(AppDbcontext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.CourseCount = _db.Courses.Count();
            ViewBag.Banner = _db.Banners.Skip(1).Take(1);
            return View();
        }
        public IActionResult Load(int count)
        {
            
                if (count >= _db.Courses.Count())
                {
                    return Content("Bu qeder melumat yoxdur");
                }

                IEnumerable<Course> course = _db.Courses.Skip(count).Take(9);
                return PartialView("_CoursePartial", course);
           

             

        }
        public  IActionResult Detail(int? Id)
        {
            if (Id == null) return NotFound();
            ViewBag.Banner = _db.Banners.Skip(6).Take(1);


            DetailVm courseDetail = new DetailVm
            {
                course = _db.Courses.Where(c => c.Id == Id).FirstOrDefault(),
                Courses = _db.Courses.Include(c=>c.Categories).Take(6).ToList(),
                Blogs=_db.Blogs.Take(3).ToList()

            };
            return View(courseDetail);
        }
      
    }
}