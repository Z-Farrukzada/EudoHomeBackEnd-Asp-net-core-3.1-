using Microsoft.AspNetCore.Mvc;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.ViewComponents
{
    public class TestiMonialViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public TestiMonialViewComponent(AppDbContext db)
        {
            _db = db;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            Testimonial testimonial = _db.Testimonials.FirstOrDefault();
            return View(await Task.FromResult(testimonial));
        }
    }
}
