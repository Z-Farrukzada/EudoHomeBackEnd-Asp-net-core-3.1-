using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Connections.Features;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.Extensions;
using MyBackEndProject_Asp.Net_Core_3._1_.Helpers;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CourseController : Controller
    {
        private readonly AppDbcontext _db;
        private readonly IWebHostEnvironment _env;

        public CourseController(AppDbcontext db,IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Course> Courselist = _db.Courses.ToList();
            return View(Courselist);
        }

        public async  Task<IActionResult> Delete(int? Id)
        {
            if (Id == null) return NotFound();
            Course delCourse = _db.Courses.FirstOrDefault(c => c.Id == Id);
            if (delCourse == null) return NotFound();
            _db.Courses.Remove(delCourse);

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            
            
        }
        public IActionResult Detail(int? Id)
        {
            if (Id == null) return NotFound();
            Course courseDetail = _db.Courses.FirstOrDefault(m=>m.Id==Id);
            if (courseDetail == null) return NotFound();
            return View(courseDetail);

        }
        public IActionResult Create()
        {
            ViewBag.CourseUser = _db.Users.Where(c => c.UserThoughts == "Student").ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Course course ,string userId)
        {
            ViewBag.CourseUser = _db.Users.Where(c => c.UserThoughts == "Student").ToList();
            if (ModelState.IsValid)
            {
                return View();
            }
          
            if (ModelState["PhotoCourse"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (!course.PhotoCourse.IsImage())
            {
                ModelState.AddModelError("PhotoCourse", "Sekil fayli daxil edin");
                return View();
            }
            if (course.PhotoCourse.MaxLength(300))
            {
                ModelState.AddModelError("PhotoCourse", "Seklin olcusu 300kb-dan boyuk olmamalidir");
                return View();
            }

            string newfolder = Path.Combine("img", "course");
            string FileName = await course.PhotoCourse.SaveImage(_env.WebRootPath, newfolder);
            course.Image = FileName;

            List<UserCourses> usercourses = new List<UserCourses>();
         
            usercourses.Add(new UserCourses { CourseId = course.Id, UserId = userId });
            course.CategoriesId = 1;//Bu hisse sehvdi mlm 
          
          course.UserCourses = usercourses;
            await _db.Courses.AddAsync(course);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? Id)
        {
            ViewBag.CourseUser = _db.Users.Where(c => c.UserThoughts == "Student").ToList();
            if (Id == null) return NotFound();
            Course course = _db.Courses.FirstOrDefault(c => c.Id == Id);
            if (course == null) return NotFound();
            return View(course);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? Id, Course course, string userId)
        {

            ViewBag.CourseUser = _db.Users.Where(c => c.UserThoughts == "Student").ToList();
            if (Id == null) return NotFound();

            if (ModelState.IsValid)
            {
                return View();
            }
            Course dbcourse = _db.Courses.Include(n=>n.UserCourses).ThenInclude(b=>b.User).FirstOrDefault(r => r.Id == Id);
            if (ModelState["PhotoCourse"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (!course.PhotoCourse.IsImage())
            {
                ModelState.AddModelError("PhotoCourse", "Sekil fayli daxil edin");
                return View();
            }
            if (course.PhotoCourse.MaxLength(300))
            {
                ModelState.AddModelError("PhotoCourse", "Seklin olcusu 300kb-dan boyuk olmamalidir");
                return View();
            }

            string folderpath = Path.Combine("img", "course");
            Helper.DeleteImage(_env.WebRootPath, folderpath, dbcourse.Image);

            string FileName = await course.PhotoCourse.SaveImage(_env.WebRootPath, folderpath);

            dbcourse.Image = FileName;
            dbcourse.Language = course.Language;
            dbcourse.HowDoApply = course.HowDoApply;
            dbcourse.AboutCourse = course.AboutCourse;
            dbcourse.Assetsments = course.Assetsments;
            dbcourse.Certification = course.Certification;
            dbcourse.CourseName = course.CourseName;
            dbcourse.CoursePrice = course.CoursePrice;
            dbcourse.Description = course.Description;
            dbcourse.Duration = course.Duration;
            dbcourse.SkillLevel = course.SkillLevel;
            dbcourse.ClassDuration = course.ClassDuration;
            dbcourse.StudentCapacity = course.StudentCapacity;
            dbcourse.StartCourse = course.StartCourse;

            dbcourse.CategoriesId = 1;

            dbcourse.UserCourses.FirstOrDefault().UserId = userId;
            
          
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}