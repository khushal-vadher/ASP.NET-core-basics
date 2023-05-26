
namespace WebApplication3.Models
{
    public class MockStudentRepository:IStudentRepository
    {
        private List<Students> _students;

        public MockStudentRepository()
        {
            _students = new List<Students>()
            {
                new Students() {Id  =1 ,Name = "Khushal",Department = "CE" ,Year =4}
            };
        }
        public Students GetStudent(int id)
        {
            return this._students.FirstOrDefault(e => e.Id == id);
        }
        public IEnumerable<Students> GetAllStudents() { 
            return _students;
        }
    }
}
