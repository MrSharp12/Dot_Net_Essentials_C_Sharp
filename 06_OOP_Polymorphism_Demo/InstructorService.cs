using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Demo
{
    class InstructorService : IPerson<Instructor>
    {
        public bool Create(Instructor model)
        {
            model.InstructorID = 1;

            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Instructor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Instructor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Instructor model)
        {
            throw new NotImplementedException();
        }
    }
}
