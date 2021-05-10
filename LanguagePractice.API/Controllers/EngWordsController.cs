using LanguagePractice.Data.Abstract;
using LanguagePractice.Entities.Concrete;
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
    public class EngWordsController : ControllerBase
    {
        IEngWordService _engWordService;
        public EngWordsController(IEngWordService engWordService)
        {
            _engWordService = engWordService;
        }
        [HttpPost("add")]
        public IActionResult Add(EngWord engWord)
        {
            var result = _engWordService.Add(engWord);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _engWordService.GetById(id);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(EngWord engWord)
        {
            var result = _engWordService.Update(engWord);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("getall")]
        public IActionResult GetAll()
        {
            var result = _engWordService.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
