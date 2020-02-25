using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MovieTicketRedo
{

    //class Ticket
    //{
    //    public Uint64 TicketId { get; set; }
    //    public string info { get; set; }
    //    public string Display()
    //    {
    //        return $"id{TicketId}\n Info:{info}/n";

    //    }
    //}


    //public class Uint64
    //{
    //}

    //class Program
    //{


    //    static void Main(string[] args)
    //    {
    //        String file = Path.Combine(Environment.CurrentDirectory, "Files", "TextFile1.txt");
    //        string line1 = "TicketID, Summary, Status, Priority, Submitter, Assigned, Watching";
    //        string choice;
    //        //string count;

    //        Console.WriteLine("1) View an existing ticket");
    //        Console.WriteLine("2) Create a new ticket");
    //        Console.WriteLine("3) Enter any key to exit");
    //        choice = Console.ReadLine();

    //        if (choice == "1")
    //        {
    //            if (File.Exists(file))
    //            {
    //                StreamReader sr = new StreamReader(file);
    //                while (!sr.EndOfStream)
    //                {
    //                    var line = sr.ReadLine();
    //                    Console.WriteLine(line);
    //                    //StreamWriter sw = new StreamWriter(file);
    //                    //sw.WriteLine(line1);
    //                }
    //                sr.Close();
    //            }
    //            else
    //            {
    //                Console.WriteLine("File does not exist");
    //            }


    //        }

    //        if (choice == "2")
    //        {
    //            Console.Write("Enter ID: ");
    //            var id = Console.ReadLine();

    //            Console.Write("Enter Summary: ");
    //            string sum = Console.ReadLine();

    //            Console.Write("Enter Ticket Status: ");
    //            string stat = Console.ReadLine();

    //            Console.Write("Enter Priority number from 0-5: ");
    //            String pri = Console.ReadLine();

    //            Console.Write("Enter your name: ");
    //            string name = Console.ReadLine();

    //            Console.Write("Enter name assigned to this ticket: ");
    //            string assign = Console.ReadLine();

    //            Console.Write("Enter Y or N for watching: ");
    //            string watch = Console.ReadLine();

    //            StreamWriter sw = new StreamWriter(file, append:true);
    //            sw.WriteLine(id);
    //            sw.WriteLine(sum);
    //            sw.WriteLine(stat);
    //            sw.WriteLine(pri);
    //            sw.WriteLine(name);
    //            sw.WriteLine(assign);
    //            sw.WriteLine(watch);


    //            sw.Close();

    //            //    int TicketID = 0;
    //            //    string line = Console.ReadLine();
    //            //    string[] arr = line.Split('|');
    //            //    Console.WriteLine("TicketID: {0}, Summary: {1}", arr[0], arr[1]);
    //            //TicketID += arr[0] == " " ? 4 : arr[1] == " " ? 3;
    //            //count += 1;

    //            //string file = "TextFile.txt";

    //        }

    //        if (choice == "3")
    //        {
    //            Console.ReadLine();
    //        }
    //    }
    //}
}