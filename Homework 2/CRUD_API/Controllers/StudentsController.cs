using CRUD_API.Data;
using CRUD_API.Models;
using CRUD_API.Models.Entitie;
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

        [HttpGet]
        [Route("id{id:int}")]

        public IActionResult GetStudentById(int id)
        {
            var student = dbContext.Students.Find(id);

            if (student is null)
            {
                return NotFound();
            }

            return Ok(student);

        }
        
        [HttpPost]
        public IActionResult AddStudents(AddStudenddto addStudenddto)
        {
            var studentEntity = new Student()
            {
                FirstName = addStudenddto.FirstName,
                LastName = addStudenddto.LastName,
                Address = addStudenddto.Address,
                Email = addStudenddto.Email,
                PhoneNumber = addStudenddto.PhoneNumber
            };

            dbContext.Students.Add(studentEntity);
            dbContext.SaveChanges();

            return Ok(studentEntity);

        }

        [HttpPut]
        [Route("id{id:int}")]

        public IActionResult UpdateStudent(UpdateStudenddto updateStudenddto, int id)
        {
            var student = dbContext.Students.Find(id);

            if (student is null)
            {
                return NotFound();
            }

            student.FirstName = updateStudenddto.FirstName;
            student.LastName = updateStudenddto.LastName;
            student.Address = updateStudenddto.Address;
            student.Email = updateStudenddto.Email;
            student.PhoneNumber = updateStudenddto.PhoneNumber;

            dbContext.SaveChanges();

            return Ok(student);
        }

        
        [HttpDelete]
        [Route("id{id:int}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = dbContext.Students.Find(id);

            if (student is null)
            {
                NotFound();
            }

            dbContext.Students.Remove(student);
            dbContext.SaveChanges();

            return Ok();
        }
    }

    
}
