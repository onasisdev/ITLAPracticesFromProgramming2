using Microsoft.AspNetCore.Mvc;
using SecurePasswordGenerator.Application.Dtos;
using SecurePasswordGenerator.Application.Contract;

namespace SecurePasswordGenerator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PasswordGeneratorController : ControllerBase
    {
        private readonly IPasswordGenerationService _passwordService;

        public PasswordGeneratorController(IPasswordGenerationService passwordService)
        {
            _passwordService = passwordService;
        }

        [HttpPost("generate")]
        public async Task<IActionResult> Generate([FromBody] PasswordCriteriaDto criteria)
        {
            var password = await _passwordService.GeneratePassword(criteria);
            return Ok(new { password });
        }
    }
}
