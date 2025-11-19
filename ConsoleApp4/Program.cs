// See https://aka.ms/new-console-template for more information

using ConsoleApp4;

public class Program
{

    static void Main(string[] args)
    {
        //------------------------------------- Task 1 -----------------------------------------

        // Creating first object
        Student s1 = new Student();
        s1.name = "Usha";
        s1.age = 20;
        s1.address = "Biratnagar";

        // Creating second object
        Student s2 = new Student();
        s2.name = "Shakespeare";
        s2.age = 22;
        s2.address = "Pokhara";

        Console.WriteLine("Student 1:");
        Console.WriteLine("Name: " + s1.name);
        Console.WriteLine("Age: " + s1.age);
        Console.WriteLine("Address: " + s1.address);

        Console.WriteLine("\nStudent 2:");
        Console.WriteLine("Name: " + s2.name);
        Console.WriteLine("Age: " + s2.age);
        Console.WriteLine("Address: " + s2.address);

        // Printing static field
        Console.WriteLine("\nSchool Name : " + Student.schoolName);


        //-------------------------------- Task 2 --------------------------------------
        Calculator calc = new Calculator();
        calc.PrintWelcome();

        // Add
        int sum = calc.Add(5, 7);
        Console.WriteLine("Addition: " + sum);

        // Multiply
        int product1 = calc.Multiply(4, 3);
        Console.WriteLine("Multiplication(4 * 3): " + product1);

        // optional parameter
        int product2 = calc.Multiply(6);
        Console.WriteLine("Multiplication Result (6 * default 1): " + product2);


        //----------------------------------- Task 3 ------------------------------------------

        ParameterDemo demo = new ParameterDemo();

        int value = 5;
        demo.Increase(ref value);
        Console.WriteLine("Value after Increase: " + value);

        string myName;
        demo.GetFullName(out myName);
        Console.WriteLine("Full Name from GetFullName: " + myName);

        int total = demo.SumAll(5, 10, 15, 20);
        Console.WriteLine("Sum of all numbers: " + total);

        //------------------------------------- Task 4 ------------------------------------------
        
        Player p1 = new Player();
        Console.WriteLine("Player 1 Details:");
        Console.WriteLine("Name: " + p1.playerName);
        Console.WriteLine("Level: " + p1.level);
        Console.WriteLine("Health: " + p1.health);

        Console.WriteLine();

        Player p2 = new Player("Usha", 5, 100);
        Console.WriteLine("Player 2 Details:");
        Console.WriteLine("Name: " + p2.playerName);
        Console.WriteLine("Level: " + p2.level);
        Console.WriteLine("Health: " + p2.health);
        
        //-------------------------------------- Task 5 ------------------------------------------
        // ----------- DayType ------------

        Console.Write("Enter a day: ");
        string day = Console.ReadLine();

        DayType dayType;

        if (day.Equals("Friday", StringComparison.OrdinalIgnoreCase) ||
            day.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
        {
            dayType = DayType.Weekend;
        }
        else
        {
            dayType = DayType.Weekday;
        }

        Console.WriteLine($"It is: {dayType}");

        Console.WriteLine("\n--- Book Record Demo ---");

        // ----------- Book Record ------------

        // First book object
        BookRecord book1 = new BookRecord("Programming Basics", "Usha Bajgain", 500.00);

        // Creating second book by modifying title and price
        BookRecord book2 = book1 with { title = "C# Basics", price = 600.00 };

        // Printing first book
        Console.WriteLine("\nBook 1:");
        Console.WriteLine(book1);

        // Deconstructing second book
        var (title, author, price) = book2;

        Console.WriteLine("\nBook 2 :");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
        
        //---------------------------------- Task 6 -----------------------------------------
        
        Console.Write("Enter marks: ");
        bool isMarksValid = int.TryParse(Console.ReadLine(), out int marks);

        Console.Write("Enter total: ");
        bool isTotalValid = int.TryParse(Console.ReadLine(), out int totall);

        if (!isMarksValid || !isTotalValid || totall <= 0)
        {
            Console.WriteLine("Invalid input. Please enter valid integers and total cannot be zero.");
            return;
        }
        // BREAKPOINT 1 
        // double percentage = marks / totall * 100; 
        double percentage = (double)marks / totall * 100;
        
        // BREAKPOINT 2 
        Console.WriteLine("Percentage: " + percentage);
    }
}
