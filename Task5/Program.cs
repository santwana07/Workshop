namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        //  DateTime variable for birthdate
        DateTime birthdate = new DateTime(1993, 5, 15);
        
        DateTime currentDate = DateTime.Now;
        
        TimeSpan ageDifference = currentDate - birthdate;
        
        int age = (int)(ageDifference.TotalDays / 365.25);
        
        Console.WriteLine("Birthdate: " + birthdate.ToShortDateString());
        Console.WriteLine("Current Date: " + currentDate);
        Console.WriteLine("Age: " + age + " years");
        
        DateTime newDate = birthdate.AddDays(10);

        Console.WriteLine("Birthdate after adding 10 days: " 
                          + newDate.ToShortDateString());
    }
}