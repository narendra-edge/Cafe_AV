﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cafe_AV.Controllers
{
    public class AppExceptionControllerr : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
