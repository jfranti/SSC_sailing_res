﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SSC_Resevations.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SSC_Resevations.Controllers
{
    public class BoatsController : Controller
    {
        // GET: /<controller>/
        private SSC_ReservationsContext db = new SSC_ReservationsContext();
        public IActionResult Index()
        {
            return View();
        }
    }
}
