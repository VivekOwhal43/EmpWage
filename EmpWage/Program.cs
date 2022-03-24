// See https://aka.ms/new-console-template for more information
namespace EmpWage
{
    class Program
    {
        public const int IS_FULLTIME = 1;
        public const int IS_PARTIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        int empWages = 0;
        int empHours = 0;
        static void Main(string[] args)
        {
            int empWages = 0;
            int empHours = 0;


            Random random = new Random();

            int check = random.Next(0, 3);
            /*if(check == IS_FULLTIME)
            {
                Console.WriteLine("Present");
                empHours=8;
                Console.WriteLine($"Emp {empHours} Hrs present");
            }
            else if(check == IS_PARTIME)
            {
                Console.WriteLine("Present Part Time");
                empHours=4;
                Console.WriteLine($"Emp {empHours} Hrs present");
            }
            else
            {
                Console.WriteLine("Absent");
                empWages =0;
            }*/
            switch (check)
            {
                case IS_FULLTIME:
                    Console.WriteLine("Present");
                    empHours=8;
                    Console.WriteLine($"Emp {empHours} Hrs present");
                break;
                
                case IS_PARTIME:
                     Console.WriteLine("Present Part Time");
                     empHours=4;
                     Console.WriteLine($"Emp {empHours} Hrs present");
                 break;
                
                default:
                     Console.WriteLine("Absent");
                     empWages =0;
                break;
            }
            empWages = empHours * EMP_RATE_PER_HOUR;
            Console.WriteLine($"Employee Wages are {empWages} ");
        }
    }
}