using FirstProject.Enums; //importing other file, by fix namespace value
using System;

namespace Coding.Exercise
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your gender? 1 - Male, 2 - Female");
            string userInput = Console.ReadLine();  
            //Rzutujemy na typ Gender, bo Enum.Parse zwraca nam enuma z userInput-a
            Gender userGender = (Gender)Enum.Parse(typeof(Gender), userInput);

            if(userGender == Gender.Male)
            {
                Console.WriteLine("Only women allowed");
            }
            else
            {
                Console.WriteLine("hi!");
            }



            //Nullable exmaple:
            int? favNumber = 3;
            Console.WriteLine("Fav number: " + (favNumber.HasValue ? favNumber.Value.ToString() : ""));


            string[] cars = { "Volvo", "Opel", "BMW" };
            try
            {
                Console.WriteLine(cars[3]);
            }
           catch( IndexOutOfRangeException e)
            {
                Console.WriteLine("Podales wartosc z poza zakresu tablicy");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Always execute");
            }
        }
    }
}
