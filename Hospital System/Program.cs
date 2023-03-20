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
            admin.AddPatient("sasha", "nasiri", "3343535", "Covid-10", 12);
            admin.AddPatient("maryam", "taebi", "2445564", "Covid-10", 12);
            admin.AddPatient("ahmad", "emrani", "1244432", "Covid-10", 12);
            admin.AddPatient("sina", "majidi", "65985", "Covid-10", 12);
            admin.AddPatient("ali", "bakhshi", "9473788", "Covid-10", 12);
            Message.Loading(2);
            admin.ShowPatients();
            //admin.AddAdmin("alia1", 123456);
            //admin.AddAdmin("alia2", 123456);
            //admin.AddAdmin("alia3", 123456);
            //admin.AddAdmin("alia4", 123456);
            //admin.AddAdmin("alia5", 123456);
            //admin.AddAdmin("alia6", 123456);
            //admin.show(0);
            //admin.show(1);
            //admin.show(2);
            //admin.show(3);
            //admin.show(4);
            Doctor doctor = new Doctor();
            doctor.DefaultDoctor();
            Nurse nurse = new Nurse();
            // *****don't forget to use defualt nurse and doctor*****
            // *****don't forget to x-- when using discharge method*****
            nurse.DefaultNurse();
            nurse.AddNurse("As","ghar","123");
            //nurse.show(0);
            //nurse.show(1);
            //nurse.show(2);
            nurse.ShowNurses();
            doctor.ShowDoctors();
            admin.PatientFullInfo(2);
            //nurse.SearchPatient("0277367816", admin.PatientList);
            //Message.Loading(3);
            //nurse.SearchPatient("027767816", admin.PatientList);

            //Console.WriteLine(admin.PatientList[0].FirstName);

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