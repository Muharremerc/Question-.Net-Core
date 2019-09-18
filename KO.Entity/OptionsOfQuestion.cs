using KO.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KO.Entity
{
   public class OptionsOfQuestion:BaseClass
    {
        [Required]
        public int QuestionOfExamID { get; set; }
        [Required]
        public string Option { get; set; }
        public bool IsCorrect { get; set; }

        public virtual QuestionOfExam QuestionOfExam { get; set; }
    }
}
