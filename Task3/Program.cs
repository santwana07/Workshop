namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        byte num1 = 25;
        short num2 = 10;
        int num3 = 5;
        long num4 = 7;
        float num5 = 1.5f;
        double num6 = 1.5;
        decimal num7 = 1.25m;
        char num8 = 'a';
        bool num9 = true;
        
        //now converting integer into string
        int Snum = 42;
        string intToString = Snum.ToString();
        
        //Converting string into double
        double stringToDouble = Convert.ToDouble("3.14");
        
        Console.WriteLine("byte: " + num1);
        Console.WriteLine("short: " + num2);
        Console.WriteLine("int: " + num3);
        Console.WriteLine("long: " + num4);
        Console.WriteLine("float: " + num5);
        Console.WriteLine("double: " + num6);
        Console.WriteLine("decimal: " + num7);
        Console.WriteLine("char: " + num8);
        
        Console.WriteLine("string: " + intToString);
        Console.WriteLine("string: " + stringToDouble);
    }
}