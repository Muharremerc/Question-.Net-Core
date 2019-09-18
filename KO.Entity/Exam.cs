using KO.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.Entity
{
    public class Exam:BaseClass
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public int MemberID { get; set; }


        public virtual Member Member { get; set; }
        public virtual ICollection<QuestionOfExam> QuestionOfExams{ get; set; }
    }
}
