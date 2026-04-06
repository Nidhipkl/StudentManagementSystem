using StudentManagementSystem.Models;

namespace StudentManagementSystem.Services
{
    public interface IStudentService
    {
            Task<IEnumerable<Student>> GetAllStudents();
            Task<Student> GetByStudentId(int id);
            Task AddStudent(Student student);
            Task UpdateStudent(Student student);
            Task DeleteStudent(int id);
    }
}
