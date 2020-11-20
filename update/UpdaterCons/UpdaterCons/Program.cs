using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UpdaterCons
{
                                                // cracked.to/MrB00t

                                                // Subscribe to my youtube channel https://www.youtube.com/channel/UCT9GsLbadapvAF8DowXJi4w
                                                // Made by MrB00t

    class Program
    {
        static void Main(string[] args)
        {
            string Currentversion = "2.0"; 
            string NewVersion = new WebClient().DownloadString("https://pastebin.com/raw/rbAUM63F");


            Console.Title = "Updater made by MrB00t#0001 | Current version: " + Currentversion;

            WebClient webClient = new WebClient();


            if (!webClient.DownloadString("https://pastebin.com/raw/rbAUM63F").Contains(Currentversion)) 
            {
                Console.WriteLine("New available version: " + NewVersion + " ! Would you like to update?\n");
                Console.WriteLine("*] Yes");
                Console.WriteLine("*] No");

                string answer = Console.ReadLine();

                if (answer == "Yes")
                {
                    Process.Start("https://www.youtube.com/channel/UCT9GsLbadapvAF8DowXJi4w");
                }

            }
            else
            {

                Console.WriteLine("Last version already.");
                Thread.Sleep(1000);
                Console.Clear();

                Console.WriteLine("Loading.");
                Thread.Sleep(500);
                Console.WriteLine("Loading..");
                Thread.Sleep(600);
                Console.WriteLine("Loading...");
                Thread.Sleep(2000);
                Console.Clear();

            }
        }
    }
}
