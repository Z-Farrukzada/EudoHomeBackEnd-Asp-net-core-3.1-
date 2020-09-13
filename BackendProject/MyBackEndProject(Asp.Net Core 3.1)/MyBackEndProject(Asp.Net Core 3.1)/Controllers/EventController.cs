using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;
using MyBackEndProject_Asp.Net_Core_3._1_.ViewModels;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _db;
        public EventController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.EventCount = _db.NewEvents.Count();
            ViewBag.Banner = _db.Banners.Skip(2).Take(1);
            HomeVm homeVmEvent = new HomeVm
            {
                NewEvents=_db.NewEvents.Take(9)
            };
            return View(homeVmEvent);
        }
        public IActionResult Load(int count)
        {
            if (count >= _db.Courses.Count())
            {
                return Content("Bu qeder melumat yoxdur");
            }
            IEnumerable<NewEvent> newevent = _db.NewEvents.Skip(count).Take(9);
            return PartialView("_EventPartial", newevent);
        }
        public IActionResult Detail(int? Id)
        {
            if (Id == null) return NotFound();
            ViewBag.Banner = _db.Banners.Skip(7).Take(1);


            DetailVm NewEventDetail = new DetailVm
            {
                newEvents = _db.NewEvents.Where(e => e.Id == Id).Include(c => c.NewManagmentEvents)
                .ThenInclude(m => m.NewManagmentBoard).FirstOrDefault(),
                Courses = _db.Courses.Include(c => c.Categories).Take(6).ToList(),
                Blogs = _db.Blogs.Take(3).ToList(),


            };
            return View(NewEventDetail);
        }

    }
}