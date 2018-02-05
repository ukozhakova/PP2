using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Far_Manager 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the disk.");
            Console.WriteLine("Enter C, if you want to go to Disk C");
            Console.WriteLine("Enter D, if you want to go to Disk D");
            
           // Environment.GetLogicalDrives();
           
            Console.SetWindowSize(90, 40);
        
            FAR farC = new FAR(@"C:\");
            FAR farD = new FAR(@"D:\");


            bool quit = false;
            ConsoleKeyInfo mykey = Console.ReadKey();
            while (!quit)
            {   
          
                if (mykey.Key == ConsoleKey.C)
                {
                    farC.Draw();
                    ConsoleKeyInfo mykey1 = Console.ReadKey();
                    switch (mykey1.Key)
                    {
                        case ConsoleKey.Escape:
                            quit = true;
                            break;
                        case ConsoleKey.UpArrow:
                        case ConsoleKey.DownArrow:
                        case ConsoleKey.Backspace:
                        case ConsoleKey.Enter:
                            farC.Process(mykey1);
                            break;
                        default:
                            break;
                    }
              } else if (mykey.Key==ConsoleKey.D)
                {
                    farD.Draw();
                    ConsoleKeyInfo mykey1 = Console.ReadKey();
                    switch (mykey1.Key)
                    {
                        case ConsoleKey.Escape:
                            quit = true;
                            break;
                        case ConsoleKey.UpArrow:
                        case ConsoleKey.DownArrow:
                        case ConsoleKey.Backspace:
                        case ConsoleKey.Enter:
                            farD.Process(mykey1);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}