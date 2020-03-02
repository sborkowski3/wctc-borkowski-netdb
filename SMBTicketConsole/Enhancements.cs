using System;

public class Enhancements : Ticket_main
{
    private string software()
    {
        { Get; }
        Console.Write("Enter name of Software affected: ");
        string soft = Console.ReadLine();
        StreamWriter sw = new StreamWriter(file, append: true);
        sw.WriteLine(soft);
    }

    private double cost()
    {
        { Get; }
        Console.Write("Enter cost of project in dollars and cents($0.00): $ ");
        double cost = Console.ReadLine();
        StreamWriter sw = new StreamWriter(file, append: true);
        sw.WriteLine(cost);
    }

    private string reason()
    {
        { Get; }
        Console.Write("Enter reason for enhancement: ");
        string reas = Console.ReadLine();
        StreamWriter sw = new StreamWriter(file, append: true);
        sw.WriteLine(reas);
    }
    private double estimate()
    {
        { Get; }
        Console.Write("Enter estimate of project in dollars and cents($0.00): $ ");
        double est = Console.ReadLine();
        StreamWriter sw = new StreamWriter(file, append: true);
        sw.WriteLine(est);
    }

}
