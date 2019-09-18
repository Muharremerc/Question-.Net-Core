using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KO.BLL.Interfaces;
using KO.UI.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using KO.UI.MVC.Helper;

namespace KO.UI.MVC.Controllers
{
    public class LoginController : Controller
    {

        private readonly IMemberService _memberService;
        public LoginController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginPostDTO loginPostDTO)
        {
            var tempMember = _memberService.Get(x => x.Username == loginPostDTO.Username && x.Password == loginPostDTO.Password);
            if (tempMember == null)
            {
                TempData["Err"] = "Incorrect username of password";
                return RedirectToAction("Index");
            }
            //session comment
            HttpContext.Session.SetObjectAsJson("Member", tempMember);
            return RedirectToAction("Index", "Member");
        }
    }
}