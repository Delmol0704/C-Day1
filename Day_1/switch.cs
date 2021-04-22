using System.IO;
using System;

class Program
{
    static void Main(string[] arg)
    {
      
       Console.WriteLine("Enter what you want to do \n 1. Addition \n 2. Subtraction \n 3. Multiplication");
       int choice = Convert.ToInt32(Console.ReadLine());
       switch (choice)
       {
           case 1:
           Console.WriteLine("ADD");
           break;
           case 2:
           Console.WriteLine("SUBTRACT");
           break;
           case 3:
           Console.WriteLine("MULTIPLY");
           break;
           default:
           Console.WriteLine("Nothing");
           break;
           
       }
    }
}