using System;

namespace Employee_Wage_Computation_Using_C_sharp
{
    class Program
    {
        // MAIN METHOD
        public static void Main(string[] args)
        {
            // CREATE OBJECTS
            Random random = new Random();

            // INITIALIZE CONSTANTS AND VARIABLES
            int IS_PRESENT = 1;
            int num = random.Next(0, 2);
            Console.WriteLine("Welcome to Employee Wage Computation");
            Console.Write("Attendance of Employee :\t");

            //CONDITION CHECK OF EMPLOYEE IS PRESENT OR NOT
            if (num == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present .");
            }
            else
            {
                Console.WriteLine("Employee is Absent .");
            }
            Console.Read();
        }
    }
}
