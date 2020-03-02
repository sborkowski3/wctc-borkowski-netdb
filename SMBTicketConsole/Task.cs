using System;

public class Task : Ticket_main
{
    private string ProjectName()
    {
        { Get; }
        Console.Write("Enter name of project: ");
        string proj = Console.ReadLine();
        StreamWriter sw = new StreamWriter(file, append: true);
        sw.WriteLine(proj);
         }
    private DateTime DueDate()
    {
        { Get; }
        Console.Write("Enter due date of project: ");
        DateTime due = Console.ReadLine();
        StreamWriter sw = new StreamWriter(file, append: true);
        sw.WriteLine(due);
    }
}
