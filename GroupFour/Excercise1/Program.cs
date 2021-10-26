using System;

namespace Exercise1
{
    public class MathUtils
    {
        public static double Average(int a, float b)
        {

            //public static double Average(int a, int b)
            // Convert int to float due to  integer arithmetic, b needs to be a float due to dividen by 2
            return a + b / 2;
        }

        public static double Average2(int a, float b)
        {
            return (a + b) / 2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Average(2, 1));
            Console.WriteLine(Average2(2, 1));
        }
    }
}
