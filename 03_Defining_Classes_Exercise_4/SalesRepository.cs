using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_4
{
    public class SalesRepository
    {
        private List<SalesMember> _salesRepository;

        public SalesRepository()
        {
            _salesRepository = new List<SalesMember>();
        }

        public void AddSalesMemberToList(SalesMember salesMember)
        {
            _salesRepository.Add(salesMember);
        }

        public decimal AddTotalSales()
        {
            decimal monthlyTotal = 0;
            foreach (var salesMember in _salesRepository)
            {
                monthlyTotal += salesMember.TotalSales;
            }

            return monthlyTotal;
        }

        public int GetListCount()
        {
            return _salesRepository.Count();
        }
    }
}
