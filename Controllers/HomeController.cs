using AlphaService.Helpers;
using AlphaService.Models;
using AlphaService.Models.ViewModels;
using AlphaService.Repositories.Interfaces;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaService.Controllers
{
    public class HomeController : Controller
    {
        private readonly AlphaServiceContext _context;
        private readonly IAuthRepository _authRepository;
        private readonly IOrdersRepository _ordersRepository;
        private IConverter _converter;

        public HomeController(AlphaServiceContext context, IAuthRepository authRepository, IOrdersRepository ordersRepository, IConverter converter)
        {
            _context = context;
            _authRepository = authRepository;
            _ordersRepository = ordersRepository;
            _converter = converter;
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (TempData["RegistrationSuccess"] != null)
            {
                ModelState.AddModelError("SuccessKey", TempData["RegistrationSuccess"].ToString());
            }
            if (TempData["RegistrationError"] != null)
            {
                ModelState.AddModelError("ErrorKey", TempData["RegistrationError"].ToString());
            }
            if (TempData["PassChange"] != null)
            {
                ModelState.AddModelError("PassChangeKey", TempData["PassChange"].ToString());
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(User model)
        {
            var hashedPass = Md5Hasher.GetMd5Hash(model.Password, "KODIUS");
            var user = await _authRepository.UserLoginAsync(model, hashedPass);


            if (user != null)
            {
                HttpContext.Session.SetString("_User", user.Email);
                HttpContext.Session.SetInt32("_UserId", user.UserId);
                return RedirectToAction("Dashboard", "Home");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(User model)
        {
            var hashedPass = Md5Hasher.GetMd5Hash(model.Password, "KODIUS");

            if (ModelState.IsValid)
            {
                var user = _authRepository.UserRegistrationAsync(model, hashedPass);

                if (user != null)
                {
                    _context.Users.Add(user);
                    _context.SaveChanges();

                    TempData["RegistrationSuccess"] = "User was successfully created";
                    return RedirectToAction("Index", "Home");
                }
            }
            TempData["RegistrationError"] = "User could not be registered";
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("_User");
            HttpContext.Session.Remove("_UserId");

            return RedirectToAction("Home", "Index");
        }
        [HttpGet]
        public IActionResult ResetPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            

            if (ModelState.IsValid)
            {
                var user = await _authRepository.GetUserByUsernameAsync(model.Email);
                var hashedPass = Md5Hasher.GetMd5Hash(model.Password, "KODIUS");

                if (user != null && (model.Password == model.ConfirmPassword))
                {
                    user.Password = hashedPass;
                    _context.SaveChanges();
                    TempData["PassChange"] = "Password was successfully changed.";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["PasswordResetError"] = "Something went wrong!";
                    ModelState.AddModelError("PasswordKey", TempData["PasswordResetError"].ToString());
                    return View();
                }

            }
            return View();
        }
        public async Task<IActionResult> Dashboard()
        {
            if(TempData["OrderMessage"] != null)
            {
                ModelState.AddModelError("OrderKey", TempData["OrderMessage"].ToString());
            }
            var loggedUser = HttpContext.Session.GetString("_User");
            var order = await _ordersRepository.GetUserOrdersAsync(loggedUser);
            return View(order);
        }

        public IActionResult CreateDocument()
        {
            var user = HttpContext.Session.GetInt32("_UserId");
            var vm = _ordersRepository.GetOrderDetails(user);
            
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "PDF Report",
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = TemplateGenerator.GetHTMLString((int)user,vm),
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "styles.css") },
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
            };
            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };
            var file = _converter.Convert(pdf);
            return File(file, "application/pdf");
        }
    }
}
