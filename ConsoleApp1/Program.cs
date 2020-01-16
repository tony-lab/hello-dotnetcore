using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = null;
            System.Console.WriteLine(obj.ToString());
            
            try{
                Console.WriteLine("try...");
            } finally{
                Console.WriteLine("finally...");
            } 
            try{
                Console.WriteLine("try 2...");
            } finally{
                Console.WriteLine("finally...");
            } 
            Console.WriteLine("Hello Auth0 Vulnerability with Actions!");
        }
    }
}
