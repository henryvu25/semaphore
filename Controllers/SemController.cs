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
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            ViewBag.user = currUser;
            
            
            List<User> allUsers = _context.users.OrderByDescending(user => (user.semlevel + user.morlevel)).ToList();
            ViewBag.allUsers = allUsers;
            return View();
        }
        [HttpGet]
        [Route("introduction")]
        public IActionResult Introduction()
        {
            return View();
        }
        [HttpGet]
        [Route("practice")]
        public IActionResult Practice()
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            ViewBag.user = currUser;
            Random rand = new Random();
            ViewBag.letter = rand.Next(0,26) + "let.png";
            ViewBag.result = TempData["result"];
            return View();
        }
        [HttpPost]
        [Route("practice")]
        public IActionResult Practice(string practice, string match)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string letter = "";
            for(int i = 0; i < 26; i++)
            {
                if(match == i+"let.png")
                {
                    letter = alphabet[i].ToString();
                }
            }
            if(practice == letter)
            {
                currUser.semxp ++;
                _context.SaveChanges();
                TempData["result"] = "=D";
            }
            else
            {
                TempData["result"] = "=(";
            }
            //semaphore leveler
            if(currUser.semxp > 99)
            {
                currUser.semlevel = 1;
                _context.SaveChanges();
            }
            if(currUser.semxp > 299)
            {
                currUser.semlevel = 2;
                _context.SaveChanges();
            }
            if(currUser.semxp > 599)
            {
                currUser.semlevel = 3;
                _context.SaveChanges();
            }
            if(currUser.semxp > 999)
            {
                currUser.semlevel = 4;
                _context.SaveChanges();
            }
            if(currUser.semxp > 1499)
            {
                currUser.semlevel = 5;
                _context.SaveChanges();
            }
            if(currUser.semxp > 2099)
            {
                currUser.semlevel = 6;
                _context.SaveChanges();
            }
            if(currUser.semxp > 2799)
            {
                currUser.semlevel = 7;
                _context.SaveChanges();
            }
            if(currUser.semxp > 3599)
            {
                currUser.semlevel = 8;
                _context.SaveChanges();
            }
            if(currUser.semxp > 4499)
            {
                currUser.semlevel = 9;
                _context.SaveChanges();
            }
            if(currUser.semxp > 5499)
            {
                currUser.semlevel = 10;
                _context.SaveChanges();
            }
            return RedirectToAction("Practice");
        }
    }
}