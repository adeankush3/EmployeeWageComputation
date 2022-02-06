using System;

namespace EmployeeWageComputation
{
    public class EmpWageComputation
    {

        const int EmployeePresent = 0, EmployeeAbsent = 1,
            WagePerHour = 20, FullDayHour = 8,
            PartTime = 8, WorkingDayMonth = 20;
        int DayHour = 0;
        int EmpHour = 0;
        int ToatalWage = 0, ToatalMonthlyWage = 0;
        Random ran = new Random();
        private int empCheck;

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
        public void CalculateWage()
        {
            switch (empCheck)
            {
                case FullDayHour:
                    this.EmpHour += FullDayHour;
                    break;
                
               // case PartTime:
                //    this.EmpHour += PartTime;
                 //   break;

                
                default:
                    Console.WriteLine("Employee is Absent:-");
                    this.EmpHour += 0;
                    break;
            }
            this.ToatalWage = EmpHour * WagePerHour;
            Console.WriteLine(this.ToatalWage);
           
            ToatalMonthlyWage = WagePerHour * WorkingDayMonth;
            Console.WriteLine("Employee Monthly Wage:-" + ToatalMonthlyWage);
        }
    }

}