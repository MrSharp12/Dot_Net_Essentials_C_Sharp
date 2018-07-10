using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Demo_2
{
    public interface IStudentService
    {
        //CRUD repo pattern
        bool Create(Student student);
        Student GetStudentByID(int studentId);
        IEnumerable<Student> GetAll();
        bool Update(Student student);
        bool Delete(int studentId);
    }
}
