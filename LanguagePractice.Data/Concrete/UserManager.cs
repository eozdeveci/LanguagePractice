using LanguagePractice.Core.Entities.Concrete;
using LanguagePractice.Data.Abstract;
using LanguagePractice.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Data.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByUserName(string userName)
        {
            return _userDal.Get(w => w.UserName == userName);
        }
    }
}
