using ES.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

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
        public ActionResult VerifyLogin(Account acc)
        {
            if (acc.Username != null && acc.Password != null)
            {

                string Password = MD5Encryption(acc.Password);
                var query = _context.Account
                            .Where(x => x.Username == acc.Username && x.Password == Password)
                            .FirstOrDefault();
                if (query != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, acc.Username)
                    };
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);
                    var props = new AuthenticationProperties();
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props).Wait();
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
        
        public ActionResult Register ()
        {
            return View("Register");          
        }
        [HttpPost]
        public ActionResult VerifyRegister(Account acc)
        {
            if (acc.Username != null && acc.Password != null)
            {
                var query = _context.Account
                            .Where(x => x.Username == acc.Username)
                            .FirstOrDefault();
                if (query == null)
                {
                    string Password = MD5Encryption(acc.Password);
                    var account = new Account
                    {
                        Username = acc.Username,
                        Password = Password
                    };
                    _context.Add<Account>(account);
                    _context.SaveChanges();
                    return View("Index");
                }
                else
                {
                    ViewBag.Username = acc.Username;
                    ViewBag.Verify = "Username đã tồn tại";
                    return View("Register");
                }

            }
            else
            {
                if (acc.Username != null) ViewBag.Username = acc.Username;
                ViewBag.Verify = "Vui lòng nhập Username và Password";
                return View("Register");
            }
        }
        public static string MD5Encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] array = Encoding.UTF8.GetBytes(password);
            array = md5.ComputeHash(array);
            StringBuilder sb = new StringBuilder();

            foreach (byte ba in array)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
    }
    
}

