using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;
using MyBackEndProject_Asp.Net_Core_3._1_.ViewModels;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly AppDbcontext _db;
        public UserController(UserManager<User> UserManager, AppDbcontext db)
        {
            _userManager = UserManager;
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            List<User> users = _userManager.Users.ToList();
            List<UserVm> usersvm = new List<UserVm>();

            foreach(User user in users)
            {
                UserVm uservm = new UserVm
                {
                    Id = user.Id,
                    Email = user.Email,
                    IsActivited = user.IsActivated,
                    Fullname = user.FullName,
                    Username = user.UserName,
                    UserPosition = user.UserThoughts,
                    Role = (await _userManager.GetRolesAsync(user))[0]
                };
                usersvm.Add(uservm);
            }
            return View(usersvm);
        }


        public async Task<IActionResult> ChangeRole(string Id)
        {
            if (Id == null) return NotFound();
            User user =await _userManager.FindByIdAsync(Id);
            if (user == null) return NotFound();

            UserVm userVM = new UserVm
            {
                Id = user.Id,
                Email = user.Email,
                Username = user.UserName,
                Fullname = user.FullName,
                UserPosition=user.UserThoughts,
                IsActivited = user.IsActivated,
                Role = (await _userManager.GetRolesAsync(user))[0],
                Roles = new List<string> { "Member", "Admin" }
            };
            return View(userVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeRole(string Id,string role)
        {
            if (Id == null) return NotFound();
            if (role ==null) return NotFound();
            User user = await _userManager.FindByIdAsync(Id);
            if (user == null) return NotFound();
            ViewBag.user = user.Id;
            string OldRole =  (await _userManager.GetRolesAsync(user))[0];
            await _userManager.RemoveFromRoleAsync(user, OldRole);
            await _userManager.AddToRoleAsync(user, role);
            return RedirectToAction("Index","User");
 
        }
       
       
        public async Task<IActionResult> IsActivate(string Id,bool IsActivated)
        {

            if (Id == null) return NotFound();
            User user =await _userManager.FindByIdAsync(Id);
            if (user == null) return NotFound();
            user.IsActivated = IsActivated;
            await _db.SaveChangesAsync();

          
           
            return Ok(user);
        }
    }
}