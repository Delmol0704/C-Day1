using System.IO;
using System;

class Program
{
    static void Main(string[] arg)
    {
     
      int [,] arr = new int[3,3];  
      Console.WriteLine("Enter the elements");
      //2D MATRIX
      /*for(int row=0; row<arr.GetLength(0); row++)
      {
          for(int column=0; column<arr.GetLength(1); column++)
          {
          arr[row,column] = Convert.ToInt32(Console.ReadLine());
          Console.Write(arr[row,column]+"\t");
          }
          Console.Write("\n");
      }*/
     
     
     
    //TRANSPOSE
     for(int row=0; row<arr.GetLength(0); row++)
      {
          for(int column=0; column<arr.GetLength(1); column++)
          {
          arr[row,column] = Convert.ToInt32(Console.ReadLine());
          }
      }
      for(int row=0; row<arr.GetLength(0); row++)
      {
          for(int column=0; column<arr.GetLength(1); column++)
          {
          Console.Write(arr[column,row]+"\t");
          }
          Console.Write("\n");
      }
      
       
    }
}