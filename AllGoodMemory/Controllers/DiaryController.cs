﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AllGoodMemory.Controllers
{
    public class DiaryController : Controller
    {
        // GET: Dariy
        public ActionResult Index()
        {
            return View();
        }
    }
}