﻿using System;
using System.IO;
namespace FileCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\wishlist";
            Console.WriteLine("Enter file name");
            string fileName = Console.ReadLine();
            string fullfilePath = $@"{rootDirectory}\{fileName}.pdf";
            bool directoryExists = Directory.Exists(rootDirectory);
            bool fileExists = File.Exists(fullfilePath);
            if (directoryExists && fileExists)
            {
                Console.WriteLine($"File {fileName} already exists in {rootDirectory}");
            }
            else if(!directoryExists)
            {
                Console.WriteLine($"wishlist directory does not exist");
                Directory.CreateDirectory(rootDirectory);

                File.Create(fullfilePath);
                Console.WriteLine($"Wishlist directory and {fileName} has been created");
            }
            else
            {
                File.Create(fullfilePath);
                Console.WriteLine($"File {fileName}.txt has been created");
            }

        }
    }
}
