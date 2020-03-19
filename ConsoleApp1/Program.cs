using System;

namespace ConsoleApp1
{
    class Program
    {
        public class Person
        {
            public string Fullname { get; set; }
        }
        
        static void Main(string[] args)
        {
            Person tony = null;
            System.Console.WriteLine(tony.ToString());

            // fixing bug 12345
            // commit without GPG signing, even administrator
            // from git tower
            Console.WriteLine("Hello Auth0 Vulnerability with Actions!");
        }
    }
}