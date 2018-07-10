using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Demo_2
{
    class Manager : IManagerService
    {
        public int ManagerID { get; set; }

        public bool Create(Manager manager)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int managerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Manager> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetStudentByID(int managerId)
        {
            throw new NotImplementedException();
        }

        public bool Update(Manager manager)
        {
            throw new NotImplementedException();
        }
    }
}
