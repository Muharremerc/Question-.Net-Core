using KO.BLL.Interfaces;
using KO.DAL.Interfaces;
using KO.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KO.BLL.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository  _memberRepository;
        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }
        public int Add(Member entity)
        {
            if(IsContain(entity))
            {
                _memberRepository.Add(entity);
                return entity.ID;
            }
            return 0;
        }

        public ICollection<Member> All()
        {
            throw new NotImplementedException();
        }

        public ICollection<Member> All(Expression<Func<Member, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Member Get(int id)
        {
            throw new NotImplementedException();
        }

        public Member Get(Expression<Func<Member, bool>> predicate)
        {
            return _memberRepository.Get(predicate);
        }

        public bool IsContain(Member member)
        {
            return _memberRepository.Get(x => x.Username == member.Username) != null ? false : true;
        }

        public void Update(Member entity)
        {
            throw new NotImplementedException();
        }
    }
}
