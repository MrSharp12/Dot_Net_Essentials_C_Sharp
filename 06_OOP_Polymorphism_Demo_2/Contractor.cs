using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Demo_2
{
    class Contractor : IContractorService
    {
        public int ContractorID { get; set; }

        public bool Create(Contractor contractor)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int contractorId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contractor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetStudentByID(int contractorId)
        {
            throw new NotImplementedException();
        }

        public bool Update(Contractor contractor)
        {
            throw new NotImplementedException();
        }
    }
}
