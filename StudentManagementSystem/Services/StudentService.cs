using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories;

namespace StudentManagementSystem.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        
        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await _studentRepository.GetAllStudents();
        }

        public async Task<Student> GetByStudentId(int id)
        {
            return await _studentRepository.GetByStudentId(id);
        }

        public async Task AddStudent(Student student)
        {
            await _studentRepository.AddStudent(student);
        }

        public async Task DeleteStudent(int id)
        {
            await _studentRepository.DeleteStudent(id);
        }


        public async Task UpdateStudent(Student student)
        {
            await _studentRepository.UpdateStudent(student);
        }
    }
}
