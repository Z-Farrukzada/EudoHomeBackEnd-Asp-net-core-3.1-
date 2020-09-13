using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.ViewModels;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _db;
        public AboutController(AppDbContext db) 
        {
            _db = db;
        }
        public IActionResult Index()
        {

            ViewBag.Banner = _db.Banners.Take(1);

            HomeVm homeVmAbout = new HomeVm
            {
                welcomeEduHome = _db.WelcomeEduHomes.FirstOrDefault(),
                TakeVideo = _db.TakeVideos.FirstOrDefault()
            };
            return View(homeVmAbout);
        }
    }
}