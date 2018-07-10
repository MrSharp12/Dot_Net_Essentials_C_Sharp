using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Exercise_3
{
    public class YoungDriver
    {
        private const decimal MONTHLY_VALUE = 120.00m;
        private int _age;

        public int Age
        {
            get { return _age; }
            private set
            {
                if (value <= 15 || value > 25)
                {
                    throw new ArgumentException("Age must be between 16 and 25");
                }
                _age = value;
            }
        }

        public YoungDriver(int age)
        {
            Age = age;
        }

        public decimal DetermineMonthlyRateByAge()
        {
            var monthlyRate = MONTHLY_VALUE;
            if (Age >= 16 && Age <= 19)
            {
                var adjustedValue = .90m * MONTHLY_VALUE;
                monthlyRate += adjustedValue;
            }
            else if (Age >= 20 && Age <= 22)
            {
                var adjustedValue = .60m * MONTHLY_VALUE;
                monthlyRate += adjustedValue;
            }
            else if (Age >= 23 && Age <= 25)
            {
                var adjustedValue = .50m * MONTHLY_VALUE;
                monthlyRate += adjustedValue;
            }
            return monthlyRate;
        }
    }
}
