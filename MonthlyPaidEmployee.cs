using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollApplication
{
    public class MonthlyPaidEmployee : Employee
    {
        private const string EmployeeDescription = "Monthly Paid Employee";
        private readonly decimal _salary;
        public MonthlyPaidEmployee(string firstName, string lastName, string identityNumber, decimal salary) : base(firstName, lastName, identityNumber)
        {
            if (salary < default(decimal))
            {
                throw new ArgumentOutOfRangeException("Monthly Salary must be >= 0");
            }
            _salary = salary;
        }
        public override string Display()
        {
            return $"{EmployeeDescription}: {_firstName} {_lastName}\nIdentity Number:{_identityNumber}\nMonthly Salary:{_salary}";
        }

        public override decimal Earnings()
        {
            return _salary;
        }
    }
}
