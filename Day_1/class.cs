using System.IO;
using System;

class Student
{
    public int RollNumber{get;set;}
    public string Name{get;set;}
    public string Gender{get;set;}
    static void Main(string[] arg)
    {
     Student student = new Student();
     student.RollNumber = 1;
     student.Name = "Delmol";
     student.Gender = "Female";
     Console.WriteLine(student.RollNumber+"\t"+student.Name+"\t"+student.Gender);
    }
}