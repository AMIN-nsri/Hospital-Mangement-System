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
			Console.WriteLine("-------------Hospital Management System-------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Time()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            DateTime dt = DateTime.Now;
            PersianCalendar pr = new PersianCalendar();
            int year = pr.GetYear(dt);
            int month = pr.GetMonth(dt);
            int day = pr.GetDayOfMonth(dt);
            Console.WriteLine($"{year}/{month}/{day}                                   {dt.ToShortTimeString()}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        // Welcome admin
        public static void Welcome(string admin)
		{
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Welcome Dear {admin}!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        // Loading Please Wait
        public static void Loading(int pausetime)
        {
            Wait.Dot("Loading Please Wait", pausetime);
        }
        // New Patient Added
        public static void NewPatient(string firstname, string lastname, string id)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"New Patient {firstname} {lastname} with ID:'{id}' Added Successfully.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

