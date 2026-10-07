namespace Task2;

class Circle
{
    public const double PI = 3.14;
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PI = " + Circle.PI);
        Circle.PI = 3.14159;
        Console.WriteLine("New PI = " + Circle.PI);
        // as the value of PI is in const that means once it is declared the value cannot be changed. So, It gives error.
    }
}