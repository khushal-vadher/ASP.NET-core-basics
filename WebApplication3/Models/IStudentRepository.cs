namespace WebApplication3.Models
{
    public interface IStudentRepository
    {
        Students GetStudent(int id);
        IEnumerable<Students> GetAllStudents();
    }
}
