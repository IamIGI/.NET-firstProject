using System;

namespace Coding.Exercise
{

    
    public class TemperatureAnalyzer
    {
        // Znajduje najwyższą temperaturę w tablicy temperatur
        public static int FindHighestTemperature(int[] temperatures)
        {
            // TODO: Uzupełnij implementację, znajdując najwyższą temperaturę
            // wśród wszystkich temperatur w tablicy.
            // Zwróć wartość najwyższej temperatury.
            int result = temperatures[0];
            foreach (var temp in temperatures)
            {
                if (result < temp) result = temp;
            }
            return result;
        }

        // Znajduje najniższą temperaturę w tablicy temperatur
        public static int FindLowestTemperature(int[] temperatures)
        {
            
            // TODO: Uzupełnij implementację, znajdując najniższą temperaturę
            // wśród wszystkich temperatur w tablicy.
            // Zwróć wartość najniższej temperatury.
            int result = temperatures[0];
            foreach (var temp in temperatures)
            {
                if (result > temp) result = temp;
            }
            return result;
        }
        //Set debug wherever you want, and click f10, to go line by line

        /// <summary>
        /// Return array of 2, where first is sum of provided values and second is the biggest provided value
        /// When 0 provided, method ends executing
        /// </summary>
        /// <returns>Array of 2 values [sum, max]</returns>
        public static int[] AskUntiltZeroIsPassed()
        {
            int[] result = { 0, 0 };
            int intValue = 0;
            do
            {
                Console.WriteLine("Insert value:");
                string value = Console.ReadLine();
                if(int.TryParse(value, out intValue))
                {
                    if (intValue == 0) break;

                    result[0] += intValue;
                    result[1] = result[1] > intValue ? result[1] : intValue;
                } else
                {
                    Console.WriteLine("Incorrect value");
                }
            }
            while (intValue != 0);

            return result;
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            int[] temperatures = { 123, 43, 23, 12, 34, 3, 123, 92, 299 };
            Console.WriteLine(TemperatureAnalyzer.FindLowestTemperature(temperatures));
            Console.WriteLine(TemperatureAnalyzer.FindHighestTemperature(temperatures));

            int[] result = TemperatureAnalyzer.AskUntiltZeroIsPassed();
            Console.WriteLine($"Sum: {result[0]}, Biggest value: {result[1]} ");
        }
    }
}
