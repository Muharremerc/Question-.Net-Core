using KO.Core;
using KO.DAL.Interfaces;
using KO.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.DAL.Repositories
{
    public class ExamsOfMemberRepository : Repository<ExamsOfMember, KO_DBContext>, IExamsOfMemberRepository
    {
        public ExamsOfMemberRepository(KO_DBContext dbContext) : base(dbContext)
        {
        }
    }
}
