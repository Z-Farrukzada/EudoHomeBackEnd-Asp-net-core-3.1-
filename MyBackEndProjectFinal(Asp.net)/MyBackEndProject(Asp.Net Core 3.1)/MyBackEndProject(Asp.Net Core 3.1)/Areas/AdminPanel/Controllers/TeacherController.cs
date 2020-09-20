using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.Extensions;
using MyBackEndProject_Asp.Net_Core_3._1_.Helpers;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;
using MyBackEndProject_Asp.Net_Core_3._1_.ViewModels;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class TeacherController : Controller
    {
        private readonly AppDbcontext _db;
        private readonly IWebHostEnvironment _env;
        public TeacherController(AppDbcontext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Teacher> teacher = _db.Teachers.ToList();
            return View(teacher);
        }
        public IActionResult Detail(int? Id)
        {
            Teacher teacher = _db.Teachers.Include(s => s.Skills).FirstOrDefault(p => p.Id == Id);
            return View(teacher);
        }

        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null) return NotFound();

            Teacher delteacher = _db.Teachers.Include(c => c.Skills).FirstOrDefault(c => c.Id == Id);
            _db.Teachers.Remove(delteacher);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (!teacher.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Sekil fayli daxil edin");
                return View();
            }
            if (teacher.Photo.MaxLength(300))
            {
                ModelState.AddModelError("Photo", "Seklin olcusu 300kb-dan boyuk olmamalidir");
                return View();
            }
            string newfolder = Path.Combine("img", "teacher");
            string FileName = await teacher.Photo.SaveImage(_env.WebRootPath, newfolder);
            teacher.Image = FileName;
            Skills skills = new Skills();
            skills.TeacherId = teacher.Id;
            await _db.Teachers.AddAsync(teacher);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? Id)
        {
            Teacher teacher = _db.Teachers.Include(s => s.Skills).FirstOrDefault(c => c.Id == Id);
            return View(teacher);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Teacher teacher)
        {
            if (id == null) return NotFound();


            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (!teacher.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Sekil fayli daxil edin");
                return View();
            }
            if (teacher.Photo.MaxLength(300))
            {
                ModelState.AddModelError("Photo", "Seklin olcusu 300kb-dan boyuk olmamalidir");
                return View();
            }
            Teacher dbteacher = _db.Teachers.Include(s=>s.Skills).FirstOrDefault(m=>m.Id==id);
            if (dbteacher == null) return NotFound();
            string folderpath = Path.Combine("img", "teacher");
            Helper.DeleteImage(_env.WebRootPath, folderpath, dbteacher.Image);

            string FileName = await teacher.Photo.SaveImage(_env.WebRootPath, folderpath);
            dbteacher.Image = FileName;
            dbteacher.Name = teacher.Name;
            dbteacher.Profession = teacher.Profession;
            dbteacher.Faculty = teacher.Faculty;
            dbteacher.Hobbies = teacher.Hobbies;
            dbteacher.Degree = teacher.Degree;
            dbteacher.AboutMe = teacher.AboutMe;
            dbteacher.ContactTel = teacher.ContactTel;
            dbteacher.Experience = teacher.Experience;
            dbteacher.Instagram = teacher.Instagram;
            dbteacher.Mail = teacher.Mail;
            dbteacher.Facebook = teacher.Facebook;
            dbteacher.Pinterest = teacher.Pinterest;
            dbteacher.Skype = teacher.Skype;
            dbteacher.Twitter = teacher.Twitter;

            dbteacher.Skills.Language = teacher.Skills.Language;
            dbteacher.Skills.Innovation = teacher.Skills.Innovation;
            dbteacher.Skills.Communication = teacher.Skills.Communication;
            dbteacher.Skills.Development = teacher.Skills.Development;
            dbteacher.Skills.Design = teacher.Skills.Design;
            dbteacher.Skills.TeamLeader = teacher.Skills.TeamLeader;
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
    }
}