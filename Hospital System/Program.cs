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
            admin.AddPatient("amin", "nasiri", "0277367816", "Covid-10", 12);
            Message.Loading(5);
            Nurse nurse = new Nurse();
            nurse.Treat("0277367816", admin.PatientList);
            Console.WriteLine(admin.PatientList[0].FirstName);

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