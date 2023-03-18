using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace Hospital
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Admin admin = new Admin();
            //admin.AddAdmin("aminoo", 1234589, 0);
            DefaultData.Nurses();
            Message.Topic();
            Message.Loading(5);
            String input = Console.ReadLine();
            while (input!="e")
            {
                Message.Welcome(input);
                Console.WriteLine("Hi");
                input = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}