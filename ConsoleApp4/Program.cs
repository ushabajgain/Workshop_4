// See https://aka.ms/new-console-template for more information

using ConsoleApp4;

public class Program
{
    static void Main(string[] args)
    {
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

        // Print static field
        Console.WriteLine("\nSchool Name : " + Student.schoolName);
    }
}
