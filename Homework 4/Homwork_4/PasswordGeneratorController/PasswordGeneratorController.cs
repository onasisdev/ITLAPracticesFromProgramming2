using Microsoft.AspNetCore.Mvc;
using SecurePasswordGenerator.Application.Dtos;
using SecurePasswordGenerator.Application.Contract;


namespace SecurePasswordGenerator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PasswordGeneratorAndEvaluationController : ControllerBase
    {
        private readonly IPasswordGenerationService _passwordService;
        private readonly IPasswordEvaluationService _evaluationService;

        public PasswordGeneratorAndEvaluationController(IPasswordGenerationService passwordService, IPasswordEvaluationService evaluationService)
        {
            _passwordService = passwordService;
            _evaluationService = evaluationService;
        }

        [HttpPost("generate_and_evaluate")]
        public async Task<IActionResult> GenerateAndEvaluate([FromBody] PasswordCriteriaAndEvaluationDtos CriteriaOrEvaluation)
        {
            var password = await _passwordService.GeneratePassword(CriteriaOrEvaluation.Criteria);
            var passwordEvaluator = await _evaluationService.EvaluatePassword(CriteriaOrEvaluation.Evaluation, CriteriaOrEvaluation.Criteria);
            return Ok(new { password, passwordEvaluator});  
        }
    }
}

