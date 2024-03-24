using System;

namespace Coding.Exercise
{

    public class BMI
    {
        /// <summary>
        /// Calcualte BMI
        /// </summary>
        /// <param name="weight">kg, ex 195</param>
        /// <param name="height">meters, ex: 1.95</param>
        /// <returns></returns>
        public static float CalculateBMI(float weight, float height)
        { 
            return weight / (height * height);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj wzrost (m)");
            string height = Console.ReadLine();
            Console.WriteLine("Podaj wagę (kg)");
            string wieght = Console.ReadLine();

            float floatHeight;
            float floatWeight;
            if(float.TryParse(height, out floatHeight) && float.TryParse(wieght, out floatWeight)) {
                float result = BMI.CalculateBMI(floatWeight, floatHeight);
                Console.WriteLine(result);

            }
        }
    }
}
