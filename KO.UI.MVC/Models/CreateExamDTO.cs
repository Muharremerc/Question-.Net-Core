using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KO.UI.MVC.Models
{
    public class CreateExamDTO
    {
        [Required]
        public string Title{ get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public List<QuestionDTO> Question { get; set; }
       

    }
}
