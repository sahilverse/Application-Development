class Calculator
{

    public Calculator()
    {
        Console.WriteLine("Welcome to the Calculator!");
    }
    public int Add(int a, int b)
    {
        return a + b;
    }


    public int Multiply(int a, int b = 1)
    {
        return a * b;
    }
}