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
            string file = "../../data/movies.txt";
            //string line1 = "TicketID, Summary, Status, Priority, Submitter, Assigned, Watching";
            string choice;

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
                      
               
               
                if (choice == "2"){
                    Ticket = new Ticket();
}
                else
                {
                    Console.WriteLine("File does not exist");
                }
                

            if (choice == 3){
                Console.ReadLine();
                }
            }
        }
    }
}
