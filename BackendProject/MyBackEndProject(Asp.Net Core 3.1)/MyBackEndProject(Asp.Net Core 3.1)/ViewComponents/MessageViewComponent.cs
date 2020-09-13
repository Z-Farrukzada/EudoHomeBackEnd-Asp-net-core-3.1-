using Microsoft.AspNetCore.Mvc;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.ViewComponents
{
    public class MessageViewComponent:ViewComponent
    {
        
        public async Task<IViewComponentResult> InvokeAsync()
        {

            
            return View();
        }
    }
}
