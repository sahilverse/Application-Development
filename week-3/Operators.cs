class Operators
{
    public static void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    public static void Subtract(int a, int b)
    {
        Console.WriteLine(a - b);
    }

    public static void Multiply(int a, int b)
    {
        Console.WriteLine(a * b);
    }

    public static void Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Denominator cannot be zero.");
        }
        Console.WriteLine((double)a / b);
    }

    public static void OddEvenFinder(int number)
    {
        Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");
    }
}