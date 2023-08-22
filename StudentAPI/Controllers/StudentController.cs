using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.Repository;
namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        // Inject IStudentRepository in constructor and implement all methods

        private readonly IStudentRepository _repository = null;

        public StudentController(IStudentRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            var id = _repository.AddStudent(student);
            return Ok(id);
        }

        [HttpPost]
        [Route("UpdateStudent")]
        public IActionResult UpdateStudent(Student student)
        {
            var id = _repository.UpdateStudent(student);
            return Ok(id);
        }
        [HttpPost]
        [Route("DeleteStudent")]
        public IActionResult DeleteStudent(int id)
        {
            var student = _repository.DeleteStudent(id);
            return Ok(student);
        }
        [HttpGet]
        [Route("GetStudent")]
        public IActionResult GetStudent(int id)
        {
            var student = _repository.GetStudent(id);
            return Ok(student);
        }
        [HttpGet]
        [Route("GetStudents")]
        public IActionResult GetStudents()
        {
            var students = _repository.GetStudents();
            return Ok(students);
        }

    }
}
