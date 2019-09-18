using KO.BLL.Interfaces;
using KO.DAL.Interfaces;
using KO.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KO.BLL.Services
{
    public class ExamsOfMemberService : IExamsOfMemberService
    {
        IExamsOfMemberRepository _examsOfMemberRepository;
        public ExamsOfMemberService(IExamsOfMemberRepository examsOfMemberRepository)
        {
            _examsOfMemberRepository = examsOfMemberRepository;
        }

        public int Add(ExamsOfMember entity)
        {
            _examsOfMemberRepository.Add(entity);
            return entity.ID;
        }

        public ICollection<ExamsOfMember> All()
        {
            throw new NotImplementedException();
        }

        public ICollection<ExamsOfMember> All(Expression<Func<ExamsOfMember, bool>> predicate)
        {
            return _examsOfMemberRepository.All(predicate);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ExamsOfMember Get(int id)
        {
            throw new NotImplementedException();
        }

        public ExamsOfMember Get(Expression<Func<ExamsOfMember, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(ExamsOfMember entity)
        {
            throw new NotImplementedException();
        }
    }
}
