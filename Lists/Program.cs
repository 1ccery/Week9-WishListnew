using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mywishes = new List<string>();
            mywishes.Add("Ls swap for my new car");
            mywishes.Add("New Car");
            mywishes.Add("Laptop");
            mywishes.Add("Box of mask");

            //Console.WriteLine($"There are {mywishes.Count} items on your wishlist");
           // Console.WriteLine($"{mywishes[0]}");
           // Console.WriteLine($"{mywishes[mywishes.Count - 1]}");
           foreach(string wish in mywishes)
           {
                Console.WriteLine($"item on your wishlist: {wish}");
           }

            Console.WriteLine("enter a wish");
            string userswish = Console.ReadLine();

            mywishes.Add(userswish)

            foreach (string wish in mywishes)
            {
                Console.WriteLine($"your wish has been added to the list: {wish}");

            }


        }
    }
}
