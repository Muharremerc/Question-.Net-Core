using KO.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.Entity
{
    public class QuestionOfExam:BaseClass
    {
        public int ExamID { get; set; }
        public string Question { get; set; }


        public virtual Exam Exam { get; set; }
        public virtual ICollection<OptionsOfQuestion> OptionsOfQuestions{ get; set; }
    }
}
