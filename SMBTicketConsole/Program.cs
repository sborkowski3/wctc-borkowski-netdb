using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SMBTicketConsoleRevise
{
    class Ticket
    {
        public Uint64 TicketId { get; set; }
        public string info { get; set; }
        public string Display()
        {
            return $"id{TicketId}\n Info:{info}/n";

        }
    }


    public class Uint64
    {
    }

    class Program
    {


        static void Main(string[] args)
        {
            String file = "TextFile1.txt";
            string line1 = "TicketID, Summary, Status, Priority, Submitter, Assigned, Watching";
            string choice;
            //string count;

            Console.WriteLine("1) View an existing ticket");
            Console.WriteLine("2) Create a new ticket");
            Console.WriteLine("3) Enter any key to exit");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                if (File.Exists(file))
                {
                    StreamReader sr = new StreamReader(file);
                    while (!sr.EndOfStream)
                    {
                        StreamWriter sw = new StreamWriter(file);
                        sw.WriteLine(line1);
                        sw.Close();
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist");
                }

                if (choice == "2")
                {
                    StreamWriter sw = new StreamWriter(file);
                    sw.WriteLine(line1);
                    sw.Close();

                    //    int TicketID = 0;
                    //    string line = Console.ReadLine();
                    //    string[] arr = line.Split('|');
                    //    Console.WriteLine("TicketID: {0}, Summary: {1}", arr[0], arr[1]);
                    //TicketID += arr[0] == " " ? 4 : arr[1] == " " ? 3;
                    //count += 1;

                    //string file = "TextFile.txt";

                }
                else
                {
                    Console.WriteLine("File does not exist");
                }


                if (choice == "3")
                {
                    Console.ReadLine();
                }
            }
        }
    }
}