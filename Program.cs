// Program.cs
// created by druffko
// Copyright 2024 druffko

using System;
namespace email_extractor
{
    public class Program
    {
        public static void Main()
        {
            string url = "";
            //Get URL to be scanned
            Console.WriteLine("Please enter the URL you want to have scanned:");
            url = Console.ReadLine();

            Console.WriteLine("Would you like to save the extracted emails to a file? (Y/N)");
            string decision = Console.ReadLine();
            if (decision.Equals("Y") || decision.Equals("y"))
            {
                Extractor.safeToFile = true;
                Console.WriteLine("Will do!");
            }
            else
            {
                Console.WriteLine("Alright, wont safe the output.");
            }

            Console.WriteLine("Scanning " + url + " for email-addresses...");
            Extractor.GrabCode(url);
        }

    }
}

