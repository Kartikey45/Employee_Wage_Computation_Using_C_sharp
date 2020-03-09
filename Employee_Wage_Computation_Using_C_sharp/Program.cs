using System;

namespace Employee_Wage_Computation_Using_C_sharp
{
    class Program
    {
        // MAIN METHOD
        public static void Main(string[] args)
        {
            //CREATE OBJECTS
            Random random = new Random();

            // INITIALIZE CONSTANTS AND VARIABLES                       
            int WAGE_PER_HOUR = 20;
            int hoursPerDay;
            int salary = 0;
            int daysPerMonth = 20;
            int days = 0;
            int workingHours = 0;
            int workingHoursLimit = 100;

            Console.WriteLine("Welcome to Employee Wage Computation");

            //CALCULATE WAGES FOR A MONTH
            while (days < daysPerMonth && workingHours < workingHoursLimit)
            {
                days++;

                //CONDITION CHECK OF EMPLOYEE IS FULL-TIME , PART-TIME OR ABSENT
                switch (random.Next(0, 3))
                {
                    case 1:
                        hoursPerDay = 4;
                        break;
                    case 2:
                        hoursPerDay = 8;
                        break;
                    default:
                        hoursPerDay = 0;
                        break;
                }

                //CALCULATE TOTAL WORKING HOURS OF EMPLOYEE IN A MONTH
                workingHours = workingHours + hoursPerDay;
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