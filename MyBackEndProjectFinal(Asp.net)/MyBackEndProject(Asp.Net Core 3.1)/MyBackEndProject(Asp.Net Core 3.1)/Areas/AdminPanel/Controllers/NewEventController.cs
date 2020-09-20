using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.Extensions;
using MyBackEndProject_Asp.Net_Core_3._1_.Helpers;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class NewEventController : Controller
    {
        private readonly AppDbcontext _db;
        private readonly IWebHostEnvironment _env;
        public NewEventController(AppDbcontext db,IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            List<NewEvent> newevent = _db.NewEvents.ToList();
            return View(newevent);
        }
        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null) return NotFound();
            NewEvent dbnewEvent = _db.NewEvents.Where(w=>w.IsDeleted==false).Include(p => p.NewManagmentEvents).ThenInclude(c => c.NewManagmentBoard).FirstOrDefault(f => f.Id == Id);
            _db.NewEvents.Remove(dbnewEvent);
             await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Detail(int? Id)
        {
            NewEvent newevent = _db.NewEvents.Where(w => w.IsDeleted == false).Include(c => c.NewManagmentEvents).ThenInclude(m => m.NewManagmentBoard).FirstOrDefault(d => d.Id == Id);
            return View(newevent);
        }
        public IActionResult Create()
        {
            ViewBag.Speakers = _db.NewManagmentBoards.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NewEvent newevent,int speakeroneId ,int speakertwoId)
        {
            ViewBag.Speakers = _db.NewManagmentBoards.ToList();
            if (ModelState.IsValid)
            {
                return View();
            }
            if (speakeroneId == speakertwoId)
            {
                return View();
            }
            if (ModelState["PhotoEvent"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (!newevent.PhotoEvent.IsImage())
            {
                ModelState.AddModelError("PhotoEvent", "Sekil fayli daxil edin");
                return View();
            }
            if (newevent.PhotoEvent.MaxLength(300))
            {
                ModelState.AddModelError("PhotoEvent", "Seklin olcusu 300kb-dan boyuk olmamalidir");
                return View();
            }
          
            string newfolder = Path.Combine("img", "event");
            string FileName = await newevent.PhotoEvent.SaveImage(_env.WebRootPath, newfolder);
            newevent.Image = FileName;
           
            List<NewManagmentEvent> managementevent = new List<NewManagmentEvent>();
            managementevent.Add(new NewManagmentEvent { NewEventId = newevent.Id, NewManagmentBoardId = speakeroneId });
            managementevent.Add(new NewManagmentEvent { NewEventId = newevent.Id,NewManagmentBoardId=speakertwoId });
            newevent.NewManagmentEvents = managementevent;
            await _db.NewEvents.AddAsync(newevent);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? Id)
        {
            ViewBag.Speakers = _db.NewManagmentBoards.ToList();
            NewEvent newEvent =_db.NewEvents.Where(w => w.IsDeleted == false).Include(c => c.NewManagmentEvents).ThenInclude(v => v.NewManagmentBoard).FirstOrDefault(f => f.Id == Id);
            return View(newEvent);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? Id ,NewEvent newevent, int? speakeroneId, int? speakertwoId)
        {
            ViewBag.Speakers = _db.NewManagmentBoards.ToList();
            if (Id == null) return NotFound();
            //if(speakeroneId == speakertwoId) return View();
            NewEvent DbnewEvent = _db.NewEvents.Where(w => w.IsDeleted == false).Include(m => m.NewManagmentEvents).ThenInclude(d => d.NewManagmentBoard).FirstOrDefault(f => f.Id == Id);
            if (DbnewEvent == null) return NotFound();

            NewEvent CheckDb = _db.NewEvents.Where(c => c.IsDeleted == false).FirstOrDefault(f => f.Name.ToLower() == newevent.Name.ToLower());
            if (CheckDb != null)
            {
                if (DbnewEvent.Name.ToLower() == CheckDb.Name.ToLower())
                {
                    ModelState.AddModelError("Name", "Bu adli Event Movcuddur");
                    return View(DbnewEvent);
                }
            }
              if (ModelState["PhotoEvent"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (!newevent.PhotoEvent.IsImage())
            {
                ModelState.AddModelError("PhotoEvent", "Sekil fayli daxil edin");
                return View();
            }
            if (newevent.PhotoEvent.MaxLength(300))
            {
                ModelState.AddModelError("PhotoEvent", "Seklin olcusu 300kb-dan boyuk olmamalidir");
                return View();
            }
          
            string folderpath = Path.Combine("img", "event");
            Helper.DeleteImage(_env.WebRootPath, folderpath, DbnewEvent.Image);

            string FileName = await newevent.PhotoEvent.SaveImage(_env.WebRootPath, folderpath);

            DbnewEvent.Image = FileName;
            DbnewEvent.Name = newevent.Name;
            DbnewEvent.Description = newevent.Description;
            DbnewEvent.EventAbout = newevent.EventAbout;
            DbnewEvent.EventFinish = newevent.EventFinish;
            DbnewEvent.EventPlace = newevent.EventPlace;
            DbnewEvent.EventStart = newevent.EventStart;
            DbnewEvent.EventTime = newevent.EventTime;

            DbnewEvent.NewManagmentEvents.ElementAt(0).NewManagmentBoardId = (int)speakeroneId;
            DbnewEvent.NewManagmentEvents.ElementAt(1).NewManagmentBoardId = (int)speakertwoId;

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }
    }
}