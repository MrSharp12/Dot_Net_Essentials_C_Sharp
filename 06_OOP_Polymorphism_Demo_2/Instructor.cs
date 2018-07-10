using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Demo_2
{
    class Instructor : IInstructorService
    {
        public int InstructorID { get; set; }

        public bool Create(Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int instructorId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Instructor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetStudentByID(int instructorId)
        {
            throw new NotImplementedException();
        }

        public bool Update(Instructor instructor)
        {
            throw new NotImplementedException();
        }
    }
}
