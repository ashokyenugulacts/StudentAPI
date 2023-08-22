
using StudentAPI.Models;
namespace StudentAPI.Repository
{
    public class StudentRepository : IStudentRepository
    {
        //implement IStudentRepository and add methods with DataContext

        private readonly DataContext _context = null;

        public StudentRepository(DataContext context) { _context = context; }

        public int AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student.Id;
        }

        public int UpdateStudent(Student student)
        {
              _context.Students.Update(student);
            _context.SaveChanges();
            return student.Id;
        }

        public int DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            _context.Students.Remove(student);
            _context.SaveChanges();
            return id;
        }

        public Student GetStudent(int id)
        {
            return _context.Students.Find(id);
        }

        public List<Student> GetStudents()
        {
            return _context.Students.ToList();
        }
    }
}
