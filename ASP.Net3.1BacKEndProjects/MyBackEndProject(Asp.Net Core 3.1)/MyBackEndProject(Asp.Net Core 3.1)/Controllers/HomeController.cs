using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.ViewModels;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbcontext _db;
        public HomeController(AppDbcontext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVm homevm = new HomeVm
            {
                Sliders = _db.Sliders,
                NoticeProfessions = _db.NoticeProfessions,
                EudoHomeChooses = _db.EudoHomeChooses.FirstOrDefault()
              



            };
            return View(homevm);
        }
    }
}