class Program
{

    enum DayType
    {
        Weekday,
        Weekend
    }

    record Book(string Title, string Author, double Price);

    static void CheckDayType()
    {
        Console.Write("Enter the day (e.g., Sunday): ");
        string? dayInput = Console.ReadLine()?.Trim();

        DayType dayType;


        if (string.Equals(dayInput, "Friday", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(dayInput, "Saturday", StringComparison.OrdinalIgnoreCase))
        {
            dayType = DayType.Weekend;
        }
        else
        {
            dayType = DayType.Weekday;
        }

        Console.WriteLine($"It is: {dayType}");
    }


    static void CalculatePercentage()
    {
        Console.Write("Enter the total marks: ");

        if (!int.TryParse(Console.ReadLine(), out int total) || total <= 0)
        {
            Console.WriteLine("Invalid input for total marks.");
            return;
        }

        Console.Write("Enter the obtained marks: ");

        if (!int.TryParse(Console.ReadLine(), out int obtained))
        {
            Console.WriteLine("Invalid input for obtained marks.");
            return;
        }

        double percentage = (double)obtained / total * 100;


        Console.WriteLine($"Percentage: {percentage}%");

    }
    static void Main(string[] args)
    {
        // Task 1: Create Student objects
        Student student1 = new Student("Alice", 16, "S1001");
        Student student2 = new Student("Bob", 17, "S1002");

        // Print details of the students
        student1.PrintDetails();
        student2.PrintDetails();

        // Print static field 
        Console.WriteLine(Student.SchoolName);


        // Task 2: Use Calculator
        Calculator calculator = new Calculator();
        int sum = calculator.Add(5, 10);
        Console.WriteLine($"Sum: {sum}");

        // Multiply with both parameter
        int productWithBothParameter = calculator.Multiply(5, 10);
        Console.WriteLine($"Product: {productWithBothParameter}");

        // Multiply with default parameter
        int productWithDefault = calculator.Multiply(5);
        Console.WriteLine($"Product with default: {productWithDefault}");



        // Task 3: Use ParameterDemo
        ParameterDemo demo = new ParameterDemo();

        // Using ref parameter
        int number = 20;
        Console.WriteLine($"Original Number: {number}");
        demo.Increase(ref number);
        Console.WriteLine($"Increased Number: {number}");


        // Using out parameter
        demo.GetFullName(out string fullName);
        Console.WriteLine($"Full Name: {fullName}");

        // Using params parameter
        int total = demo.SumAll(1, 2, 3, 4, 5);
        Console.WriteLine($"Total Sum: {total}");


        // Task 4: Create Player objects
        Player player1 = new();

        player1.playerName = "Player1";
        player1.level = 1;
        player1.health = 100;
        player1.PrintDetails();

        Player player2 = new("Player2", 5, 200);
        player2.PrintDetails();


        // Task 5:
        CheckDayType();

        Book book1 = new("The Great Gatsby", "F. Scott Fitzgerald", 1000);
        Console.WriteLine($"Book: {book1.Title}, Author: {book1.Author}, Price: {book1.Price}");

        Book book2 = book1 with { Title = "Ijoriya", Price = 500 };


        var (title, author, price) = book2;
        Console.WriteLine("Deconstructed Book Details:");
        Console.WriteLine($"Title: {title}, Author: {author}, Price: {price}");


        // Task 6:
        CalculatePercentage();



    }
}