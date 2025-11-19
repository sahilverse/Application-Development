class ParameterDemo
{

    public void Increase(ref int number)
    {
        number += 10;
    }


    public void GetFullName(out string fullName)
    {
        fullName = "John Doe";
    }

    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}
