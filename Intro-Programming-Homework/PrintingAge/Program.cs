using System;

namespace PrintingAge
{
    class Program
    {
        static void Main()
        {
            // DateTime myBirthDate = DateTime.Parse(Console.ReadLine());
            DateTime myBirthDate = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", null);
           // var myDate = myBirthDate.ToString("MM.dd.yyyy");
            
            DateTime currentDate = DateTime.Now;

            int ageOfPerson = currentDate.Year - myBirthDate.Year;
            if (myBirthDate.Month <= currentDate.Month && myBirthDate.Day <= currentDate.Day)
            {
                ageOfPerson--;
            }
           Console.WriteLine("{0}, {1}", ageOfPerson, ageOfPerson + 10);
           // Console.Write("MM.dd.yyyy", "{0}, {1}", ++ageOfPerson, ageOfPerson + 10);
           
        }
    }
}
//Task to solve - print age now and in 10 years on a single line
//Input Output
//09.05.2016	
//0 10
//09.16.1994	
//22 32