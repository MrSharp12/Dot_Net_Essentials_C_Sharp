using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Exercise_1
{
    interface ICrudable
    {
        void CreateEmployee();
        void GetEmployee();
        void UpdateEmployee();
        void DeleteEmployee();
    }
}
