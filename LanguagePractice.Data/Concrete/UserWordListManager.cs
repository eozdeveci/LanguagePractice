using LanguagePractice.Core.Utilities.Results;
using LanguagePractice.Data.Abstract;
using LanguagePractice.Data.Constants;
using LanguagePractice.DataAccess.Abstract;
using LanguagePractice.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Data.Concrete
{
    public class UserWordListManager : IUserWordListService
    {
        IUserWordListDal _userWordListDal;
        public UserWordListManager(IUserWordListDal userWordListDal)
        {
            _userWordListDal = userWordListDal;
        }
        public IResult Add(UserWordList userWordList)
        {
            var relationToCheck = _userWordListDal.Get(w => w.UserId == userWordList.UserId && 
                                                            w.ListName == userWordList.ListName &&
                                                            w.EngWordId == userWordList.EngWordId);
            if (relationToCheck != null)
                new ErrorResult(Messages.RecordAlreadyExists);
            _userWordListDal.Add(userWordList);
            return new SuccessResult(Messages.RecordAdded);
        }

        public IDataResult<List<UserWordList>> GetAll()
        {
            return new SuccessDataResult<List<UserWordList>>(_userWordListDal.GetAll());
        }

        public IDataResult<UserWordList> GetById(int id)
        {
            return new SuccessDataResult<UserWordList>(_userWordListDal.Get(w => w.Id == id));
        }
        public IDataResult<UserWordList> GetByWordId(int id)
        {
            return new SuccessDataResult<UserWordList>(_userWordListDal.Get(w => w.EngWordId == id));
        }

        public IResult Update(UserWordList userWordList)
        {
            var wordToUpdate = _userWordListDal.Get(w => w.Id == userWordList.Id);
            if (wordToUpdate == null)
                new ErrorResult(Messages.RecordNotFound);
            _userWordListDal.Update(userWordList);
            return new SuccessResult(Messages.RecordUpdated);
        }
    }
}
