using System;

namespace EmployeeWageComputation
{
    public class EmpWageComputation
    {

        const int EmployeePresent = 0, EmployeeAbsent = 1, WagePerHour = 20, FullDayHour = 8;
        Random ran = new Random();


        public void employeeAttendence()
        {
            int empCheck = ran.Next(0, 2);

            if (empCheck == EmployeePresent)
            {
                Console.WriteLine("Employee is Present");
                int CalculateDailWage = WagePerHour * FullDayHour;
                Console.WriteLine("Employee Calculate Wage Is:-" + CalculateDailWage);

            }
            if (empCheck == EmployeeAbsent)
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }

}