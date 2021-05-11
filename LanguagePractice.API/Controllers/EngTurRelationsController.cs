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
    public class EngTurRelationsController : ControllerBase
    {
        IEngTurRelationService _engTurRelationService;
        public EngTurRelationsController(IEngTurRelationService engTurRelationService)
        {
            _engTurRelationService = engTurRelationService;
        }
        [HttpPost("add")]
        public IActionResult Add(EngTurRelation engTurRelation)
        {
            var result = _engTurRelationService.Add(engTurRelation);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _engTurRelationService.GetById(id);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(EngTurRelation engTurRelation)
        {
            var result = _engTurRelationService.Update(engTurRelation);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("getall")]
        public IActionResult GetAll()
        {
            var result = _engTurRelationService.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
