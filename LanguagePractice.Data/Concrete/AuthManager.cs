using LanguagePractice.Core.Entities.Concrete;
using LanguagePractice.Core.Utilities.Results;
using LanguagePractice.Core.Utilities.Security.Hashing;
using LanguagePractice.Data.Abstract;
using LanguagePractice.Data.Constants;
using LanguagePractice.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Data.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        public AuthManager(IUserService userService)
        {
            _userService = userService;
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                UserName = userForRegisterDto.UserName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, Messages.RecordAdded);
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByUserName(userForLoginDto.UserName);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(Messages.UsernameOrPasswordWrong);
            }
            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.UsernameOrPasswordWrong);
            }

            return new SuccessDataResult<User>(userToCheck, "Başarılı giriş");
        }

        public IResult UserExists(string userName)
        {
            if (_userService.GetByUserName(userName) != null)
            {
                return new ErrorResult(Messages.RecordAlreadyExists);
            }
            return new SuccessResult();
        }

    }
}
