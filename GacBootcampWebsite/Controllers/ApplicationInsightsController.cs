﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GacBootcampWebsite.Models;

namespace GacBootcampWebsite.Controllers
{
    public class ApplicationInsightsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
