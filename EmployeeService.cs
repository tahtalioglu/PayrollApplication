using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollApplication
{
    public class EmployeeService
    {
        public List<Employee> GetEmployees()
        {
            var monthlyPaidEmployee = new MonthlyPaidEmployee("İlker", "Yağcıoğlu", "111111111", 900.00M);

            var dailyPaidEmployee = new DailyPaidEmployee("Tayfun", "Korkut", "222222222", 20.50M, 40);

            var monthlyAndOverTimePaidSalary = new MonthlyAndOverTimePaidSalary("Bülent", "Uygun", "333333333", 1000.00M, 0.8M, 10);

            var dailyAndOverTimePaidEmployee = new DailyAndOverTimePaidEmployee("Erol", "Bulut", "444444444", 50.00M, 10, .08M, 25);

            List<Employee> employees = new List<Employee>()
            {
                monthlyPaidEmployee,dailyPaidEmployee,monthlyAndOverTimePaidSalary,dailyAndOverTimePaidEmployee
            };

            return employees;
        }

        public void DisplayInConsole()
        {
            var employees = GetEmployees();

            foreach (Employee currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee.Display());

                Console.WriteLine(
                   "Earned {0:C}\n", currentEmployee.Earnings());
            }
        }

    }
}
