using KO.Core;
using KO.DAL.Interfaces;
using KO.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.DAL.Repositories
{
    public class OptionsOfQuestionRepository : Repository<OptionsOfQuestion, KO_DBContext>, IOptionsOfQuestionRepository
    {
        public OptionsOfQuestionRepository(KO_DBContext dbContext) : base(dbContext)
        {
        }
    }
}
