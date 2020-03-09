using System;

namespace Employee_Wage_Computation_Using_C_sharp
{
    class Program
    {
        //HOURS PER DAY OF AN EMPLOYEE
        public int workingHoursPerDay(int hoursPerDay)
        {
            //CREATE OBJECT OF RANDOM CLASS 
            Random random = new Random();

            //CONDITION CHECK FOR FULL-TIME , PART-TIME OR ABSENT
            switch (random.Next(0, 3))
            {
                case 1:
                    hoursPerDay = 4;
                    return hoursPerDay;
                    break;
                case 2:
                    hoursPerDay = 8;
                    return hoursPerDay;
                    break;
                default:
                    hoursPerDay = 0;
                    return hoursPerDay;
                    break;
            }
            //return 0
        }

        // MAIN METHOD
        public static void Main(string[] args)
        {
            // INITIALIZE CONSTANTS AND VARIABLES                       
            int WAGE_PER_HOUR = 20;
            int salary = 0;
            int daysPerMonth = 20;
            int days = 0;
            int workingHours = 0;
            int workingHoursLimit = 100;
            int hrsPerDay = 0;
            int perDayHours;

            Console.WriteLine("Welcome to Employee Wage Computation");

            //OBJECT CREATED
            Program obj = new Program();

            //CALCULATE TOTAL HOURS WORKED BY AN EMPLOYEE IN A MONTH OF TWENTY DAYS
            while (days < daysPerMonth && workingHours < workingHoursLimit)
            {
                days++;

                //DECLARE VARIABLE
                perDayHours = obj.workingHoursPerDay(hrsPerDay);

                //CALCULATE TOTAL WORKING HOURS OF EMPLOYEE IN A MONTH
                workingHours = workingHours + perDayHours;
            }

            //CALCULATE EMPLOYEE WAGE FOR A MONTH
            salary = WAGE_PER_HOUR * workingHours;

            //DISPLAY EMPLOYEE WAGE FOR A MONTH
            Console.WriteLine("Employee wage for a month :");
            Console.WriteLine(salary + " rs. per month");
            Console.Read();
        }
    }
}