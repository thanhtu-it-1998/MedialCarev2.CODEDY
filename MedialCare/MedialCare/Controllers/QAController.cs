﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Controllers
{
    public class QAController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}