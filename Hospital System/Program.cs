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
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Hi");
            //Thread.Sleep(5000);
            //Console.Clear();
            Message.Topic();
            //Loading x = new Loading(10000);
            Message.Loading(5);
            String input = Console.ReadLine();
            Message.Welcome(input);
            while (input!="e")
            {
                Console.WriteLine("Hi");
                input = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}