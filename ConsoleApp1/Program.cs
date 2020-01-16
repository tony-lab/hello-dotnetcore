using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var flag = true;
            if (flag) {
                System.Console.WriteLine("flag is true");
            }
            else{
                System.Console.WriteLine("flag is false.");
            }
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
