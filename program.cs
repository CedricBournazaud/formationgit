using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, world!");
        Console.WriteLine("Hello, commit 2");
        Console.ReadLine();
    }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set;  }
    }
}