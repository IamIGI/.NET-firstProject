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
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            int[] temperatures = { 123, 43, 23, 12, 34, 3, 123, 92, 299 };
            Console.WriteLine(TemperatureAnalyzer.FindLowestTemperature(temperatures));
            Console.WriteLine(TemperatureAnalyzer.FindHighestTemperature(temperatures));
        }
    }
}
