class Program
{
    public static void PrintPersonalInfo(string name, int age, string city)
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"City: {city}");
    }


    static void Main(string[] args)
    {
        PrintPersonalInfo("Sahil", 24, "Itahari");
        Quote quote = new();

        Console.WriteLine("\nMotivational Quote of the Day:");
        quote.DisplayQuote();
    }
}
