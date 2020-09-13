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
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;
        public BlogController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int? page)
        {
            ViewBag.Banner = _db.Banners.Skip(4).Take(1);
            ViewBag.Pagination =Math.Ceiling((decimal)_db.Blogs.Count() / 9);

            ViewBag.Page = page;
            if (ViewBag.Page == null || ViewBag.Page == 1)
            {
                ViewBag.blogs = 0;
                 
            }
            else
            {
                ViewBag.blogs =(_db.Blogs.Count())-((int)page-1)*9;
             
               
            }

            return View();
        }
        public IActionResult Detail(int? Id)
        {
            if (Id == null) return NotFound();
            ViewBag.Banner = _db.Banners.Skip(9).Take(1);
            DetailVm BlogDetail = new DetailVm
            {
                blog=_db.Blogs.Where(c=>c.Id==Id).Include(m=>m.BlogAndTeachers).ThenInclude(v=>v.Teacher).FirstOrDefault(),
                Courses = _db.Courses.Include(c => c.Categories).Take(6).ToList(),
                Blogs = _db.Blogs.Take(3).ToList()

            };
            return View(BlogDetail);
           
        }


    }
}