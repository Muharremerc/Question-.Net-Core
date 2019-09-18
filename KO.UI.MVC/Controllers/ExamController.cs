using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KO.BLL.Interfaces;
using KO.Entity;
using KO.UI.MVC.Filters;
using KO.UI.MVC.Helper;
using KO.UI.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KO.UI.MVC.Controllers
{


    public class ExamController : Controller
    {
        private readonly IExamService _examService;
        private readonly IMemberService _memberService;
        private readonly IQuestionOfExamService _questionOfExamService;
        private readonly IOptionsOfQuestionService _optionsOfQuestionService;

        public ExamController(IExamService examService, IMemberService memberService, IQuestionOfExamService questionOfExamService, IOptionsOfQuestionService optionsOfQuestionService)
        {
            _examService = examService;
            _memberService = memberService;
            _questionOfExamService = questionOfExamService;
            _optionsOfQuestionService = optionsOfQuestionService;
        }
        public IActionResult Index()
        {
            List<ExamMemberDTO> examMemberDTO = new List<ExamMemberDTO>();
            Member _tempmember;
            var tempExamList = _examService.All(x => x.IsDeleted == false);
            if (tempExamList != null)
            {
                foreach (var item in tempExamList)
                {
                    _tempmember = _memberService.Get(x => x.ID == item.MemberID);
                    examMemberDTO.Add(new ExamMemberDTO
                    {
                        CreatedDate = item.CreatedDate,
                        Creater = _tempmember.Name,// +" "+ _tempmember, for surname
                        Header = item.Header,
                        ID = item.ID
                    });
                }

            }
            return View(examMemberDTO);
        }
        [ServiceFilter(typeof(MemberFilterAttribute))]
        public IActionResult Create()
        {
            List<SubjectDTO> subjects = RSSHelper.GetSubjects("https://www.wired.com/feed/rss").ToList();
            List<SelectListItem> subjectsSelect = new List<SelectListItem>();
            foreach (var item in subjects.Take(5))
            {
                subjectsSelect.Add(new SelectListItem
                {
                    Text = item.Title,
                    Value = item.Description

                });
            }
            ViewBag.Subject = subjectsSelect;
            return View();
        }
        [ServiceFilter(typeof(MemberFilterAttribute))]
        [HttpPost]
        public IActionResult Create(CreateExamDTO Exam)
        {
            var a = RSSHelper.GetSubjects("https://www.wired.com/feed/rss");
            int examID = _examService.Add(new Entity.Exam
            {
                Header = a.Where(x=>x.Description== Exam.Description).FirstOrDefault().Title,
                MemberID = HttpContext.Session.GetObjectFromJson<Member>("Member").ID,
                Description = Exam.Description
            });
            foreach (var item in Exam.Question)
            {
                int quesID = _questionOfExamService.Add(
                    new QuestionOfExam
                    {
                        ExamID = examID,
                        Question = item.Question
                    }
                    );
                for (int i = 0; i < 4; i++)
                {
                    _optionsOfQuestionService.Add(new OptionsOfQuestion
                    {
                        Option = item.Options[i].Option,
                        QuestionOfExamID = quesID,
                        IsCorrect = ((Convert.ToInt32(item.Answer) - 65) == i) ? true : false
                    });

                }
                foreach (var item2 in item.Options)
                {
                    
                }
            }
            return RedirectToAction("Index", "Member");
        }
        [ServiceFilter(typeof(MemberFilterAttribute))]
        public IActionResult _Desc(string test)
        {

            return PartialView("_Desc", test);
        }

        [ServiceFilter(typeof(MemberFilterAttribute))]
        public ActionResult Delete(int id)
        {
            _examService.Delete(id);
            return RedirectToAction("Index", "Member");
        }
    }
}