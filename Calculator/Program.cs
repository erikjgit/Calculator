using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double first;
            double second;
            double result;
            string operation;
            string input;

            while (true)
            {

                Console.WriteLine("Input an integer. Finish with enter.");
                input = Console.ReadLine();
                if (!(Double.TryParse(input, out first)))

                {
                    while (!(Double.TryParse(input, out first)))
                    {
                        Console.WriteLine("That was not an integer. Please Try again.");
                        input = Console.ReadLine();
                    }
                }

                Console.WriteLine("Input another integer. Finish with enter.");
                input = Console.ReadLine();
                if (!(Double.TryParse(input, out second)))
                {
                    while (!(Double.TryParse(input, out second)))
                    {
                        Console.WriteLine("That was not an integer. Please Try again.");
                        input = Console.ReadLine();
                    }
                }

                Console.WriteLine("Choose operation:\n The options are +, -, *, /, power and sqrt. Type exit to end the program. ");
                operation = Console.ReadLine();
                if(operation=="exit")
                {
                    break;
                }

                switch(operation){
                    case"+":
                        result = addition(first, second);
                        Console.WriteLine("{0}+{1} = {2}",first, second, result);
                        Console.ReadKey();
                        break;
                    case "-":
                        result = subtraction(first, second);
                        Console.WriteLine("{0}-{1} = {2}", first, second, result);
                        Console.ReadKey();
                        break;
                    case "*":
                        result = multiplication(first, second);
                        Console.WriteLine("{0}*{1} = {2}", first, second, result);
                        Console.ReadKey();
                        break;
                    case "/":
                        result = division(first, second);
                        Console.WriteLine("{0}/{1} = {2}", first, second, result);
                        Console.ReadKey();
                        break;
                    case "power":
                        result = power(first, second);
                        Console.WriteLine("{0}^{1} = {2}", first, second, result);
                        Console.ReadKey();
                        break;
                    case "sqrt":
                        result = squareroot(first);
                        Console.WriteLine("sqrt({0}) = {1}", first, result);
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        Console.ReadKey();
                        break;
                }
            }


        } //end of main

        static double addition(double first, double second)
        {
            return (first + second);
        }

        static double subtraction(double first, double second)
        {
            return (first - second);
        }

        static double multiplication(double first, double second)
        {
            return (first * second);
        }

        static double division(double first, double second)
        {
            return (first / second);
        }

        static double power(double first, double second)
        {
            return (Math.Pow(first, second));
        }
        static double squareroot(double input)
        {
            return (Math.Sqrt(input));
        }
    }
}
