using LanguagePractice.Core.DataAccess;
using LanguagePractice.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.DataAccess.Abstract
{
    public interface IUserWordListDal : IEntityRepository<UserWordList>
    {
    }
}
