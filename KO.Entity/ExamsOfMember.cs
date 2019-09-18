using KO.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.Entity
{
    public class ExamsOfMember:BaseClass  // ??????
    {
        public int MemberID { get; set; }
        public int ExampID { get; set; }
        public int CorrectCount { get; set; }
    }
}
