using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab3farmanager
{
    class Program
    {
        static void ShowDirectoryInfo(DirectoryInfo directory, int cursor)
        {
            Console.SetWindowSize(20, 20);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            FileSystemInfo[] file = directory.GetFileSystemInfos();
            for (int i = 0; i < file.Length; i++)
            {
                FileSystemInfo files = file[i];
                if (i == cursor)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }
                else Console.BackgroundColor = ConsoleColor.Blue;
                if (files.GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(files.Name);
                if (file[i].Name.Length > 20)
                {
                    file[i].Name.Length = file[i].Name.Length - 20;
                    Console.WriteLine("...");
                }
                for (int j = 0; j <= 20 - file[i].Name.Length; ++j)
                {
                    Console.Write(' ');
                }
                Console.WriteLine('|');
            }
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 40);
            Console.CursorVisible = false;
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Мадина\Desktop");
            int cursor = 0;
            int n = directory.GetFileSystemInfos().Length;
            ShowDirectoryInfo(directory, cursor);
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    cursor--;
                    if (cursor == -1)
                    {
                        cursor = n - 1;
                    }
                }
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    cursor++;
                    if (cursor == n)
                    {
                        cursor = 0;
                    }
                }
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (directory.GetFileSystemInfos()[cursor].GetType() == typeof(DirectoryInfo))
                    {
                        directory = new DirectoryInfo(directory.GetFileSystemInfos()[cursor].FullName);
                        cursor = 0;
                        n = directory.GetFileSystemInfos().Length;
                    }
                    else
                    {
                        StreamReader sr = new StreamReader(directory.GetFileSystemInfos()[cursor].FullName);
                        string s = sr.ReadToEnd();
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(s);
                        Console.ReadKey();
                    }
                }
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    if (directory.Parent != null)
                    {
                        directory = directory.Parent;
                        cursor = 0;
                        n = directory.GetFileSystemInfos().Length;
                    }
                    else break;
                }
                ShowDirectoryInfo(directory, cursor);
            }
        }
    }
}