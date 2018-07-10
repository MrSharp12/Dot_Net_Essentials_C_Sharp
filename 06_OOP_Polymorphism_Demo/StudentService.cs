using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Demo
{
    class StudentService : IPerson<Student>
    {
        public bool Create(Student model)
        {
            model.StudentID = 1;

            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Student model)
        {
            throw new NotImplementedException();
        }
    }
}
