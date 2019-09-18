using KO.BLL.Interfaces;
using KO.DAL.Interfaces;
using KO.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KO.BLL.Services
{
    public class ExamService : IExamService
    {
        private readonly IExamRepository _examRepository;
        public ExamService(IExamRepository examRepository)
        {
            _examRepository = examRepository;
        }
        public int Add(Exam entity)
        {
            _examRepository.Add(entity);
            return entity.ID;
        }

        public ICollection<Exam> All()
        {
            return _examRepository.All();
        }

        public ICollection<Exam> All(Expression<Func<Exam, bool>> predicate)
        {
            return _examRepository.All(predicate);
        }

        public void Delete(int id)
        {
            var tempExam =_examRepository.Get(id);
            tempExam.IsDeleted = true;
            _examRepository.Update(tempExam);
        }

        public Exam Get(int id)
        {
            throw new NotImplementedException();
        }

        public Exam Get(Expression<Func<Exam, bool>> predicate)
        {
            return _examRepository.Get(predicate);

        }

        public void Update(Exam entity)
        {
            throw new NotImplementedException();
        }
    }
}
