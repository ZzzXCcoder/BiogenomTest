using Biogenom.Dtos;
using Biogenom.Service;
using Microsoft.AspNetCore.Mvc;

namespace Biogenom.Controllers
{
    public class NutritionAssessmentController : ControllerBase
    {
        private readonly IAssessmentService _service;

        public NutritionAssessmentController(IAssessmentService service)
        {
            _service = service;
        }

        [HttpGet("latest")]
        public async Task<ActionResult<AssesmentResultDto>> GetLatestResult()
        {
            var result = await _service.GetLatestAssessmentResultAsync();
            if (result == null) return NotFound();
            return Ok(result);
        }
    }
}
