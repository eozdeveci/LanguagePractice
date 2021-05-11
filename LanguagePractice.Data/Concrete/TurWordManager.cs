using LanguagePractice.Core.DataAccess;
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
    public class TurWordManager : ITurWordService
    {
        private ITurWordDal _turWordDal;
        public TurWordManager(ITurWordDal turWordDal)
        {
            _turWordDal = turWordDal;
        }
        public IResult Add(TurWord turWord)
        {
            var wordToCheck = _turWordDal.Get(w => w.Name == turWord.Name);
            if (wordToCheck != null)
                new ErrorResult(Messages.RecordAlreadyExists);
            _turWordDal.Add(turWord);
            return new SuccessResult(Messages.RecordAdded);
        }

        public void Delete(TurWord entity)
        {
            throw new NotImplementedException();
        }

        public TurWord Get(Expression<Func<TurWord, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TurWord>> GetAll()
        {
            return new SuccessDataResult<List<TurWord>>(_turWordDal.GetAll());
        }

        public IDataResult<TurWord> GetById(int id)
        {
            return new SuccessDataResult<TurWord>(_turWordDal.Get(w => w.Id == id));
        }

        public IResult Update(TurWord turWord)
        {
            var wordToUpdate = _turWordDal.Get(w => w.Name == turWord.Name);
            if (wordToUpdate == null)
                new ErrorResult(Messages.RecordNotFound);
            _turWordDal.Update(turWord);
            return new SuccessResult(Messages.RecordAdded);
        }
    }
}
