using AlejoPreschedule.Data;
using AlejoPreschedule.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Preschedule.Models;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Preschedule.Controllers
{
    [Authorize]
    public class VisitorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public VisitorsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: Visitors
       
        public ActionResult Index()
        {
            //var user = from s in _context.Schedule select s;
            //return View(user);
            var userId = _userManager.GetUserId(HttpContext.User);
           

            return View((from g in _context.Schedule where g.UserId == userId select g).ToList());



        }

        // GET: Visitors/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Visitors/Create
        public ActionResult Create()
        {

           
            return View();
        }

        //POST: Visitors/Create
       [HttpPost]
       [ValidateAntiForgeryToken]
        public ActionResult Create(ScheduleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
     
            _context.Add(model.schedule);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        // GET: Visitors/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Visitors/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(List));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Visitors/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Visitors/Delete/5
       
        static char[] validChars = {'2','3','4','5','6','7','8','9','A','B','C','D','E','F',
                'G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };
        const string hashkey = "password";
        const int codelength = 6;

        string GetCodeForEmail(string address)
        {
            byte[] hash;
            using (HMACSHA1 sha1 = new HMACSHA1(ASCIIEncoding.ASCII.GetBytes(hashkey)))
                hash = sha1.ComputeHash(UTF8Encoding.UTF8.GetBytes(address));
            int startpos = hash[hash.Length - 1] % (hash.Length - codelength);
            StringBuilder passBuilder = new StringBuilder();
            for (int i = startpos; i < startpos + codelength; i++)
            {
                passBuilder.Append(validChars[hash[i] % validChars.Length]);
                return passBuilder.ToString();
            }
            return address;
        }
    
        
    }

}