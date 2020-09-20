using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class TakeVideoController : Controller
    {
        private readonly AppDbcontext _db;
        public TakeVideoController(AppDbcontext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.TakeVideos.FirstOrDefault());
        }
        public IActionResult Update()
        {
            return View(_db.TakeVideos.FirstOrDefault());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(TakeVideo takevideo)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
           
            TakeVideo dbtakevideo=  _db.TakeVideos.FirstOrDefault();
            dbtakevideo.Title = takevideo.Title;
            dbtakevideo.Video = takevideo.Video;
             _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        } 
    }
}