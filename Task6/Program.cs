namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        List<String> fruit = new List<string>
        {
            "Pomegranate",
            "Apple",
            "Dragonfruit"
        };
        
        fruit.Add("Banana");
        fruit.Remove("Apple");
        
        Console.WriteLine("The list of fruits:");

        foreach (string f in fruit)
        {
            Console.WriteLine(f);
        }
        
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "mango" },
            { 2, "Orange" },
            { 3, "Pineapple" }
        };
        
        fruitDictionary.Add(4, "Amala");
        
        Console.WriteLine("\nFruit Dictionary:");

        foreach (KeyValuePair<int, string> item in fruitDictionary)
        {
            Console.WriteLine($"ID: {item.Key}, Fruit: {item.Value}");
        }

    }
}