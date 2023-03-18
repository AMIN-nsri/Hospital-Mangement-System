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
	public class Message
	{
		public Message()
		{
		}

		// Showing Program Topic
		public static void Topic()
		{
            Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("--------Hospital Management System--------");
            Console.ForegroundColor = ConsoleColor.White;
        }

		// Welcome admin
		public static void Welcome(string admin)
		{
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Welcome Dear {admin}!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        // Loading Please Wait
        public static void Loading(int pausetime)
        {
            Wait.Dot("Loading Please Wait", pausetime);
        }

    }
}

