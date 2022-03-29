// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using Empwage;

namespace EmpWage
{
    public class Program
    {
        public const int IS_FULLTIME = 1;
        public const int IS_PARTIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int MONTH_DAYS = 20;
        public static int companyNumber;
        public static string companyName="";
        //int empHours = 0;
        public static int empWages = 0;
        public static int empHours = 0, DAY = 0;
        public static int earnedWages = 0;
        public static int totalWorkingHours = 0;

        public void calculateWages()
        {
            empWages = empHours * EMP_RATE_PER_HOUR;
            earnedWages = empWages * DAY;
            totalWorkingHours += DAY * empHours;
            Console.WriteLine($"Total Working Hours Till Date are {totalWorkingHours}");
            Console.WriteLine($"Employee Wages are {empWages}\nEarned Wages Till Date: {earnedWages}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Companies ");
            companyNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < companyNumber; i++)
            {
                Console.WriteLine($"Enter Company No. { companyNumber } Details");
                companyName = Console.ReadLine();
                CompaniesData companiesData = new CompaniesData();
                companiesData.calwage();
                companiesData.calculateWages();
                Console.WriteLine($"Company Name: {companyName}");
                

            }
        }
    }
}