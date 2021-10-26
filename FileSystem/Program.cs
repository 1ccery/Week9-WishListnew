using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples";
            string userDirectory = "Whishlist";

            string rootDirectoryFullPath = $@"{rootDirectory}\{userDirectory}";
            Console.WriteLine(newDirectoryFullPath);

            Directory.CreateDirectory(newDirectoryFullPath);
            //Directory.CreateDirectory();
        }
    }
}
