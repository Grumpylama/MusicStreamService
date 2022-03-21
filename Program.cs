using System;
using System.IO;

namespace MusicStreamService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            
            string ProjectPath = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).Parent.FullName;
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
