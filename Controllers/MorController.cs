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
    public class MorController : Controller
    {
        private SemContext _context;

        public MorController(SemContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("morseprac")]
        public IActionResult Morsepractice()
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            ViewBag.user = currUser;
            //morse leveler
            if(currUser.morxp > 99)
            {
                currUser.morlevel = 1;
                _context.SaveChanges();
            }
            if(currUser.morxp > 299)
            {
                currUser.morlevel = 2;
                _context.SaveChanges();
            }
            if(currUser.morxp > 599)
            {
                currUser.morlevel = 3;
                _context.SaveChanges();
            }
            if(currUser.morxp > 999)
            {
                currUser.morlevel = 4;
                _context.SaveChanges();
            }
            if(currUser.morxp > 1499)
            {
                currUser.morlevel = 5;
                _context.SaveChanges();
            }
            if(currUser.morxp > 2099)
            {
                currUser.morlevel = 6;
                _context.SaveChanges();
            }
            if(currUser.morxp > 2799)
            {
                currUser.morlevel = 7;
                _context.SaveChanges();
            }
            if(currUser.morxp > 3599)
            {
                currUser.morlevel = 8;
                _context.SaveChanges();
            }
            if(currUser.morxp > 4499)
            {
                currUser.morlevel = 9;
                _context.SaveChanges();
            }
            if(currUser.morxp > 5499)
            {
                currUser.morlevel = 10;
                _context.SaveChanges();
            }
            return View();
        }
        [HttpGet]
        [Route("morseintro")]
        public IActionResult Morseintro()
        {
            return View();
        }
        [HttpPost]
        [Route("alphabet")]
        public IActionResult Alphabet(string alphabet)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string alphaAnswer = ".-/-.../-.-./----/-.././..-./--./..../../.---/-.-/.-../--/-./---/.--./--.-/.-./.../-/..-/...-/.--/-..-/-.--/--..";
            if(alphabet == alphaAnswer)
            {
                currUser.morxp += 27;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("onea")]
        public IActionResult OneA(string onea)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string oneaAnswer = "-/..../../././..-/.../-./..../../--/---/---/../-..-/.../.-/-./--./.../-../.-/.-/-./--./-./--./.-/-.--/--.-";
            if(onea == oneaAnswer)
            {
                currUser.morxp += 30;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("oneb")]
        public IActionResult OneB(string oneb)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string onebAnswer = "-../-../../././--/--../-/---/---/-../-../---/.--/../--.-/.../---/---/-./--./.../..../..-/.--/---/.--/-./--./-.../.-/-.--/-./--./..-/-.--/././-./.---/-.-./.-/.-/..-/--.-";
            if(oneb == onebAnswer)
            {
                currUser.morxp += 45;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("twoa")]
        public IActionResult TwoA(string twoa)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string twoaAnswer = "-/..../../././..-/.../-./..../../-/..../.-/-./..../.../-/..../././--../-./..../../././--/.---/--/.-/.-/..-/--.-";
            if(twoa == twoaAnswer)
            {
                currUser.morxp += 33;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("twob")]
        public IActionResult TwoB(string twob)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string twobAnswer = "-/---/---/-./.../..-/-./--./--.-/.-./..-/.--/---/.--/-.-./.../.-../././-..-/-./..../.-/--.-/-.-./..../.-/.-/..-/--.-/...-/../././-./--./.../-/..../.-/.--/--";
            if(twob == twobAnswer)
            {
                currUser.morxp += 42;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("threea")]
        public IActionResult ThreeA(string threea)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string threeaAnswer = "-/..../../././..-/.../-./..../../-/..../.-/-./..../.../--./../.-/.../-.-./..../..-/.-/.../-./.-/.--/--/--.-";
            if(threea == threeaAnswer)
            {
                currUser.morxp += 30;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("threeb")]
        public IActionResult ThreeB(string threeb)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string threebAnswer = "-./..../../-./--.-/.-../././-./.--./..../.-/.-/-./.../-.-/..../---/.--/../--../-.-./..../..-/-.--/././-./-.-./.-/.-/-./--.-/..../-.--/.../../-./....";
            if(threeb == threebAnswer)
            {
                currUser.morxp += 39;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("foura")]
        public IActionResult FourA(string foura)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string fouraAnswer = "-/..../../././..-/.../-./..../../-./..../---/.--/--.-/--/./.---/-../-../../-./..../-./../-./....";
            if(foura == fouraAnswer)
            {
                currUser.morxp += 27;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("fourb")]
        public IActionResult FourB(string fourb)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string fourbAnswer = "--.-/..-/-.--/././-/.../.-../.-/--/--.-/--./..-/.--/---/.--/-./--./.../.-/-./--./.../-..-/..-/.--/-./--./.../-../.-/-./..../-/---/---/-./--./-../-../---/---/--.-";
            if(fourb == fourbAnswer)
            {
                currUser.morxp += 43;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("fivea")]
        public IActionResult FiveA(string fivea)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string fiveaAnswer = "-/..../../././..-/.../-./..../../--/---/../.---/...-/../././-.-./.---/-./..../---/--../-/---";
            if(fivea == fiveaAnswer)
            {
                currUser.morxp += 26;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("fiveb")]
        public IActionResult FiveB(string fiveb)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string fivebAnswer = "-/../-./..../-/..../.-/.-/-./--.-/...-/.-/.-/-./--./.--./..../..-/-.-./.---/-.-./..../..-/-.--/././-./.-../---/-../-../.-/.-/--/.---/-../-../.-/--.-";
            if(fiveb == fivebAnswer)
            {
                currUser.morxp += 39;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("sixa")]
        public IActionResult SixA(string sixa)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string sixaAnswer = "-/..../../././..-/.../-./..../../-../-../.-/.--/--/--.-/-/..../.-/.--/--/.../-./././-/.../-./.-";
            if(sixa == sixaAnswer)
            {
                currUser.morxp += 29;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("sixb")]
        public IActionResult SixB(string sixb)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string sixbAnswer = "-./---/../.../-./.-/.--/-./--./..../.-/-./..../--.-/-../-../---/---/-./--./.---/-./---/-./-..-/-./.-/--.-/-/.-./.-/.--/-./--./.../-/.-./---/-./--.";
            if(sixb == sixbAnswer)
            {
                currUser.morxp += 40;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("sevena")]
        public IActionResult SevenA(string sevena)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string sevenaAnswer = "-/..../../././..-/.../-./..../../-.../.-/-.-./.../.-/../.../--/---/---/-/.---/.-../---/-./--./--.-";
            if(sevena == sevenaAnswer)
            {
                currUser.morxp += 27;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("sevenb")]
        public IActionResult SevenB(string sevenb)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string sevenbAnswer = "-/../--/.-../..-/---/---/-./--.-/..-/.-/-./--./--../-../-../.-/../.---/--/---/.--/../.../--/---/-./--./--./../..-/.--./.../-./--./..-/.--/---/.--/../--.-";
            if(sevenb == sevenbAnswer)
            {
                currUser.morxp += 41;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("eighta")]
        public IActionResult EightA(string eighta)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string eightaAnswer = "-/..../../././..-/.../-./..../../-./--./.-/-.--/-/..../.-/.--/-./--./--../-/.-./---/-./.---/-../-../---/.--/../--.-";
            if(eighta == eightaAnswer)
            {
                currUser.morxp += 32;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("eightb")]
        public IActionResult EightB(string eightb)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string eightbAnswer = "-./---/../.../.-../.-/--/--.-/-../-../..-/-./--./.../--/..-/.--/-.-./.---/-./--./..-/.--/---/.--/../--.-/-./--./..-/.--/---/.--/../--.-/-/../-./-.--/././..-";
            if(eightb == eightbAnswer)
            {
                currUser.morxp += 42;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("ninea")]
        public IActionResult NineA(string ninea)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string nineaAnswer = "-/..../../././..-/.../-./..../../-../..-/--.-/-.-/..../---/.../-/.-./.-/.--/--/-.-./..../../././..-/--.-";
            if(ninea == nineaAnswer)
            {
                currUser.morxp += 29;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("nineb")]
        public IActionResult NineB(string nineb)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string ninebAnswer = "-.-./..../..-/-/---/.-/-./--.-/-.../---/---/-./--../.--./..../.-/.-/-./.---/--/---/../.---/-../-../../././..-/--.-/-.-./..../.-/.--/--/-.-./..../..-/-.--/././-.";
            if(nineb == ninebAnswer)
            {
                currUser.morxp += 42;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("tena")]
        public IActionResult TenA(string tena)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string tenaAnswer = "-/..../../././..-/.../-./..../../-/..../..-/.--/-.-./.---/..../../././-./.---/..../---/.-/-/..../../././-./--.";
            if(tena == tenaAnswer)
            {
                currUser.morxp += 32;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
        [HttpPost]
        [Route("tenb")]
        public IActionResult TenB(string tenb)
        {
            int? currId = HttpContext.Session.GetInt32("currId");
            if(currId == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            User currUser = _context.users.SingleOrDefault(user => user.userid == currId);
            string tenbAnswer = "-.-./...././.--./.../--./..../../--/---/---/../-..-/-/---/---/../.../-.-./---/---/-./--./.---/-.../../././-./--/---/---/../-..-/-/..-/.-/.-/-./--.-";
            if(tenb == tenbAnswer)
            {
                currUser.morxp += 40;
                _context.SaveChanges();
            }
            return RedirectToAction("Morsepractice");
        }
    }
}