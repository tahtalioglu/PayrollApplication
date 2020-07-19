using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollApplication
{
    public class DailyAndOverTimePaidEmployee : Employee
    {
        private const string EmployeeDescription = "Daily And OverTime Paid Employee";
        private readonly decimal _dailySalary;
        public readonly decimal _daysWorked;
        private readonly decimal _overTimeSalary;
        private readonly int _overTimeHour;

        public DailyAndOverTimePaidEmployee(string firstName, string lastName, string identityNumber, decimal dailySalary, int daysWorked, decimal overTimeSalary, int overTimeHour) : base(firstName, lastName, identityNumber)
        {
            if (dailySalary < default(decimal))
            {
                throw new ArgumentOutOfRangeException("Daily Salary must be >= 0");
            }

            if (overTimeSalary < default(decimal))
            {
                throw new ArgumentOutOfRangeException("OverTime Salary must be >= 0");
            }

            if (overTimeHour < default(decimal))
            {
                throw new ArgumentOutOfRangeException("OverTime Hour must be >= 0");
            }
            _daysWorked = daysWorked;
            _dailySalary =  dailySalary;
            _overTimeSalary = overTimeSalary;
            _overTimeHour = overTimeHour;
        }

        public override string Display()
        {
            return $"{EmployeeDescription}: {_firstName} {_lastName}\nIdentity Number:{_identityNumber}\nDaily Salary:{_dailySalary},Days Worked:{_daysWorked},OverTime Salary:{_overTimeSalary},OverTime Hour:{_overTimeHour}";
        }

        public override decimal Earnings()
        {
            return _dailySalary * _daysWorked + _overTimeSalary * _overTimeHour;
        }
    }
}
