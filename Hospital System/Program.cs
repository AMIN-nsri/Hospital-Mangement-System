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
            // *****don't forget to x-- when using discharge method*****

            Admin admin = new Admin();
            Doctor doctor = new Doctor();
            doctor.DefaultDoctor();
            Nurse nurse = new Nurse();
            nurse.DefaultNurse();

            Message.Time();
            Message.Topic();
          
            Message.Loading(2);
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