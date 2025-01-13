using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int number = int.Parse(percentage);

        string letter = "";

        if(number >= 90) {
            letter = "A";
        }
        else if (number >= 80) {
            letter = "B";
        }
        else if (number >= 70) {
            letter = "C";        
        }
        else if (number >= 60) {
            letter = "D";
        }
        else {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if(number >= 70){
            Console.WriteLine("Congratulations! You passed!");
        } else {
            Console.WriteLine("You got it next time!");
        }
    }
}