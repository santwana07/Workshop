namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        // integer array with 5 numbers
        int[] num = { 20, 15, 42, 10, 30 };

        // Sorting array in ascending order
        Array.Sort(num);

        // now, reversing the sorted array
        Array.Reverse(num);

        // Print each element using a for loop
        Console.WriteLine("Array elements:");

        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine(num[i]);
        }

        // Find the position of a specific number
        int search = 20;
        int position = Array.IndexOf(num, search);

        Console.WriteLine("Position of " + search + ": " + position);
    }
}