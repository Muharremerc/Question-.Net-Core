using KO.BLL.Interfaces;
using KO.DAL.Interfaces;
using KO.DAL.Repositories;
using KO.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KO.BLL.Services
{
    public class QuestionOfExamService : IQuestionOfExamService
    {
        private readonly IQuestionOfExamRepository _questionOfExamRepository;
        public QuestionOfExamService(IQuestionOfExamRepository questionOfExamRepository)
        {
            _questionOfExamRepository = questionOfExamRepository;
        }
        public int Add(QuestionOfExam entity)
        {
            _questionOfExamRepository.Add(entity);
            return entity.ID;
        }

        public ICollection<QuestionOfExam> All()
        {
            throw new NotImplementedException();
        }

        public ICollection<QuestionOfExam> All(Expression<Func<QuestionOfExam, bool>> predicate)
        {
            return _questionOfExamRepository.All(predicate);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public QuestionOfExam Get(int id)
        {
            throw new NotImplementedException();
        }

        public QuestionOfExam Get(Expression<Func<QuestionOfExam, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(QuestionOfExam entity)
        {
            throw new NotImplementedException();
        }
    }
}
