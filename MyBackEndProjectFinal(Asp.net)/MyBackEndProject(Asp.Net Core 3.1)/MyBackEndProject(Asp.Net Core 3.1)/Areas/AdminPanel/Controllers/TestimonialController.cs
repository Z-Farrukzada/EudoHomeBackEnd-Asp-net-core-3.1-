using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.Extensions;
using MyBackEndProject_Asp.Net_Core_3._1_.Helpers;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class TestimonialController : Controller
    {
        private readonly AppDbcontext _db;
        private readonly IWebHostEnvironment _env;
        public TestimonialController(AppDbcontext db,IWebHostEnvironment env)
        {
            _db = db;
            _env = env;

        }
        public IActionResult Index()
        {

            return View(_db.Testimonials.FirstOrDefault());
        }
        public IActionResult Update()
        {
            return View(_db.Testimonials.FirstOrDefault());
;        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Testimonial testmonial)
        {

            if (ModelState["PhotoFrond"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid &&
                ModelState["PhotoBack"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }


            if (!testmonial.PhotoFrond.IsImage() && !testmonial.PhotoBack.IsImage())
            {
                ModelState.AddModelError("Photo", "Sekil fayli daxil edin");
                return View();
            }
            if (testmonial.PhotoFrond.MaxLength(300) && testmonial.PhotoFrond.MaxLength(300))
            {
                ModelState.AddModelError("Photo", "Seklin olcusu 300kb-dan artiq olmamalidir");
                return View();
            }
            Testimonial dbtestmonial = _db.Testimonials.FirstOrDefault();
            string foldername = Path.Combine("img", "testimonial");
           
            Helper.DeleteImage(_env.WebRootPath, foldername, dbtestmonial.Image);
            Helper.DeleteImage(_env.WebRootPath, foldername, dbtestmonial.BackgroundImage);

            string FileName = await testmonial.PhotoFrond.SaveImage(_env.WebRootPath, foldername);
            string FileNameBack = await testmonial.PhotoBack.SaveImage(_env.WebRootPath, foldername);

            dbtestmonial.Image = FileName;
            dbtestmonial.BackgroundImage = FileNameBack;
            dbtestmonial.Job = testmonial.Job;
            dbtestmonial.Description = testmonial.Description;
            dbtestmonial.CourseName = testmonial.CourseName;
            dbtestmonial.Name = testmonial.Name;
            dbtestmonial.Surname = testmonial.Surname;
           
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));


        }

    }
}