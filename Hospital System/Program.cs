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

            Admin admin = new Admin();
            Message.Time();
            Message.Topic();
            Message.Loading(5);
            admin.AddPatient("amin", "nasiri", "0277367816", "Covid-10", 12);
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