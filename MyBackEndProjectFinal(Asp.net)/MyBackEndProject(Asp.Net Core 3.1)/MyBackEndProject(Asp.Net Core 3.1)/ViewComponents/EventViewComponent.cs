﻿using Microsoft.AspNetCore.Mvc;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.ViewComponents
{
    public class EventViewComponent:ViewComponent
    {
        private readonly AppDbcontext _db;
        public EventViewComponent(AppDbcontext db)
        {
            _db = db;

        }
        public async Task<IViewComponentResult> InvokeAsync(int count,int skip)
        {

            IEnumerable<NewEvent> newEvents = _db.NewEvents.Skip(skip).Take(count);
            return View(await Task.FromResult(newEvents));
        }
    }
}
