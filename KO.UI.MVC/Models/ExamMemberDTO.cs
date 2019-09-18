using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KO.UI.MVC.Models
{
    public class ExamMemberDTO
    {
        public int ID { get; set; }
        public string Header { get; set; }
        public string Creater { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
