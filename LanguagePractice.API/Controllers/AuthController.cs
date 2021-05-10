using LanguagePractice.Data.Abstract;
using LanguagePractice.Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguagePractice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (userToLogin.Success)
            {
                return Ok(userToLogin.Message);
            }
            return BadRequest(userToLogin.Message);
        }
        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto, string password)
        {
            var userToRegister = _authService.Register(userForRegisterDto, password);
            if (userToRegister.Success)
            {
                return Ok(userToRegister.Message);
            }
            return BadRequest(userToRegister.Message);
        }
    }
}
