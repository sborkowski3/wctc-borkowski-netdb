using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SMBTicketConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "TextFile1.txt";
            string choice;

            Console.WriteLine("1) View an existing ticket");
            Console.WriteLine("2) Create a new ticket");
            Console.WriteLine("3) Enter any key to exit");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                if (File.Exists(file))
                {
                    int TicketID = 0;
                    string summary;
                    StreamReader sr = new StreamReader(file);
                       while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                        string[] arr = line.Split('|');
                        Console.WriteLine("TicketID: {0}, Summary: {1}", arr[0], arr[1]);
                        TicketID += arr[1]
                }
                }

            }
        }
    }
}
