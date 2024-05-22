using CrudRepositoryPatternDiEf.Models;
using CrudRepositoryPatternDiEf.Services.FrontManSerivce;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudRepositoryPatternDiEf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrontManController : ControllerBase
    {
        private readonly IFrontManService _frontManService;

        public FrontManController(IFrontManService frontManService)
        {
            _frontManService = frontManService;
        }
        [HttpGet]
        public async Task<ActionResult<List<FrontMan>>> GetAllFrontMans()
        {
            var result = await _frontManService.GetAllFrontMans();
            if (result == null) { return NotFound(); }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FrontMan>> GetFrontMan(int id)
        {
            var result = await _frontManService.GetFrontMan(id);
            if (result == null) { return NotFound(); }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<FrontMan>> AddFrontMan(FrontMan frontMan)
        {
            var result = await _frontManService.AddFrontMan(frontMan);
            if (result == null) { return NotFound(); }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<FrontMan>> UpdateFrontMan(int id, FrontMan requestFrontMan)
        {
            var result = await _frontManService.UpdateFrontMan(id, requestFrontMan);
            if (result == null) { return NotFound(); }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<FrontMan>>> DeleteFrontMan(int id)
        {
            var result = await _frontManService.DeleteFrontMan(id);
            if (result == null) { return NotFound(); }
            return Ok(result);
        }
    }
}
