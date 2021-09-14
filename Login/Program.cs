using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();

            if (username != "swaggin1" || password != "applejack")
            {
                Console.WriteLine("welcome back, sir ;)");
            }
            else
            {
                Console.WriteLine("uh oh seems like yer username or password is wrong :(");
            }
        }
    }
}
