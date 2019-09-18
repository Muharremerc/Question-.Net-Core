using KO.Core;
using KO.DAL.Interfaces;
using KO.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.DAL.Repositories
{
    public class MemberRepository : Repository<Member, KO_DBContext>, IMemberRepository
    {
        public MemberRepository(KO_DBContext dbContext) : base(dbContext)
        {
        }
    }
}
