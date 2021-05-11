using LanguagePractice.Data.Abstract;
using LanguagePractice.Entities.Concrete;
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
    public class UserWordListsController : ControllerBase
    {
        IUserWordListService _userWordListService;
        public UserWordListsController(IUserWordListService userWordListService)
        {
            _userWordListService = userWordListService;
        }
        [HttpPost("add")]
        public IActionResult Add(UserWordList userWordList)
        {
            var result = _userWordListService.Add(userWordList);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _userWordListService.GetById(id);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(UserWordList userWordList)
        {
            var result = _userWordListService.Update(userWordList);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("getall")]
        public IActionResult GetAll()
        {
            var result = _userWordListService.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
