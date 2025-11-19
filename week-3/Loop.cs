class Loop
{
    public static void PrintNumbersUpToN()
    {
        Console.Write("Enter a positive integer: ");
        string input = Console.ReadLine();


        if (int.TryParse(input, out int n) && n > 0)
        {
            Console.WriteLine($"Numbers from 1 to {n}:");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }

    public static void PrintTwentyNumbersWithWhileLoop()
    {
        int count = 1;
        Console.WriteLine("First 20 natural numbers:");

        while (count <= 20)
        {
            if (count % 4 == 0)
            {
                count++;
                continue;
            }

            if (count == 15)
            {
                break;
            }
            Console.Write(count + " ");
            count++;
        }

        Console.WriteLine();
    }

    public static void AddArrayElements(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        Console.WriteLine("Sum of array elements: " + sum);
    }


}