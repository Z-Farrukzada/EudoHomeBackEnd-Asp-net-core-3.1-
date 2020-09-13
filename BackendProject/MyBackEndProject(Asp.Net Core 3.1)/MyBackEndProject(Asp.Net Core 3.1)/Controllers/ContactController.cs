using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.ViewModels;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _db;
        public ContactController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVm homeVmContact = new HomeVm
            {
                logos=_db.Logos


            };
            ViewBag.Banner = _db.Banners.Skip(5).Take(1);
            return View(homeVmContact);
        }
    }
}