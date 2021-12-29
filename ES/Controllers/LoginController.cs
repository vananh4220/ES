using ES.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ES.Controllers
{
    public class LoginController : Controller
    {
        private readonly DataContext _context;
        public LoginController(DataContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View("Index");
        }
        [HttpPost]
        public ActionResult Verify(Account acc)
        {
            if (acc.Username != null && acc.Password != null)
            {
                var query = _context.Accounts.Where(x => x.Username == acc.Username && x.Password == acc.Password).FirstOrDefault();
                if (query != null)
                {
                    HttpContext.Session.SetInt32("IDSession", query.ID);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Username = acc.Username;
                    ViewBag.Verify = "Username hoặc Password không đúng";
                    return View("Index");
                }
            }
            else
            {
                if (acc.Username != null) ViewBag.Username = acc.Username;
                ViewBag.Verify = "Vui lòng nhập Username và Password";
                return View("Index");
            }

        }
    }
}

