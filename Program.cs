using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Operação (+, -, *, /): ");
            var op = Console.ReadLine();

            Console.Write("Valor 1: ");
            var a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Valor 2: ");
            var b = Convert.ToDouble(Console.ReadLine());

            double resultado = Calculator.Calculate(a, b, op);

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
