using EmpWage;

namespace Empwage
{
    public class CompaniesData : Program
    {
        Random random = new Random();
            Program empWagesclass = new Program();
            public void calwage(){
            do
            {
                for (DAY = 1; DAY <= MONTH_DAYS; DAY++)
                {
                    int check = random.Next(0, 3);
                    switch (check)
                    {
                        case IS_FULLTIME:
                            //Console.WriteLine($"\nDay {DAY} \nPresent");
                            empHours = 8;
                            //Console.WriteLine($"Emp {empHours} Hrs present");
                        break;

                        case IS_PARTIME:
                            //Console.WriteLine($"\nDay {DAY} \nPresent Part Time");
                            empHours = 4;
                            //Console.WriteLine($"Emp {empHours} Hrs present");
                        break;

                        default:
                            //Console.WriteLine($"\nDay {DAY} \nAbsent");
                            empWages = 0;
                            empHours = 0;
                        break;
                    }
                    empWagesclass.calculateWages();
                    if (totalWorkingHours >= 100)
                    {
                        break;
                    }
                }
            } while (DAY == 20);
            }
    }
}