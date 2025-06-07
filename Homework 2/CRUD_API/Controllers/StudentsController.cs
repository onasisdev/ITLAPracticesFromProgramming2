using CRUD_API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public StudentsController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var allStudents = dbContext.Students.ToList();

            return Ok(allStudents);
        }

        [HttpPost]

        public IActionResult AddStudents()
        {

        }
    }

    
}
