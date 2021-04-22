using System.IO;
using System;

class Program
{
    static void Main(string[] arg)
    {
       int age;
       Console.WriteLine("Enter the age");
       age = Convert.ToInt32(Console.ReadLine());
       if(age >= 18)
       {
           Console.WriteLine("Person is eligible to vote");
       }
       else
       {
        Console.WriteLine("Person is not eligible to vote");   
       }
    

       int age;
       Console.WriteLine("Enter the age");
       age = Convert.ToInt32(Console.ReadLine());
        if(age < 18)
       {
           Console.WriteLine("Person is not eligible to vote");
       }
       
      else if(age >=60)
       {
        Console.WriteLine("Person is a senior citizen");   
       }
       else if(age ==18)
       {
        Console.WriteLine("Person is eligible to vote");   
       }
    }
}