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
        public async Task<IActionResult> Generate([FromBody] PasswordCriteriaDto criteria)
        {
            var password = await _passwordService.GeneratePassword(criteria);
            var passwordEvaluator = await _evaluationService.EvaluatePassword(passwordEvaluation);
            return Ok(new { password}, new {passwordEvaluator });
            
        }
        }
    }

