// See https://aka.ms/new-console-template for more information
namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_PRESENT=0;
            Random random = new Random();
            int check = random.Next(0,2);
            if(check == IS_PRESENT)
            {
                Console.WriteLine("Absent");

            }
            else
            {
                Console.WriteLine("Present");
            }
        }
    }
}