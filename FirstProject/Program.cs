using System;//Set debug whenever you want, and click f10, to go line by line

namespace Coding.Exercise
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj date swoich urodzin w formacie: yyyy-mm-dd");
            string value = Console.ReadLine();
            if (value.Length == 0) return;

            //pass (dd.MM.yyyy)
            //DateTime dateOfBirth = DateTime.Parse(value);

            if(DateTime.TryParseExact(value, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime inputDate))
            {
                TimeSpan difference = DateTime.Now.Date - inputDate;
                Console.WriteLine($"Number of days elapsed since: {value}: {difference.TotalDays}");
            } else
            {
                Console.WriteLine("Invalid date format. Please enter the date in yyyy-MM-dd format.");

            }
        }
    }
}
