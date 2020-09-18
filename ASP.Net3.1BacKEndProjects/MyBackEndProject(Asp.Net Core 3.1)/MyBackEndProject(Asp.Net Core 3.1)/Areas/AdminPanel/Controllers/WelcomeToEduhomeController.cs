using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.Extensions;
using MyBackEndProject_Asp.Net_Core_3._1_.Helpers;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class WelcomeToEduhomeController : Controller
    {
        private readonly AppDbcontext _db;
        private readonly IWebHostEnvironment _env;
        public WelcomeToEduhomeController(AppDbcontext db,IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.WelcomeEduHomes.FirstOrDefault());
        }
        public IActionResult Update()
        {
            return View(_db.WelcomeEduHomes.FirstOrDefault());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(WelcomeEduHome welcomeeduhome)
        {

            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid) 
            {
                return View();
            }


            if (!welcomeeduhome.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Sekil fayli daxil edin");
                return View();
            }
            if (welcomeeduhome.Photo.MaxLength(300))
            {
                ModelState.AddModelError("Photo", "Seklin olcusu 300kb-dan artiq olmamalidir");
                return View();
            }
            WelcomeEduHome dbwelcomeduhome = _db.WelcomeEduHomes.FirstOrDefault();
            string foldername = Path.Combine("img", "about");

            Helper.DeleteImage(_env.WebRootPath, foldername, dbwelcomeduhome.Image);
           

            string FileName = await welcomeeduhome.Photo.SaveImage(_env.WebRootPath, foldername);


            dbwelcomeduhome.Image = FileName;
            dbwelcomeduhome.Title = welcomeeduhome.Title;
            dbwelcomeduhome.Description = welcomeeduhome.Description;
           
         

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));


        }

    }
}