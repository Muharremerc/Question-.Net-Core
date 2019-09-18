using KO.Core;
using KO.DAL.Interfaces;
using KO.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.DAL.Repositories
{
    public class QuestionOfExamRepository : Repository<QuestionOfExam, KO_DBContext>, IQuestionOfExamRepository
    {
        public QuestionOfExamRepository(KO_DBContext dbContext) : base(dbContext)
        {
        }
    }
}
