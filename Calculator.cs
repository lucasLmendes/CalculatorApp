namespace CalculatorApp
{
    public static class Calculator
    {
        public static double Calculate(double a, double b, string op) =>
            op switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" => b != 0 ? a / b : throw new DivideByZeroException(),
                _   => throw new InvalidOperationException("Operação inválida")
            };
    }
}
