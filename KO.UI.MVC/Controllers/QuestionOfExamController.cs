using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KO.BLL.Interfaces;
using KO.Entity;
using KO.UI.MVC.Filters;
using KO.UI.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace KO.UI.MVC.Controllers
{
    public class QuestionOfExamController : Controller
    {
        IExamService _examService;
        IQuestionOfExamService _questionOfExamService;
        IOptionsOfQuestionService _optionsOfQuestionService;
        public QuestionOfExamController(IExamService examService, IQuestionOfExamService questionOfExamService, IOptionsOfQuestionService optionsOfQuestionService)
        {
            _examService = examService;
            _questionOfExamService = questionOfExamService;
            _optionsOfQuestionService = optionsOfQuestionService;
        }
        [ServiceFilter(typeof(MemberFilterAttribute))]
        public IActionResult Index(int id)
        {
            Exam exam = _examService.Get(x => x.ID == id);
            CreateExamDTO returnexam = new CreateExamDTO
            {
                Title = exam.Header,
                Question = _questionOfExamService.All(x => x.ExamID == exam.ID)
                            .Select(y => new QuestionDTO { Question = y.Question    
                                , Options = _optionsOfQuestionService.All(z => z.QuestionOfExamID == y.ID).ToList()
                                     }).ToList(),
                Description=exam.Description
             };
            return View(returnexam);
        }
    }
}