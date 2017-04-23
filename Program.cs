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
            string Correct = "BREAK";
            while (Console.ReadLine != Correct(true))
            
            {

                string TheirName;
                Console.WriteLine("What is your name?");
                TheirName = Console.ReadLine();
                Console.WriteLine("Hello " + TheirName);

                Console.ReadKey();
                if (TheirName != Correct)
                {
                
                }
                
            }
        }
        
    }
}
