using System;
using System.Collections.Generic;
using System.Text;

namespace KO.Core
{
   public class BaseClass
    {
        public BaseClass()
        {
            CreatedDate = DateTime.Now;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
