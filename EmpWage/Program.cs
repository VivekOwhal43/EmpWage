// See https://aka.ms/new-console-template for more information
using System.Globalization;

namespace EmpWage
{
    class Program
    {
        public const int IS_FULLTIME = 1;
        public const int IS_PARTIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int MONTH_DAYS = 20;
        //int empWages = 0;
        //int empHours = 0;
        static void Main(string[] args)
        {
            int empWages = 0;
            int empHours = 0;
            int earnedWages = 0;


            Random random = new Random();

            for (int DAY = 1; DAY <= MONTH_DAYS; DAY++)
            {
                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_FULLTIME:
                        Console.WriteLine($"\nDay {DAY} \nPresent");
                        empHours = 8;
                        Console.WriteLine($"Emp {empHours} Hrs present");
                        break;

                    case IS_PARTIME:
                        Console.WriteLine($"\nDay {DAY} \nPresent Part Time");
                        empHours = 4;
                        Console.WriteLine($"Emp {empHours} Hrs present");
                        break;

                    default:
                        Console.WriteLine($"\nDay {DAY} \nAbsent");
                        empWages = 0;
                        break;
                }


                empWages = empHours * EMP_RATE_PER_HOUR;
                earnedWages = empWages * DAY;
                Console.WriteLine($"Employee Wages are {empWages}\nEarned Wages Till Date: {earnedWages}");
            }
        }
    }
}