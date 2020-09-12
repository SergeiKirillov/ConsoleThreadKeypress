using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleThreadKeypress
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pause = false;
            bool clean = false;

            while (true)
            {
                Console.WriteLine("Тик-Так");
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.P) pause = true;
                    else if (keyInfo.Key == ConsoleKey.R) pause = false;
                    else if (keyInfo.Key == ConsoleKey.C) clean = true;
                    else break;

                    if (pause)
                        Console.WriteLine("Paused.");
                    else
                        Console.WriteLine("Doing stuff.");

                    if (clean)
                    {
                        Console.Clear();
                    }

                    System.Threading.Thread.Sleep(1000);
                    
                }

                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
