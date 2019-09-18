using KO.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.Entity
{
    public class Member:BaseClass
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }


        public virtual ICollection<ExamsOfMember>ExamsOfMembers { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
    }
}
