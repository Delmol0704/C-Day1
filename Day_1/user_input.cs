using System.IO;
using System;

class Program
{
    static void Main(string[] arg)
    {
	int firstnumber, secondnumber, result;
        Console.WriteLine("Enter first number : ");
        firstnumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number : ");
        secondnumber = Convert.ToInt32(Console.ReadLine());
        result = firstnumber + secondnumber;
        Console.WriteLine("Sum is "+result);
    }
}