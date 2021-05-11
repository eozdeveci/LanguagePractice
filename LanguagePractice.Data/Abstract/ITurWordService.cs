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
    public interface ITurWordService
    {
        IResult Add(TurWord turWord);
        IResult Update(TurWord turWord);
        IDataResult<TurWord> GetById(int id);
        IDataResult<List<TurWord>> GetAll();
    }
}
