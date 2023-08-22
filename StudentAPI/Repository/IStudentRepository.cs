using StudentAPI.Models;
namespace StudentAPI.Repository
{
    public interface IStudentRepository
    {
        //Add foloowing methods : AddStudent, GetStudent, GetStudents, UpdateStudent, DeleteStudent

        int AddStudent(Student student);
        Student GetStudent(int id);
        List<Student> GetStudents();
        int UpdateStudent(Student student);
        int DeleteStudent(int id);
    }
}
