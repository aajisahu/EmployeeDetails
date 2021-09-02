using System;

namespace UC_3EmployeeWage1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 3);
            switch (empCheck)
           case 1:
               Console.WriteLine("Today is Saturday.");
              break;
           case 2:
               Console.WriteLine("Today is Sunday.");
              break;
            default:
                Console.WriteLine("Looking forward to the Weekend.");
                break;
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
