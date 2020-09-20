using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.Extensions;
using MyBackEndProject_Asp.Net_Core_3._1_.Helpers;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class NewManagmentController : Controller
    {
        private readonly AppDbcontext _db;
        private readonly IWebHostEnvironment _env;
        public NewManagmentController(AppDbcontext db,IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            List<NewManagmentBoard> newManagmentBoard = _db.NewManagmentBoards.ToList();
            return View(newManagmentBoard);
        }
        public async  Task<IActionResult>  Delete(int? Id)
        {
            if (Id == null) return NotFound();
            NewManagmentBoard newManagmentBoard = _db.NewManagmentBoards.Include(c => c.NewManagmentEvents).ThenInclude(p => p.NewEvent).FirstOrDefault(d => d.Id == Id);
            if (newManagmentBoard == null) return NotFound();
            _db.NewManagmentBoards.Remove(newManagmentBoard);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
          
        }
        public IActionResult Create()
        {
          
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NewManagmentBoard newManagmentBoard)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            if (ModelState["PhotoSpeaker"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (!newManagmentBoard.PhotoSpeaker.IsImage())
            {
                ModelState.AddModelError("PhotoSpeaker", "Sekil fayli daxil edin");
                return View();
            }
            if (newManagmentBoard.PhotoSpeaker.MaxLength(300))
            {
                ModelState.AddModelError("PhotoSpeaker", "Seklin olcusu 300kb-dan boyuk olmamalidir");
                return View();
            }

            string newfolder = Path.Combine("img", "event");
            string FileName = await newManagmentBoard.PhotoSpeaker.SaveImage(_env.WebRootPath, newfolder);
            newManagmentBoard.Image = FileName;

          
           
            await _db.NewManagmentBoards.AddAsync(newManagmentBoard);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? Id)
        {
            if (Id == null) return NotFound();
            NewManagmentBoard newManagment = _db.NewManagmentBoards.FirstOrDefault(c => c.Id == Id);
            if (newManagment == null) return NotFound();
            return View(newManagment);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? Id ,NewManagmentBoard newManagment)
        {
            if (Id == null) return NotFound();

            if (ModelState.IsValid)
            {
                return View();
            }
            NewManagmentBoard dbnewManagmentBoard=_db.NewManagmentBoards.FirstOrDefault(r => r.Id == Id);
            if(ModelState["PhotoSpeaker"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (!newManagment.PhotoSpeaker.IsImage())
            {
                ModelState.AddModelError("PhotoSpeaker", "Sekil fayli daxil edin");
                return View();
            }
            if (newManagment.PhotoSpeaker.MaxLength(300))
            {
                ModelState.AddModelError("PhotoSpeaker", "Seklin olcusu 300kb-dan boyuk olmamalidir");
                return View();
            }

            string folderpath = Path.Combine("img", "event");
            Helper.DeleteImage(_env.WebRootPath, folderpath, dbnewManagmentBoard.Image);

            string FileName = await newManagment.PhotoSpeaker.SaveImage(_env.WebRootPath, folderpath);

            dbnewManagmentBoard.Image = FileName;
            dbnewManagmentBoard.Name = newManagment.Name;
            dbnewManagmentBoard.Position = newManagment.Position;
            dbnewManagmentBoard.Surname = newManagment.Surname;

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}