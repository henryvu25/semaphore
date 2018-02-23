using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using semaphore_proj.Models;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace semaphore_proj.Controllers
{
    public class HomeController : Controller
    {
        private SemContext _context;

        public HomeController(SemContext context)
        {
            _context = context;
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.errors = ModelState.Values;

            string userExists = HttpContext.Session.GetString("existing");
            ViewBag.exists = userExists;

            ViewBag.incorrect = TempData["incorrect"];
            return View();
        }

        [HttpPost]
        [Route("process")]
        public IActionResult Process(RegisterViewModel model)
        {
            User existingUser = _context.users.SingleOrDefault(user => user.email == model.email);

            if (ModelState.IsValid && existingUser == null)
            {
                User newUser = new User
                {
                    first = model.first,
                    last = model.last,
                    email = model.email,
                    password = model.password,
                    created = DateTime.Now,
                    updated = DateTime.Now
                };
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.password = Hasher.HashPassword(newUser, newUser.password);
                _context.users.Add(newUser);
                _context.SaveChanges();
                User currUser = _context.users.SingleOrDefault(user => user.email == model.email);
                int currId = currUser.userid;
                HttpContext.Session.SetInt32("currId", currId);
                return RedirectToAction("Dashboard", "Sem");
            }
            if (existingUser != null)
            {
                HttpContext.Session.SetString("existing", "Email has already been used");
                return RedirectToAction("Index");
            }
            ViewBag.errors = ModelState.Values;
            return View("Index");
        }


        [HttpPost]
        [Route("login")]
        public IActionResult Login(string email, string password)
        {
            User currUser = _context.users.SingleOrDefault(user => user.email == email);
            if (currUser != null && password != null)
            {
                var Hasher = new PasswordHasher<User>();
                if (0 != Hasher.VerifyHashedPassword(currUser, currUser.password, password))
                {
                    int currId = currUser.userid;
                    HttpContext.Session.SetInt32("currId", currId);
                    return RedirectToAction("Dashboard", "Sem");
                }
                else
                {
                    TempData["incorrect"] = "Email and/or password are incorrect";
                }
            }
            TempData["incorrect"] = "Email and/or password are incorrect";
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
