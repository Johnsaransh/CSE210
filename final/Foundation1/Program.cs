using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Tech Review", "John Doe", 300);
        video1.AddComment("Mike", "Great review!");
        video1.AddComment("Anna", "Loved the details!");

        Video video2 = new Video("Sandbox", "Carl", 400);
        video2.AddComment("James", "Good Job!");
        video1.Display();

    }

}