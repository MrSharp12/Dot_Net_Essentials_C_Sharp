using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymorphism_Exercise_1
{
    public class EmployeeRepo : ICrudable
    {
        private List<Employee> _employeeList = new List<Employee>();

        public void CreateEmployee()
        {
            throw new NotImplementedException();
        }
        private List<Employee> AddUdemyCourseToList(Employee employee)
        {

            _employeeList.Add(employee);
            return _employeeList;

        }

        public void DeleteEmployee()
        {
            throw new NotImplementedException();
        }

        public void GetEmployee()
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee()
        {
            throw new NotImplementedException();
        }
    }
}
