using LanguagePractice.Core.CrossCuttingConcerns.Caching;
using LanguagePractice.Core.Utilities.Results;
using LanguagePractice.Data.Abstract;
using LanguagePractice.Data.Constants;
using LanguagePractice.DataAccess.Abstract;
using LanguagePractice.Entities.Concrete;
using LanguagePractice.Entities.DTOs;
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
        ICacheManager _cacheManager;
        public UserWordListManager(IUserWordListDal userWordListDal, ICacheManager cacheManager)
        {
            _userWordListDal = userWordListDal;
            _cacheManager = cacheManager;
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
            if(_cacheManager.IsAdded(id.ToString()))
                return new SuccessDataResult<UserWordList>(_cacheManager.Get<UserWordList>(id.ToString()));
            else
            {
                var result = _userWordListDal.Get(w => w.Id == id);
                _cacheManager.Add(id.ToString(), result, 1);
                return new SuccessDataResult<UserWordList>(result);
            }
        }

        public IResult UpdateRepeatedCount(UpdateRepeatedCountDto updateRepeatedCountDto)
        {
            var wordToUpdate = _userWordListDal.Get(w => w.Id == updateRepeatedCountDto.Id);
            if (wordToUpdate == null)
                new ErrorResult(Messages.RecordNotFound);
            wordToUpdate.RepeatedCount = updateRepeatedCountDto.RepeatedCount;
            _userWordListDal.Update(wordToUpdate);
            return new SuccessResult(Messages.RecordUpdated);
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
