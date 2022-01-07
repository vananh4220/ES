using ES.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ES.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var IDSession = HttpContext.Session.GetInt32("IDSession");
            if(IDSession == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else return View();
        }
        
        public ActionResult GetData()
        {
            var query = _context.SoLieu.Select(s => new HienThiSoLieuModel()
            {
                MT_HT = s.MT_HT,
                G_HT = s.G_HT,
                SK_HT = s.SK_HT,
                T_HT = s.T_HT,
                ThoiGian = s.ThoiGian.ToString("dd/MM/yyyy")
            }).ToList();
            return Json(query);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
