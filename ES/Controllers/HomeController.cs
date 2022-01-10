using ES.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ES.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public ActionResult GetData()
        {
            var query = _context.SoLieu.Select(s => new HienThiSoLieuModel()
            {
                MatTroi_HienTai = s.MT_HT,
                Gio_HienTai = s.G_HT,
                SinhKhoi_HienTai = s.SK_HT,
                Tong_HienTai = s.T_HT,
                ThoiGian = s.ThoiGian.ToString("dd/MM/yyyy")
            }).ToList();
            return Json(query);
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
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
