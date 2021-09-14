
using System;

namespace BooleanLogicOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus;
            //programm küsib kasutajal sisestada parool;
            //programm kontrollib, kas mõlemad, nii kasutajatunnus
            //kui ka parool on õiged;
            //kui mõlemad, kasutajatunnus ja parool on õiged
            //programm kuvab konsoolis "tere tulemast!"
            //kasutajatunnus või parool on vale, siis
            //programm kuvab sisselogimine ebaõnnestus. Proovi uuesti."
            //kt: admin, pr:admin1234

            Console.WriteLine("Enter your username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();

            if (username == "swaggin1" && password == "applejack")
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
