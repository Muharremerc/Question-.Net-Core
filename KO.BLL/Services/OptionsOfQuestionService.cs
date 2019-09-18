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
    public class OptionsOfQuestionService : IOptionsOfQuestionService
    {
        private readonly IOptionsOfQuestionRepository _optionsOfQuestionRepository;
        public OptionsOfQuestionService(IOptionsOfQuestionRepository optionsOfQuestionRepository)
        {
            _optionsOfQuestionRepository = optionsOfQuestionRepository;
        }
        public int Add(OptionsOfQuestion entity)
        {
            _optionsOfQuestionRepository.Add(entity);
            return entity.ID;
        }

        public ICollection<OptionsOfQuestion> All()
        {
            throw new NotImplementedException();
        }

        public ICollection<OptionsOfQuestion> All(Expression<Func<OptionsOfQuestion, bool>> predicate)
        {
          
            return _optionsOfQuestionRepository.All(predicate);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public OptionsOfQuestion Get(int id)
        {
            throw new NotImplementedException();
        }

        public OptionsOfQuestion Get(Expression<Func<OptionsOfQuestion, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(OptionsOfQuestion entity)
        {
            throw new NotImplementedException();
        }
    }
}
