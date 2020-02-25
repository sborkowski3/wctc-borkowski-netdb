using System;

public class MovieTicket
{
	public MovieTicket()
	{
        Console.Write("Enter Movie ID: ");
        var id = Console.ReadLine();

        Console.Write("Enter Movie Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Movie Genre: ");
        string gen = Console.ReadLine();

        Console.Write("Enter Movie Year: ");
        String year = Console.ReadLine();

        StreamWriter sw = new StreamWriter(file, append: true);
        sw.WriteLine(id);
        sw.WriteLine(title);
        sw.WriteLine(gen);
        sw.WriteLine(year);

        sw.Close();
    }
}
