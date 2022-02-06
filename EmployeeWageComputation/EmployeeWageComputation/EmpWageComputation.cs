using System;

namespace EmployeeWageComputation
{
    public class EmpWageComputation
    {

        const int EmployeePresent = 0, EmployeeAbsent = 1, 
            WagePerHour = 20, FullDayHour = 8, 
            PartTime = 8;
        int DayHour = 0 , CalculateDailyWage=0;
        Random ran = new Random();


        public void employeeAttendence()
        {
            int empCheck = ran.Next(0, 2);

            if (empCheck == EmployeePresent)
            {
                Console.WriteLine("Employee is Present");
                if (DayHour == FullDayHour)
                {
                   int CalculateDailyWage = WagePerHour * FullDayHour;
                    Console.WriteLine("Employee Calculate Wage Is:-" + CalculateDailyWage);

                }
                else
                {
                    int CalculateDailyWage = WagePerHour * PartTime;
                    Console.WriteLine("Employee Part Time Wage is:-" + CalculateDailyWage);
                }

            }
            if (empCheck == EmployeeAbsent)
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }

}