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
    public class ChooseEduHomeController : Controller
    {
        private readonly AppDbcontext _db;
        private readonly IWebHostEnvironment _env;
        public ChooseEduHomeController(AppDbcontext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.EudoHomeChooses.FirstOrDefault());
        }
        public IActionResult Update()
        {

            EudoHomeChoose eudohome = _db.EudoHomeChooses.FirstOrDefault();
            if (eudohome == null) return NotFound();
            return View(eudohome);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update( EudoHomeChoose eudoHome)
        {
        

            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (!eudoHome.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Sekil fayli daxil edin");
                return View();
            }
            if (eudoHome.Photo.MaxLength(300))
            {
                ModelState.AddModelError("Photo", "Seklin olcusu 300kb-dan boyuk olmamalidir");
                return View();
            }
            EudoHomeChoose dbeudohome = _db.EudoHomeChooses.FirstOrDefault();
            if (dbeudohome == null) return NotFound();
            string folderpath = Path.Combine("img", "slider");
            Helper.DeleteImage(_env.WebRootPath, folderpath, dbeudohome.Image);

            string FileName = await eudoHome.Photo.SaveImage(_env.WebRootPath, folderpath);
            dbeudohome.Image = FileName;
            dbeudohome.Title = eudoHome.Title;
            dbeudohome.Description = eudoHome.Description;
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
  
}