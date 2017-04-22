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
        Start:
            string TheirName;
            string Correct = "BREAK";
            Console.WriteLine("What is your name?");
            TheirName = Console.ReadLine();
            Console.WriteLine("Hello " + TheirName);
            
            Console.ReadKey();
            if (TheirName != Correct) { goto Start; }
            Console.WriteLine(TheirName);
        }
        
    }
}
