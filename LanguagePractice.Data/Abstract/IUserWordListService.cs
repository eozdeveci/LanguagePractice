using LanguagePractice.Core.Utilities.Results;
using LanguagePractice.Entities.Concrete;
using LanguagePractice.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Data.Abstract
{
    public interface IUserWordListService
    {
        IResult Add(UserWordList userWordList);
        IResult Update(UserWordList userWordList);
        IDataResult<UserWordList> GetById(int id);
        IDataResult<List<UserWordList>> GetAll();
        IResult UpdateRepeatedCount(UpdateRepeatedCountDto updateRepeatedCountDto);
    }
}
