using KO.Core;
using KO.DAL.Interfaces;
using KO.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.DAL.Repositories
{
    public class ExamRepository : Repository<Exam, KO_DBContext>, IExamRepository
    {
        public ExamRepository(KO_DBContext dbContext) : base(dbContext)
        {
        }
    }
}
