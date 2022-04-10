using System;

namespace _41
{
    class Program
    {
        static void Main(string[] args)
        {
            var special41 = 41;
            var special41square = special41 * special41;
            
            for (int i = 0; special41square - (i * 2) > special41; i++)
            {
                var value = special41 + (i * 2);
                
                Console.WriteLine(value + " is prime? : " + IsPrime(value));
                special41 = value;
            }
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
