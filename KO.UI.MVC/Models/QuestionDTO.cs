using KO.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KO.UI.MVC.Models
{
    public class QuestionDTO
    {
        [Required]
        public string Question { get; set; }
        public char Answer { get; set; }
        public List<OptionsOfQuestion> Options { get; set; }
    }
}
