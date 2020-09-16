using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyBackEndProject_Asp.Net_Core_3._1_.Migrations;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;
using MyBackEndProject_Asp.Net_Core_3._1_.ViewModels;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;

            
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Login(LoginVm login)
        {
            if (!ModelState.IsValid) return View();
            

            User user = await _userManager.FindByEmailAsync(login.Email);

            

           
           

            if (user == null)
            {
                ModelState.AddModelError("", "Email or Password is wrong!!!");
                return View(login);
            }
            else
            {
                if (!await _userManager.IsEmailConfirmedAsync(user))
                {
                    ModelState.AddModelError(string.Empty, "Please Confirm Email");
                    return View(login);
                }
            }
            var signinresult = await _signInManager.PasswordSignInAsync(user, login.Password, login.Rememberme, false);
         
            if (signinresult.IsLockedOut)
            {
                ModelState.AddModelError("", "The account is Lock Out!!!");
                return View();
            }
            if (!signinresult.Succeeded)
            {
                ModelState.AddModelError("", "Email or Password is wrong !!!");
            }
            return RedirectToAction("Index","Home");
        }
        public IActionResult SignUp()
        {

            return View();
        }

        //SignUp Method 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(RegisterVm register)
        {
            if (!ModelState.IsValid) return NotFound();

            User newuser = new User
            {
                FullName=register.FullName,
                UserName=register.Username,
                Email=register.Email,
                UserThoughts=register.UserThoughts
            };

            IdentityResult identityresult =await _userManager.CreateAsync(newuser,register.Password);

            if (!identityresult.Succeeded)
            {
                foreach(var error in identityresult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                  
                }
                return View(register);
            }
            else
            {
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(newuser);
                var callbackUrl = Url.Action(
                    "ConfirmEmail",
                    "Account",
                    new { userId = newuser.Id, codes = code },
                    protocol: HttpContext.Request.Scheme);
                EmailServices emailService = new EmailServices();
                await emailService.SendEmailAsync(register.Email, " Zehmet olmasa linke click ederek qeydiyyatdan kecin )))",
                    $"Your link: <a href='{callbackUrl}'>Link</a>");

                await _userManager.AddToRoleAsync(newuser, "Member");
                await _signInManager.SignInAsync(newuser, true);
                return Content("Zehmet olmasa Email unvaniniza baxin");
            }

           
        }
        //Email send message Password Change
        public async Task<IActionResult> Check(string checkemail)
        {
            var callbackUrl = Url.ActionLink(
               
                "ChangePassword","Account",new { email=checkemail }, protocol:HttpContext.Request.Scheme);
            EmailServices emailServices = new EmailServices();
            await emailServices.SendEmailAsync(checkemail, "Password Deyismek ucun linke click edin",$"Password Change:<a href='{callbackUrl}'>Link</a>"
                ) ;
            return RedirectToAction("Login", "Account");
        }
       
        
        public async Task<IActionResult> ChangePassword(string email)
        {
            if (email == null) return NotFound();
            User newpassworduser = await _userManager.FindByEmailAsync(email);
            if (newpassworduser == null) return NotFound();
            ViewBag.Checkemail = newpassworduser;
            return View();
        }
        //ChangePassword Httpost 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(string newpassworduser, string NewPassword)
        {
            if (newpassworduser == null) return NotFound();
            User user = await _userManager.FindByNameAsync(newpassworduser);
            if (user == null) return NotFound();
            string token = await _userManager.GeneratePasswordResetTokenAsync(user);
            IdentityResult identityresult = await _userManager.ResetPasswordAsync(user, token, NewPassword);

            if (!identityresult.Succeeded)
            {
                foreach (var error in identityresult.Errors)
                {
                    ModelState.AddModelError("", error.Description);

                }
                return View();
            }
            return RedirectToAction("Index","Home");
        }

        //Confirmemail in SignUp
        public async Task<IActionResult> ConfirmEmail(string userId, string codes)
        {
            if (userId == null || codes == null)
            {
                return View("Error");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Error");
            }
            var result = await _userManager.ConfirmEmailAsync(user, codes);

            if (result.Succeeded)
            {
               
                return RedirectToAction("Index", "Home");
            }

            else
            {
                return View("Error");
            }
        }
        //Logout in usersystem
        public  async  Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Home");
        }

        //public async Task CreateRole()
        //{

        //    if (!await _roleManager.RoleExistsAsync("Admin"))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
        //    }
        //    if (!await _roleManager.RoleExistsAsync("Member"))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole { Name = "Member" });
        //    }


        //}
    }
}