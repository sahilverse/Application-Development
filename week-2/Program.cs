class Program
{
    static void Main()
    {

        // Task 1
        string userName = "Sahil Dahal";
        int luckeyNumber = 3;

        Console.WriteLine($"Hello, {userName}! Your lucky number is {luckeyNumber}.");


        // Task 2

        Circle circle = new();
        // circle.PI = 3.14;  // Error: Cannot assign to 'PI' because it is a 'const' field. constants are immutable


        // Task 3
        DataTypes.Run();


        // Task 4
        int[] numbers = [10, 5, 7, 4, 3, 6];

        // Sort the array in ascending order
        Array.Sort(numbers);
        Console.WriteLine("Sorted array in ascending order: " + string.Join(", ", numbers));

        // Reverse the sorted array
        Array.Reverse(numbers);
        Console.WriteLine("Reversed array: " + string.Join(", ", numbers));


        // Print the each element of the array

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // position of number 5 in the array
        int position = Array.IndexOf(numbers, 5);
        Console.WriteLine($"The index of number 5 in the array is: {position}");


        // Task 5
        DateTimeTask.Run();

        // Task 6
        GenericCollections.Run();


    }
}