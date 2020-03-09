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
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int WAGE_PER_HOUR = 20;
            int hoursPerDay;
            int dailyEmployeeWage;
            int rand = random.Next(0, 3);

            Console.WriteLine("Welcome to Employee Wage Computation");

            //CONDITION CHECK OF EMPLOYEE IS FULL-TIME , PART-TIME OR ABSENT
            if (rand == IS_PART_TIME)
            {
                Console.WriteLine("Employee is Part time .");
                hoursPerDay = 4;
            }
            else if (rand == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is full time .");
                hoursPerDay = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent .");
                hoursPerDay = 0;
            }

            //CALCULATE DAILY EMPLOYEE WAGE
            Console.WriteLine("Daily Employee Wage :");
            dailyEmployeeWage = WAGE_PER_HOUR * hoursPerDay;
            Console.WriteLine(dailyEmployeeWage + " rs. per day");
            Console.Read();
        }
    }
}
