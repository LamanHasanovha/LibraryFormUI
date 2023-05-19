using System;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var manager = new BookGenreManager(new HttpClient(), @"https://localhost:7172/", new UserForLoginModel { Email = "asimelizade01@gmail.com", Password="Asim123"});

            //var data1 = manager.GetAll();


            //int a = 9;

            while (true)
            {
                var num = new Random().Next(1, 3);
                System.Console.WriteLine(num);
                System.Console.ReadLine();
            }

        }
    }
}
