class Student(string name, int age, string studentId)
{
    private string name = name;
    private int age = age;
    private string studentId = studentId;

    private static string SchoolName { get; } = "ABC High School";

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Student ID: {studentId}, School: {SchoolName}");
    }
}