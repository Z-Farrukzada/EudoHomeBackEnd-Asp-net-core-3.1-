using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}