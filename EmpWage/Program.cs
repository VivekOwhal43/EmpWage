﻿// See https://aka.ms/new-console-template for more information
namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULLTIME=1;
            int EMP_RATE_PER_HOUR = 20;
            int empWages = 0;
            int empHours = 0;


            Random random = new Random();
            
            int check = random.Next(0,2);
            if(check == IS_FULLTIME)
            {
                Console.WriteLine("Present");
                empHours=8;
                Console.WriteLine($"Emp {empHours} Hrs present");
            }
            else
            {
                Console.WriteLine("Absent");
                empWages =0;
            }
            empWages = empHours*EMP_RATE_PER_HOUR;
            Console.WriteLine($"Employee Wages are {empWages} ");
        }
    }
}