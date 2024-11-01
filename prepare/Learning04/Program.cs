using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("John Doe", "Math"); 
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Jackson Johnson", "History", "Chapter 1", "1-10");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Alice Greedy", "Writing", "My Essay"); 
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}