using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTicket
{
    abstract class Ticket_Main
    {
        public int ID()
        {
            { Get; }
            Console.Write("Enter ID: ");
            int id = Console.ReadLine();
            StreamWriter sw = new StreamWriter(file, append: true);
            sw.WriteLine(id);
        }

        public string summary()
        {
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


        public string assign()
        {
            { Get; }
            Console.Write("Enter name assigned to this ticket: ");
            string assign = Console.ReadLine();
            StreamWriter sw = new StreamWriter(file, append: true);
            sw.WriteLine(assign);
        }

        public string watching()
        {
            { Get; }
            Console.Write("Enter Y or N for watching: ");
            string watch = Console.ReadLine();
            StreamWriter sw = new StreamWriter(file, append: true);
            sw.WriteLine(watch);
        }


    }
}