using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollApplication
{
    public class MonthlyAndOverTimePaidSalary : Employee
    {
        private const string EmployeeDescription = "Monthly And OverTime Paid Employee";
        private readonly decimal _salary;
        private readonly decimal _overTimeSalary;
        private readonly int _overTimeHour;
        public MonthlyAndOverTimePaidSalary(string firstName, string lastName, string identityNumber, decimal salary, decimal overTimeSalary, int overTimeHour) : base(firstName, lastName, identityNumber)
        {
            if (salary < default(decimal))
            {
                throw new ArgumentOutOfRangeException("Monthly Salary must be >= 0");
            }

            if (overTimeSalary < default(decimal))
            {
                throw new ArgumentOutOfRangeException("OverTime Salary must be >= 0");
            }

            if (overTimeHour < default(decimal))
            {
                throw new ArgumentOutOfRangeException("OverTime Hour must be >= 0");
            }

            _salary = salary;
            _overTimeSalary = overTimeSalary;
            _overTimeHour = overTimeHour;
        }
        public override string Display()
        {
            return $"{EmployeeDescription}: {_firstName} {_lastName}\nIdentity Number:{_identityNumber}\nMonthly Salary:{_salary},OverTime Salary:{_overTimeSalary},OverTime Hour:{_overTimeHour}";
        }

        public override decimal Earnings()
        {
            return _salary + _overTimeHour * _overTimeSalary;
        }
    }
}
