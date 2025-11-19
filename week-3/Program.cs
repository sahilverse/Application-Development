class Program
{

    static void CheckAge()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            if (age < 13)
            {
                Console.WriteLine("Child");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("Teenager");
            }
            else
            {
                Console.WriteLine("Adult");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }

    }

    static void CheckDay()
    {
        Console.Write("Enter a number (1-7): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int dayNumber))
        {
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }

    }


    static void NumberConversionWithErrorHandling()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        try
        {
            int number = Convert.ToInt32(input);
            Console.WriteLine("You entered: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Format Exception: Please enter a valid number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }

    }


    static void ValidatePassword()
    {
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        if (string.IsNullOrEmpty(password))
        {
            throw new ArgumentException("Password cannot be null or empty.");
        }

        if (password.Length < 6)
        {
            throw new ArgumentException("Password must be at least 6 characters long.");
        }

        Console.WriteLine("Password Satisfied the requirement.");
    }


    static void Main(string[] args)
    {

        // Task 1: Using Operators class methods
        Operators.Add(5, 3);
        Operators.Subtract(10, 4);
        Operators.Multiply(6, 7);
        Operators.Divide(20, 5);
        Operators.OddEvenFinder(9);


        // Task 2: Using NullOperations class method
        NullOperations.PerformNullCheck();

        // Task 3: Check Age
        CheckAge();

        // Task 4: Check Day
        CheckDay();


        // Task 5: Using Loop class methods
        Loop.PrintNumbersUpToN();
        Loop.PrintTwentyNumbersWithWhileLoop();
        int[] numbers = [1, 2, 3, 4, 5];
        Loop.AddArrayElements(numbers);


        // Task 6
        NumberConversionWithErrorHandling();
        try
        {
            ValidatePassword();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Password Validation Error: " + ex.Message);
        }

    }

}