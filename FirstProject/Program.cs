using System;

namespace Coding.Exercise
{
   
    

    class Program
    {
        static void Main(string[] args)
        {

            //-----------Konwertowanie typów i rzutowanie
            byte byteValue = 100;
            int intValue = byteValue;
            byte byteValue2 = (byte)intValue; // if intValue is bigger byte ranage, then and overflow occured;

            double doubleValue = 3.5;
            int intValue2 = (int)doubleValue; // numbers after digits will be losts

            string strinValue2 = intValue.ToString();

            string userInput = Console.ReadLine();
            int yearsOfBirth;
            if(int.TryParse(userInput, out yearsOfBirth))
            {
                int age = DateTime.Now.Year - yearsOfBirth;

                Console.WriteLine("You are " + age);
            }
            else
            {
                Console.WriteLine("Incorect valeu");
            }
        }
    }
}
