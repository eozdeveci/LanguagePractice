using LanguagePractice.Core.Utilities.Results;
using LanguagePractice.Data.Abstract;
using LanguagePractice.Data.Constants;
using LanguagePractice.DataAccess.Abstract;
using LanguagePractice.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Data.Concrete
{
    public class EngWordManager : IEngWordService
    {
        private IEngWordDal _engWordDal;
        public EngWordManager(IEngWordDal engWordDal)
        {
            _engWordDal = engWordDal;
        }
        public IResult Add(EngWord engWord)
        {
            var wordToCheck = _engWordDal.Get(w => w.Name == engWord.Name);
            if(wordToCheck != null)
                new ErrorResult(Messages.RecordAlreadyExists);
            _engWordDal.Add(engWord);
            return new SuccessResult(Messages.RecordAdded);
        }

        public IDataResult<List<EngWord>> GetAll()
        {
            return new SuccessDataResult<List<EngWord>>(_engWordDal.GetAll());
        }

        public IDataResult<EngWord> GetById(int id)
        {
            return new SuccessDataResult<EngWord>(_engWordDal.Get(w => w.Id == id));
        }

        public IResult Update(EngWord engWord)
        {
            var wordToUpdate = _engWordDal.Get(w => w.Id == engWord.Id);
            if (wordToUpdate == null)
                new ErrorResult(Messages.RecordNotFound);
            _engWordDal.Update(engWord);
            return new SuccessResult(Messages.RecordUpdated);
        }
    }
}