using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using semaphore_proj.Models;
using System.Linq;

namespace semaphore_proj.Controllers
{
    public class SemController : Controller
    {
        private SemContext _context;

        public SemController(SemContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}