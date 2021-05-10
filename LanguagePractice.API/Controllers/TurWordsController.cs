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
    public class TurWordsController : ControllerBase
    {
        private ITurWordService _turWordService;
        public TurWordsController(ITurWordService turWordService)
        {
            _turWordService = turWordService;
        }
        [HttpPost("add")]
        public IActionResult Add(TurWord turWord)
        {
            var result = _turWordService.Add(turWord);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _turWordService.GetById(id);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(TurWord turWord)
        {
            var result = _turWordService.Update(turWord);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("getall")]
        public IActionResult GetAll()
        {
            var result = _turWordService.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
