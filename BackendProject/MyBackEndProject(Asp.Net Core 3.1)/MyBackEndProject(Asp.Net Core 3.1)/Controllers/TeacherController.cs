using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;
using MyBackEndProject_Asp.Net_Core_3._1_.ViewModels;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _db;
        public TeacherController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.TeacherCount = _db.Teachers.Count();
            ViewBag.Banner = _db.Banners.Skip(3).Take(1);
        
           
            return View();
        }
        public IActionResult Load(int count)
        {
            if (count >= _db.Teachers.Count())
            {
                return Content("Bu qeder melumat yoxdur");
            }
            IEnumerable<Teacher> teacher = _db.Teachers.Skip(count).Take(9);
            return PartialView("_TeacherPartial", teacher);
        }
        public IActionResult  Detail(int? Id)
        {
            if (Id == null) return NotFound();
            ViewBag.Banner = _db.Banners.Skip(8).Take(1);


            Teacher teacher = _db.Teachers.Where(t => t.Id == Id).Include(s => s.Skills).FirstOrDefault();
                
           
           
            return View(teacher);
        }
    }
}