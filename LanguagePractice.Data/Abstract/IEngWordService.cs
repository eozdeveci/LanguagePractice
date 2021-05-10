using LanguagePractice.Core.DataAccess;
using LanguagePractice.Core.Utilities.Results;
using LanguagePractice.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Data.Abstract
{
    public interface IEngWordService
    {
        IResult Add(EngWord engWord);
        IResult Update(EngWord engWord);
        IDataResult<EngWord> GetById(int id);
        IDataResult<List<EngWord>> GetAll();
    }
}
