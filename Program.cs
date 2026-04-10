using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("-----------------");

        while (true)
        {
            Console.Write("Enter first number (or 'q' to quit): ");
            string input = Console.ReadLine();
            if (input == "q") break;

            if (!double.TryParse(input, out double a))
            {
                Console.WriteLine("Invalid number.");
                continue;
            }

            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Invalid number.");
                continue;
            }

            double result;
            switch (op)
            {
                case "+": result = a + b; break;
                case "-": result = a - b; break;
                case "*": result = a * b; break;
                case "/":
                    if (b == 0) { Console.WriteLine("Cannot divide by zero."); continue; }
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("Unknown operator.");
                    continue;
            }

            Console.WriteLine($"Result: {result}\n");
        }
    }
}
