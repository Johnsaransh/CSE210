using System;

class Program
{
    static void Main(string[] args)
    {
     math mathAssignment = new math("Algebra Homework", "Algebra Textbook", "1-10, 12, 15");
     writing writingAssignment = new writing("Essay Assignment", "The Great Gatsby");
     Console.WriteLine(mathAssignment.GetHomeworkList());
     Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}