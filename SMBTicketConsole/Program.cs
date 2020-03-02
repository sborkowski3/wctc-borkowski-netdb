using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLog;


private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

namespace SMBTicketConsole
{


    static void Main(string[] args)
    {
        logger.Info("Program started");

        string file = "../../data/movies.txt";


        if (!File.Exists(file))
        {
            logger.Error("File does not exist: {File}", file);



            Console.WriteLine("1) View an existing Movie");
            Console.WriteLine("2) Create a new Movie");
            Console.WriteLine("3) Enter any key to exit");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                if (File.Exists(movies.txt))
                {
                    StreamReader sr = new StreamReader(file);
                    for (int i = 0; i < MovieIds.Count; i++)
                    {
                        Console.WriteLine($"MovieID: {MovieIds[i]}");
                        Console.WriteLine($"Title: {MovieTitles[i]}");
                        Console.WriteLine($"Genre: {MovieGenres[i]}");
                        Console.WriteLine($"Year: {MovieYears[i]}");
                        Console.WriteLine();

                    }

                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        Console.WriteLine(line);

                    }
                    sr.Close();
                }
                else
                {
                    Console.WriteLine("File does not exist");
                }


            }

            if (choice == "2")
            {
                MovieTicket = new MovieTicket();

                // Console.Write("Enter Movie ID: ");
                // var id = Console.ReadLine();

                //  Console.Write("Enter Movie Title: ");
                //  string title = Console.ReadLine();

                //   Console.Write("Enter Movie Genre: ");
                //  string gen = Console.ReadLine();

                //   Console.Write("Enter Movie Year: ");
                //   String year = Console.ReadLine();

                //     StreamWriter sw = new StreamWriter(file, append:true);
                //   sw.WriteLine(id);
                //   sw.WriteLine(title);
                //    sw.WriteLine(gen);
                //   sw.WriteLine(year);

                //   sw.Close();   

            }

            if (choice == "3")
            {
                Console.ReadLine();
            }
            logger.Info("Program ended");
        }
    }
}
