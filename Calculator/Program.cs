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
                if (operation == "exit")
                {
                    break;
                }

                switch (operation)
                {
                    case "+":
                        result = Addition(first, second);
                        Console.WriteLine("{0}+{1} = {2}", first, second, result);
                        Console.ReadKey();
                        break;
                    case "-":
                        result = Subtraction(first, second);
                        Console.WriteLine("{0}-{1} = {2}", first, second, result);
                        Console.ReadKey();
                        break;
                    case "*":
                        result = Multiplication(first, second);
                        Console.WriteLine("{0}*{1} = {2}", first, second, result);
                        Console.ReadKey();
                        break;
                    case "/":
                        result = Division(first, second);
                        if (second == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("{0}/{1} = {2}", first, second, result);
                            Console.ReadKey();
                        }
                        break;
                    case "power":
                        result = Power(first, second);
                        Console.WriteLine("{0}^{1} = {2}", first, second, result);
                        Console.ReadKey();
                        break;
                    case "sqrt":
                        result = Squareroot(first);
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

        static double Addition(double first, double second)
        {
            return (first + second);
        }

        static double Subtraction(double first, double second)
        {
            return (first - second);
        }

        static double Multiplication(double first, double second)
        {
            return (first * second);
        }

        static double Division(double first, double second)
        {
            return (first / second);
        }

        static double Power(double first, double second)
        {
            return (Math.Pow(first, second));
        }
        static double Squareroot(double input)
        {
            return (Math.Sqrt(input));
        }
    }
}

