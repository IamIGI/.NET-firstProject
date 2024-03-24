using System;

namespace Coding.Exercise
{
   
        public class ParkingCalculator
        {
            public static double CalculateParkingFee(int hours)
            {
                double result = 0;
            // TODO: Uzupełnij implementację kalkulatora opłat za parkowanie
            switch (hours)
            {
                case 1:
                    result = 5;
                    break;

                default:
                    int remainingHours = hours - 1;
                    result = 5 + remainingHours * 3;
                    break;
            }

            return result;
            }
        }
    

    class Program
    {
        static void Main(string[] args)
        {

            double result = ParkingCalculator.CalculateParkingFee(1);

            Console.WriteLine(result);
        }
    }
}
