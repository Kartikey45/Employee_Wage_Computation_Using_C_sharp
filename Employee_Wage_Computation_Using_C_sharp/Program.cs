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
            int dailyEmployeeWage;
            int salary = 0;
            int daysPerMonth = 20;

            Console.WriteLine("Welcome to Employee Wage Computation");

            //CALCULATE WAGES FOR A MONTH
            for (int day = 0; day < daysPerMonth; day++)
            {
                //CONDITION CHECK OF EMPLOYEE IS FULL-TIME , PART-TIME OR ABSENT
                switch (random.Next(0, 3))
                {
                    case 1:
                        //Console.WriteLine("Employee is a Part time .");
                        hoursPerDay = 4;
                        break;
                    case 2:
                        //Console.WriteLine("Employee is a Full time .");
                        hoursPerDay = 8;
                        break;
                    default:
                        //Console.WriteLine("Employee is Absent .");
                        hoursPerDay = 0;
                        break;
                }

                //CALCULATE DAILY EMPLOYEE WAGE
                dailyEmployeeWage = WAGE_PER_HOUR * hoursPerDay;

                //CALCULATE THE SUM OF DAILY EMPLOYEE WAGES 
                salary = salary + dailyEmployeeWage;
            }

            //DISPLAY EMPLOYEE WAGE FOR A MONTH
            Console.WriteLine("Employee wage for a month :");
            Console.WriteLine(salary + " rs. per month");
            Console.Read();
        }
    }
}