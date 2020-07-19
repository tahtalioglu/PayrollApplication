using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollApplication
{
    public class DailyPaidEmployee : Employee
    {

        private const string EmployeeDescription = "Daily Paid Employee";
        private readonly decimal _dailyWage;
        public readonly int _daysWorked;

        public DailyPaidEmployee(string firstName, string lastName, string identityNumber, decimal dailyWage, int daysWorked) : base(firstName, lastName, identityNumber)
        {
            if (dailyWage < default(decimal))
            {
                throw new ArgumentOutOfRangeException( "Daily Salary must be >= 0");
            }

            _dailyWage = dailyWage;
            _daysWorked = daysWorked;
        }
        public override string Display()
        {
            return $"{EmployeeDescription}: {_firstName} {_lastName}\nIdentity Number:{_identityNumber}\nDaily Salary: {_dailyWage},Days Worked:{_daysWorked}";
        }

        public override decimal Earnings()
        {
            return _dailyWage*_daysWorked;
        }
    }
}
