class DateTimeTask
{
    public static void Run()
    {
        // Birth date
        DateTime birthDate = new(2000, 12, 20);
        Console.WriteLine($"Your birth date is: {birthDate.ToShortDateString()}");


        // current date and time
        DateTime currentDate = DateTime.Now;
        Console.WriteLine($"Current date and time is: {currentDate}");

        // Calculate age
        int age = CalculateAge(birthDate, currentDate);
        Console.WriteLine($"You are {age} years old.");

        // Add 10 days to birth date
        DateTime birthDatePlus10 = birthDate.AddDays(10);
        Console.WriteLine($"Your birth date plus 10 days is: {birthDatePlus10.ToShortDateString()}");


    }


    private static int CalculateAge(DateTime birthDate, DateTime currentDate)
    {
        TimeSpan ageSpan = currentDate - birthDate;
        return (int)(ageSpan.Days / 365.25);
    }
}