using LanguagePractice.Core.Entities.Concrete;
using LanguagePractice.Core.EntityFramework;
using LanguagePractice.DataAccess.Abstract;
using LanguagePractice.Entities;

namespace LanguagePractice.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, LanguagePracticeDbContext>, IUserDal
    {
    }
}
