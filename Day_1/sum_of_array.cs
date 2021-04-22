using System.IO;
using System;

class Program
{
    static void Main(string[] arg)
    {
     
      int[] arr = new int[5];  
      int sum=0;
      Console.WriteLine("Enter the elements");
      for(int i=0; i<arr.Length; i++)
      {
          arr[i] = Convert.ToInt32(Console.ReadLine());
          Console.Write(arr[i]+" ");
          sum = sum + arr[i];
      }
     
      Console.WriteLine("\n Sum is "+sum);
       
    }
}