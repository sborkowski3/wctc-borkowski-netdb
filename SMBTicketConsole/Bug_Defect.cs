using System;

public class Bug_Defect : Ticket_main
{	
        private string severity()
        {
            { Get; }
            Console.Write("Enter severity of bug or defect: ");
            string sev = Console.ReadLine();
            StreamWriter sw = new StreamWriter(file, append: true);
            sw.WriteLine(sev);
        }
    }
