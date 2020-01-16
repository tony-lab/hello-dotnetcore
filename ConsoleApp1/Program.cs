using System;

namespace ConsoleApp1
{
    public class Person
    {
        public string Fullname { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person tony = null;
            System.Console.WriteLine(tony.ToString());

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
