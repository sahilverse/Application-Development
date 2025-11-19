class NullOperations
{

    public static void PerformNullCheck()
    {
        string username = null;

        string ternaryResult = username != null ? username : "Guest";
        Console.WriteLine("Ternary Operator Result: " + ternaryResult);

        string nullCoalescingResult = username ?? "Guest";
        Console.WriteLine("Null Coalescing Operator Result: " + nullCoalescingResult);

        username ??= "Sahil";
        Console.WriteLine("After Null Coalescing Assignment: " + username);
    }

}