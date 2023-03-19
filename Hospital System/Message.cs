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
        // Showing System Time
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
        // *Welcome admin
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
        // **New Patient Added
        public static void NewPatient(string firstname, string lastname, string id)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"New Patient {firstname} {lastname} With ID:'{id}' Added Successfully.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        // ****Search using ID or by Menu?
        public static void Select()
        {
            Console.WriteLine("Do You Want To Choose Using Menu or Search by ID?");
        }
        // ****Patient Found
        public static void PatientFound()
        {
            Console.WriteLine("Patient Found Successfully.");
            Console.WriteLine("Want To Treat or Read Docter's Prescription?");
        }
        // *****Successfull Treatment
        public static void PatientTreated(string firstname, string lastname)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Patient {firstname} {lastname} Treated Successfully.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        // *****Patient Not Found
        public static void PatientNotFound(string id)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Patient With ID: '{id}' Not Found!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        // *****Patient treated before -- Want to discharge?
        public static void AlreadyTreated()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Patient You Choose Is Already Treated Before.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Want To Discharge The Patient?");
        }
        // ******Doctor Approval is required to discharge
        public static void DoctorApproval()
        {
            Console.WriteLine("Doctor Approval Is Required To Discharge.");
            Console.WriteLine("Please Choose Doctor From Below:");
        }
        public static void PatientDischarge(string lastname)
        {
            Console.WriteLine($"Patient Discharged with Dr. {lastname} Permision.");
        }
        // *****Successfull Visit
        public static void PatientVisit(string firstname, string lastname)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Patient {firstname} {lastname} Visited Successfully.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        // *****Enter Your Prescription
        public static void PatientPrescription()
        {
            Console.WriteLine("Enter Your Prescription:");
        }
        // ******Prescription Given Successfully
        public static void PrescriptionGiven()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Prescription Given Successfully.");
        }
    }
}
