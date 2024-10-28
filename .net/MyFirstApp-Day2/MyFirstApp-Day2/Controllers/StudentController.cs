using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstApp_Day2.Models;

namespace MyFirstApp_Day2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static List<Student> _students = new List<Student>
        {
            new Student { Id = 1, Name = "Vidya", Marks = 89.00m, Dept = "IT" },
            new Student { Id = 2, Name = "Yash",Marks = 98.00m, Dept = "AI&DS" },
            new Student { Id = 3, Name = "Ram", Marks = 97.00m, Dept = "Mech" },
            // Add more students
        };
        // GET: api/students
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            return _students;
        }

        // GET: api/students/2
        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(int id)
        {
            var student = _students.FirstOrDefault(p => p.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return student;
        }
        // POST: api/students
        [HttpPost]
        public ActionResult<Student> PostStudent(Student student)
        {
            _students.Add(student);
            return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
        }

        // PUT: api/students/5
        [HttpPut("{id}")]
        public IActionResult PutStudent(int id, Student student)
        {
            if (id != student.Id)
            {
                return BadRequest();
            }
            var existingStudent = _students.FirstOrDefault(p => p.Id == id);
            if (existingStudent == null)
            {
                return NotFound();
            }
            existingStudent.Name = student.Name;
            existingStudent.Marks = student.Marks;
            existingStudent.Dept = student.Dept;
            // In a real application, here you would update the student in the database
            return NoContent();

        }
        // DELETE: api/students/5
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = _students.FirstOrDefault(p => p.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            _students.Remove(student);
            // In a real application, here you would delete the student from the database
            return NoContent();
        }
    }
}
