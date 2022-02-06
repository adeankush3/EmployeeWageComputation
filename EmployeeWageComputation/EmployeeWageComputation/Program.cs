using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Problem :-");
            EmpWageComputation emp = new EmpWageComputation();
            emp.employeeAttendence();
            emp.CalculateWage();
        }
    }
}
