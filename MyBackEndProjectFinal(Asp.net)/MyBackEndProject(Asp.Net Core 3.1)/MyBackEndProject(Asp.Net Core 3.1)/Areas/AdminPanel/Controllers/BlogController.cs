using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
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
    public class BlogController : Controller
    {
        private readonly AppDbcontext _db;
        private readonly IWebHostEnvironment _env;

        public BlogController(AppDbcontext db,IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Blog> blog = _db.Blogs.ToList();
            return View(blog);
        }
        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null) return NotFound();
            Blog blogs = _db.Blogs.Include(c => c.BlogAndTeachers).FirstOrDefault(v => v.Id == Id);
            if (blogs == null) return NotFound();
            _db.Blogs.Remove(blogs);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Detail(int? Id)
        {
            if (Id == null) return NotFound();
            Blog blogDetail = _db.Blogs.FirstOrDefault(b => b.Id == Id);
            if (blogDetail == null) return NotFound();
            return View(blogDetail);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blogs)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            if (ModelState["PhotoBlog"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            bool isExist = _db.Blogs.Any(c => c.Blogname.ToLower() == blogs.Blogname.ToLower());
            if (isExist)
            {
                ModelState.AddModelError("Blogname", "Blog adi movcuddur");
            }
            if (!blogs.PhotoBlog.IsImage())
            {
                ModelState.AddModelError("PhotoBlog", "Sekil fayli daxil edin");
                return View();
            }
            if (blogs.PhotoBlog.MaxLength(300))
            {
                ModelState.AddModelError("PhotoBlog", "Seklin olcusu 300kb-dan boyuk olmamalidir");
                return View();
            }
            string newfolder = Path.Combine("img", "blog");
            string FileName = await blogs.PhotoBlog.SaveImage(_env.WebRootPath, newfolder);
            blogs.Image = FileName;
           
           
            await _db.Blogs.AddAsync(blogs);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? Id)
        {

            if (Id == null) return NotFound();
            Blog blogs = _db.Blogs.FirstOrDefault(c => c.Id == Id);
            if (blogs == null) return NotFound();
            return View(blogs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? Id, Blog blogs)
        {
            if (Id == null) return NotFound();

            if (ModelState.IsValid)
            {
                return View();
            }
            Blog dbblogs = _db.Blogs.FirstOrDefault(r => r.Id == Id);
            if (ModelState["PhotoBlog"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (!blogs.PhotoBlog.IsImage())
            {
                ModelState.AddModelError("PhotoBlog", "Sekil fayli daxil edin");
                return View();
            }
            if (blogs.PhotoBlog.MaxLength(300))
            {
                ModelState.AddModelError("PhotoBlog", "Seklin olcusu 300kb-dan boyuk olmamalidir");
                return View();
            }

            string folderpath = Path.Combine("img", "blog");
            Helper.DeleteImage(_env.WebRootPath, folderpath, dbblogs.Image);

            string FileName = await blogs.PhotoBlog.SaveImage(_env.WebRootPath, folderpath);

            dbblogs.Image = FileName;
            dbblogs.Blogname = blogs.Blogname;
            dbblogs.Author = blogs.Author;
            dbblogs.BlogWriteTime = blogs.BlogWriteTime;
            dbblogs.CommentCount = blogs.CommentCount;
            dbblogs.Description = blogs.Description;
            
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}