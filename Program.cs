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

            double resultado = op switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" => b != 0 ? a / b : throw new DivideByZeroException(),
                _ => throw new InvalidOperationException("Operação inválida")
            };

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
