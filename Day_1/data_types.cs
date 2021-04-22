using System.IO;
using System;

class Program
{
    static void Main(string[] arg)
    {
        int a=5;
        int b=4;
        Console.WriteLine("Sum of "+a+"+"+b+" = "+(a+b));
        Console.WriteLine(a-b);
        Console.WriteLine(a*b);
        Console.WriteLine(a/b);
        Console.WriteLine(a==b);

	string name = "Delmol";
        int age = 22;
        char gender = 'F';
        float percentage = 75.34F;
        Console.WriteLine("Name: {0}",name);
        Console.WriteLine("Age: {0} ", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Percentage: {0]", percentage);
     }
}       