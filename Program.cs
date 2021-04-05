using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1- story with default methods, writeline and readline

            /* Console.WriteLine("Hello. What is your name?");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Nice name! Now what is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("That one is pretty! Now what is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("Those are so cute! Lastly, what is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine("Cool! Now for your whole story, press 'ENTER'");
            Console.ReadLine();
            Console.WriteLine($"Once there was a person named {name}. {name} really liked the color {color}. \n" +
                $"Their favorite animal was the mighty {animal}. Their best quality, however, was that they love \n" +
                $"the band {band}.");  */

            //exercise 2- creating methods to do math


            var result = Add(2, 4);
            Console.WriteLine(result);

            var subResult = Sub(6, 2);
            Console.WriteLine(subResult);

        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
