class GenericCollections
{

    public static void Run()
    {
        // List of fruits 
        List<string> fruits = new List<string> { "Apple", "Banana", "Orange" };
        fruits.Add("Mango");
        fruits.Remove("Banana");


        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }


        // Dictionary of fruits
        Dictionary<int, string> dFruits = new Dictionary<int, string>
        {
            {1, "Apple" },
            {2, "Banana" },
            {3, "Orange" }

        };

        dFruits.Add(4, "Mango");

        foreach (KeyValuePair<int, string> kvp in dFruits)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

    }

}