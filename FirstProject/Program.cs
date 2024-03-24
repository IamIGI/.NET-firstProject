using System;
using System.Text;

namespace FristProject
{
    #region ProgramClassRegion_IGI
    class Program
    {
        /// <summary>
        /// Main method description, my
        /// </summary>
        /// <param name="args">args description</param>
        static void Main(string[] args)
        {
            Console.WriteLine("year of birth");
            string userInput = Console.ReadLine();

            int yearOfBirth = int.Parse(userInput);
            bool isUserOver18 = DateTime.Now.Date.Year - yearOfBirth > 18;
            if(isUserOver18)
            {
                Console.WriteLine("Hello");
            }  else if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Oh well it's Sunday");
            }
            else
            {
                Console.WriteLine("Not hello");
            }

            Console.WriteLine("Bye");

            // Typy zmiennych
            Console.WriteLine("Hello, World!");
            //Console.Write('Hello')  // Without end line
            string name = Console.ReadLine();

            Console.WriteLine(name);

            string someText = "Some text";
            char jChar = 'j';
            char jCharUnicode = '\u006A';

            bool isUserReady = false;

            DateTime now = DateTime.Now;
            DateTime dateOfBirth = new DateTime(1990, 6, 6);

            // Zmienne liczbowe
            byte byteNumber = 200;
            float floatNumber = 1.5F; //F - deklarujesz ze to jest wartosc typu float, inaczej domyslnie bedzie double
            decimal decimalNumber = 1.5M; //M - deklarujesz ze to jest wartosc typu decimal, inaczej domyslnie bedzie double
            double doubleNumber = 1.5; //Domyslnie double

            // ----------------- Deklarowanie zmiennej typu string --------------------
            string message1;
            message1 = "some value";

            string message2 = null;
            string message3 = string.Empty;
            string text = "He Said \"hi\" \\ ";

            //Laczenie stringow
            string concatenated = string.Concat(text, "to" , "me");
            string concatenated2 = text + "to" + "me";
            string interpolated = $"{text} to me";

            StringBuilder sb = new StringBuilder("init text");
            sb.AppendLine(" is"); //Add endline 
            sb.Append("a long text");

            string result = sb.ToString();
            Console.WriteLine(result);

            /* this is a
             multi-line
            comment
            */

        }
    }
    #endregion
}