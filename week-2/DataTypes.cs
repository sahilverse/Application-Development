class DataTypes
{
    public static void Run()
    {
        // 1. Declare and initialize variables of different types
        byte myByte = 255;
        short myShort = 32000;
        int myInt = 42;
        long myLong = 1234567890;
        float myFloat = 3.14f;
        double myDouble = 3.14159265359;
        decimal myDecimal = 10.5m;
        char myChar = 'A';
        bool myBool = true;

        // 2. Type conversions
        string intToString = myInt.ToString();          
        double stringToDouble = double.Parse("3.14"); 

        // 3. Print variable values
        Console.WriteLine("Type       | Value");
        Console.WriteLine("------------------------");
        Console.WriteLine($"byte       | {myByte}");
        Console.WriteLine($"short      | {myShort}");
        Console.WriteLine($"int        | {myInt}");
        Console.WriteLine($"long       | {myLong}");
        Console.WriteLine($"float      | {myFloat}");
        Console.WriteLine($"double     | {myDouble}");
        Console.WriteLine($"decimal    | {myDecimal}");
        Console.WriteLine($"char       | {myChar}");
        Console.WriteLine($"bool       | {myBool}");
        Console.WriteLine($"int -> str | {intToString}");
        Console.WriteLine($"str -> dbl | {stringToDouble}");
    }
}

