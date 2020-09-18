using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.ViewComponents
{
    public class HeaderTwoViewComponent:ViewComponent
    {
        private readonly AppDbcontext _db;
        private readonly UserManager<User> _userManager;
        public HeaderTwoViewComponent(AppDbcontext db,UserManager<User> userManager)
        {
            _db = db;
            _userManager = userManager;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.UserName = "";
            ViewBag.Email = "";
            ViewBag.UserRole = "";
            if(User.Identity.IsAuthenticated)
            {
                User user = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.UserName = user.UserName;
                ViewBag.Email = user.Email;
                ViewBag.UserRole = user.UserThoughts;
               
            }

            Logo logos = _db.Logos.FirstOrDefault();
            return View(await Task.FromResult(logos));
        }
    }
}
