using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {


            return View();
        }
    }
}