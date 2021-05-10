using LanguagePractice.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Data.Abstract
{
    public interface IUserService
    {
        //List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByUserName(string email);
    }
}
