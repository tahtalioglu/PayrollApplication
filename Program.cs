using System;
using System.Collections.Generic;

namespace PayrollApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeService service = new EmployeeService();

            service.DisplayInConsole();
 
            Console.ReadLine();
        }
    }
}
