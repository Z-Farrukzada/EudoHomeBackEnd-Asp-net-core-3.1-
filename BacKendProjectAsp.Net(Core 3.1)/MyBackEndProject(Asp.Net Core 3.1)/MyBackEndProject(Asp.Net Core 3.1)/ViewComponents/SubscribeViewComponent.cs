using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.ViewComponents
{
    public class SubscribeViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {


            return View();
        }
    }
}
