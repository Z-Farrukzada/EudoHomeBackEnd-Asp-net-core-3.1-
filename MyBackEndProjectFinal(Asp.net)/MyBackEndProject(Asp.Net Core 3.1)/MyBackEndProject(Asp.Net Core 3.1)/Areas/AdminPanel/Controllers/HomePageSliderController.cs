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
    public class HomePageSliderController : Controller
    {
        private readonly AppDbcontext _db;
        private readonly IWebHostEnvironment _env;
        public HomePageSliderController(AppDbcontext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
           
            return View(_db.Sliders);
        }

        public async Task<IActionResult> Delete(int? id)
        {
          
           
            if (id == null) return NotFound();
            Slider slider = await _db.Sliders.FindAsync(id);
            if (slider == null) return NotFound();

            string folderpath = Path.Combine("img", "slider");
            Helper.DeleteImage(_env.WebRootPath, folderpath, slider.Image);

          
            _db.Sliders.Remove(slider);
            await _db.SaveChangesAsync(); 
           
            return RedirectToAction("index");

        }
        public IActionResult Create()
        {
            if (_db.Sliders.Count() >= 6)
            {

                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slide)
        {


            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (!slide.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Sekil fayli daxil edin");
                return View();
            }
            if (slide.Photo.MaxLength(300))
            {
                ModelState.AddModelError("Photo", "Seklin olcusu 300kb-dan boyuk olmamalidir");
                return View();
            }
            string newfolder = Path.Combine("img", "slider");
            string FileName = await slide.Photo.SaveImage(_env.WebRootPath, newfolder);
            slide.Image = FileName;
            await _db.Sliders.AddAsync(slide);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Update(int? Id)
        {
            if (Id == null) return NotFound();
            Slider slide =await _db.Sliders.FindAsync(Id);
            if (slide == null) return NotFound();
            return View(slide);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Slider slide)
        {
            if (id == null) return NotFound();
            

                if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    return View();
                }
                if (!slide.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Sekil fayli daxil edin");
                    return View();
                }
                if (slide.Photo.MaxLength(300))
                {
                    ModelState.AddModelError("Photo", "Seklin olcusu 200kb-dan boyuk olmamalidir");
                    return View();
                }
                Slider dbslide = await _db.Sliders.FindAsync(id);
                if (dbslide == null) return NotFound();
                string folderpath = Path.Combine("img", "slider");
                Helper.DeleteImage(_env.WebRootPath, folderpath, dbslide.Image);

                string FileName = await slide.Photo.SaveImage(_env.WebRootPath, folderpath);
                dbslide.Image = FileName;
                dbslide.Title = slide.Title;
                dbslide.Description = slide.Description;
                await _db.SaveChangesAsync();
           
            return RedirectToAction(nameof(Index));
        }
    }
}