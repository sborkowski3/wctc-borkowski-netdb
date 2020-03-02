using System;

abstract class Bug_Defect
{
    public int ID()
    {
        {Get; }
        Console.Write("Enter ID: ");
        int id = Console.ReadLine();
        StreamWriter sw = new StreamWriter(file, append: true);
        sw.WriteLine(id);
    }

    public string summary() {
        { Get; }
        Console.Write("Enter Summary: ");
        string sum = Console.ReadLine();
        StreamWriter sw = new StreamWriter(file, append: true);
        sw.WriteLine(sum);
    }
    public string status()
    {
        { Get; }
        Console.Write("Enter Ticket Status: ");
        string stat = Console.ReadLine();
        StreamWriter sw = new StreamWriter(file, append: true);
        sw.WriteLine(stat);
    }

    public int priority()
    {
        { Get; }
        Console.Write("Enter Priority number from 0-5: ");
        int sum = Console.ReadLine();
        StreamWriter sw = new StreamWriter(file, append: true);
        sw.WriteLine(sum);
    }

    public string name()
    {
        { Get; }
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        StreamWriter sw = new StreamWriter(file, append: true);
        sw.WriteLine(name);
    }

    public string assign()
    {
        { Get; }
        Console.Write("Enter name assigned to this ticket: ");
        string assign = Console.ReadLine();
        StreamWriter sw = new StreamWriter(file, append: true);
        sw.WriteLine(assign);
    }

 

                    Console.Write("Enter Y or N for watching: ");
                  string watch = Console.ReadLine();

                   StreamWriter sw = new StreamWriter(file, append:true);
                   sw.WriteLine(id);
                  sw.WriteLine(sum);
                  sw.WriteLine(stat);
                  sw.WriteLine(pri);
                   sw.WriteLine(name);
                   sw.WriteLine(assign);
                   sw.WriteLine(watch);
    }
}
