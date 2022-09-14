using System;

namespace OperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //For division, create two integer variables called a and b

            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainer = a % b;

            
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainer}");

            Console.WriteLine("Please enter the radius of your circle:");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));
        }

        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
    }
}

