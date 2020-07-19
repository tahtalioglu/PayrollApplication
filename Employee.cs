using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollApplication
{
    public abstract class Employee
    {
        protected readonly string _firstName;
        protected readonly string _lastName;
        protected readonly string _identityNumber;
        public Employee(string first, string last, string identityNumber)
        {
            _firstName = first;
            _lastName = last;
            _identityNumber = identityNumber;
        }
        public abstract string Display();

        public abstract decimal Earnings();
    }
}
