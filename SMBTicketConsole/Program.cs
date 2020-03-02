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
            string file = "../../data/Ticket.txt";
            string choice;

            Console.WriteLine("1) View an existing ticket");
            Console.WriteLine("2) Create a new Bug and Defect ticket");
            Console.WriteLine("3) Create a new Enhancement ticket");
            Console.WriteLine("4) Create a new Task Ticket");
            Console.WriteLine("5) Enter any key to exit");
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
                    Bug_Defect = new Bug_Defect();
                }
                if (choice == "3"){
                 Enhancement = new Enhancement();
                }
                if (choice == "4"){
                    Task = new Task();
                }
            if (choice == "5"){
                Console.ReadLine();
                }
            }
        }
    }
}
