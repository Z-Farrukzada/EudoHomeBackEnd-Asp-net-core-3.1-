using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class NoticeProfessionController : Controller
    {
        private readonly AppDbcontext _db;
        public NoticeProfessionController(AppDbcontext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.NoticeProfessions);
        }
        public async Task<IActionResult> Delete(int? id)
        {


            if (id == null) return NotFound();
            NoticeProfession noticeProfession = await _db.NoticeProfessions.FindAsync(id);
            if (noticeProfession == null) return NotFound();


            _db.NoticeProfessions.Remove(noticeProfession);
            await _db.SaveChangesAsync();

            return RedirectToAction("index");

        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NoticeProfession noticeProfession)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            
            bool IsValid = _db.NoticeProfessions.Any(c => c.Title.ToLower() == noticeProfession.Title.ToLower());
                if (IsValid)
                {
                    ModelState.AddModelError("Title", "Bu Basliq artiq var");
                    return View();
                }
           


            bool IsValidDes = _db.NoticeProfessions.Any(c => c.Description.ToLower() == noticeProfession.Description.ToLower());

            if (IsValidDes)
            {
                ModelState.AddModelError("Description", "Bu Description artiq var");
                return View();
            }

            await _db.NoticeProfessions.AddAsync(noticeProfession);
            await _db.SaveChangesAsync();
            return RedirectToAction("index");

        }
        public async Task<IActionResult> Update(int? Id)
        {
            if (Id == null) return NotFound();
            NoticeProfession noticeProfessionUpload = await _db.NoticeProfessions.FindAsync(Id);
            if (noticeProfessionUpload == null) return NotFound();
            return View(noticeProfessionUpload);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? Id, NoticeProfession noticeProfession)
        {
            if (Id == null) return NotFound();
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (noticeProfession.Title != null)
            {
                bool valid = _db.NoticeProfessions.Any(c => c.Title.ToLower() == noticeProfession.Title.ToLower());
                if (valid)
                {
                    ModelState.AddModelError("Title", "Bu basliq artiq var");
                    return View();
                }

            }
            bool isvaliddes = _db.NoticeProfessions.Any(c => c.Description.ToLower() == noticeProfession.Description.ToLower());
            if (isvaliddes)
            {
                ModelState.AddModelError("Description", "Bu description artiq muvcuddur");
                return View();
            }
            NoticeProfession dbnoticeProfession = await _db.NoticeProfessions.FindAsync(Id);
            if (dbnoticeProfession == null) return NotFound();
            dbnoticeProfession.Title = noticeProfession.Title;
            dbnoticeProfession.Description = noticeProfession.Description;
          
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}