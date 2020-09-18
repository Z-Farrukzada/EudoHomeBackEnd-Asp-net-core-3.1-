using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.Helpers;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class NoticeBoardController : Controller
    {
        private readonly AppDbcontext _db;
        public NoticeBoardController(AppDbcontext db)
        {
            _db = db;
        }


      
        public IActionResult Index()
        {

            return View(_db.NoticeBoards);
        }
        public async Task<IActionResult> Delete(int? id)
        {


            if (id == null) return NotFound();
           NoticeBoard noticeBoard= await _db.NoticeBoards.FindAsync(id);
            if (noticeBoard == null) return NotFound();


            _db.NoticeBoards.Remove(noticeBoard);
            await _db.SaveChangesAsync();

            return RedirectToAction("index");

        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NoticeBoard noticeBoard)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (noticeBoard.Title != null)
            {
                bool IsValid = _db.NoticeBoards.Any(c => c.Title.ToLower() == noticeBoard.Title.ToLower());
                if (IsValid)
                {
                    ModelState.AddModelError("Title", "Bu Basliq artiq var");
                    return View();
                }
            }

           
            bool IsValidDes = _db.NoticeBoards.Any(c => c.Description.ToLower() == noticeBoard.Description.ToLower());
          
            if (IsValidDes)
            {
                ModelState.AddModelError("Description","Bu Description artiq var");
                return View();
            }

            await _db.NoticeBoards.AddAsync(noticeBoard);
            await _db.SaveChangesAsync();
            return RedirectToAction("index");
           
        }
        public async Task<IActionResult> Update(int? Id)
        {
            if (Id == null) return NotFound();
            NoticeBoard noticeboardUpload = await _db.NoticeBoards.FindAsync(Id);
            if (noticeboardUpload == null) return NotFound();
            return View(noticeboardUpload);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? Id,NoticeBoard noticeBoard)
        {
            if (Id == null) return NotFound();
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (noticeBoard.Title != null)
            {
                bool valid = _db.NoticeBoards.Any(c => c.Title.ToLower() == noticeBoard.Title.ToLower());
                if (valid)
                {
                    ModelState.AddModelError("Title", "Bu basliq artiq var");
                    return View();
                }

            }
            bool isvaliddes = _db.NoticeBoards.Any(c => c.Description.ToLower() == noticeBoard.Description.ToLower());
            if (isvaliddes)
            {
                ModelState.AddModelError("Description", "Bu description artiq muvcuddur");
                return View();
            }
            NoticeBoard dbnoticeboard =await  _db.NoticeBoards.FindAsync(Id);
            if (dbnoticeboard == null) return NotFound();
            dbnoticeboard.Title = noticeBoard.Title;
            dbnoticeboard.Description = noticeBoard.Description;
            dbnoticeboard.NoticeTime = noticeBoard.NoticeTime;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}