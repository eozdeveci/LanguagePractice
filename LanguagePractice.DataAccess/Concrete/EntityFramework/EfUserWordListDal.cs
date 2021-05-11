using LanguagePractice.Core.EntityFramework;
using LanguagePractice.DataAccess.Abstract;
using LanguagePractice.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.DataAccess.Concrete.EntityFramework
{
    public class EfUserWordListDal : EfEntityRepositoryBase<UserWordList, LanguagePracticeDbContext>, IUserWordListDal
    {
    }
}
