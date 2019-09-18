using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KO.BLL.Interfaces;
using KO.UI.MVC.Filters;
using Microsoft.AspNetCore.Mvc;
using KO.UI.MVC.Helper;
using KO.Entity;

namespace KO.UI.MVC.Controllers
{
    [ServiceFilter(typeof(MemberFilterAttribute))]
    public class MemberController : Controller
    {
        private readonly IMemberService _memberService;
        private readonly IExamService _examService;
        public MemberController(IMemberService memberService, IExamService examService)
        {
            _memberService = memberService;
            _examService = examService;
        }
        public IActionResult Index()
        {
            return View(_examService.All(x=>x.MemberID==HttpContext.Session.GetObjectFromJson<Member>("Member").ID && x.IsDeleted==false));
        }
    }
}