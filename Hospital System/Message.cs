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
            Console.Write("-------------Hospital Management System-------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("     back[b]");
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
        // Welcome Dr
        public static void WelcomeDr(string lastname)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Welcome Dr. {lastname}!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        // Welcome Nurse
        public static void WelcomeNr(string firstname,string lastname)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Welcome Dear {firstname} {lastname}!");
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
            //Message.Loading(1);
            //Wait.ClearLine();
        }
        // Maximun Patient Loaded
        public static void MaximumPatient()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sorry!! Maximum Patient Added!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please Discharge Some Patient To Add More.");
        }
        // ****Search using ID or by Menu?
        public static void Select()
        {
            Console.WriteLine("Do You Want To Choose Using List or Search by ID?");
            Console.WriteLine("Search by ID(S)");
            Console.WriteLine("Show List(L)");
            Console.WriteLine("Back(b)");
        }
        // ****Patient Found
        public static void PatientFound()
        {
            Console.WriteLine("Patient Found Successfully.");
            //Console.WriteLine("Want To Treat or Read Docter's Prescription?");
        }
        // *****Successfull Treatment
        public static void PatientTreated(string firstname, string lastname,string Nfirstname, string Nlastname)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Patient {firstname} {lastname} Treated by {Nfirstname} {Nlastname} Successfully.");
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
            Console.WriteLine("Want To Discharge The Patient?([Y]es/[N]o)");
        }
        // ******Doctor Approval is required to discharge
        public static void DoctorApproval()
        {
            Console.WriteLine("Doctor Approval Is Required To Discharge.");
            Console.WriteLine("Please Choose Doctor From Below(enter index):");
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
            Console.ForegroundColor = ConsoleColor.White;
        }
        // New Admin Added Successfully
        public static void NewAdmin()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"New Admin Added Successfully.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        // Maximun Admin Loaded
        public static void MaximumAdmin()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR!! Maximum Admin Loaded!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        // Nurse Added Successfully
        public static void NewNurse(string firstname, string lastname, string code)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"New Nurse {firstname} {lastname} With Code:'{code}' Added Successfully.");
            Console.ForegroundColor = ConsoleColor.White;

        }
        // Maximun Nurse Loaded
        public static void MaximumNurse()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR!! Maximum Nurse Loaded!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        // Doctor Added Successfully
        public static void NewDoctor(string lastname, string code)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Dr. {lastname} With Code:'{code}' Added Successfully.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        // Maximun Doctor Loaded
        public static void MaximumDoctor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR!! Maximum Doctor Loaded!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Program()
        {
            Console.Clear();
            Message.Time();
            Message.Topic();
            Message.Loading(1);
        }
        public static void LogedIn()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Logged in successfully.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Wrong()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong Username or Password!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please try again or Enter 'b' to turn back.");
        }


        public static void MainMenu()
        {
            Console.WriteLine("Choose one to start(type key letter):");
            Console.WriteLine("Admin(a)");
            Console.WriteLine("Doctor(d)");
            Console.WriteLine("Nurse(n)");
            Console.WriteLine("Exit(e)");
        }
        public static void AdminMenu()
        {
            Console.WriteLine("Choose one (type key letter):");
            Console.WriteLine("Add New Admin(A)");
            Console.WriteLine("Add Patient(P)");
            Console.WriteLine("Show Patients List(PL)");
            Console.WriteLine("Add Nurse List(N)");
            Console.WriteLine("Show Nurses(NL)");
            Console.WriteLine("Add Doctor(D)");
            Console.WriteLine("Show Doctors List(DL)");
            Console.WriteLine("Back(b)");
            Console.WriteLine("Exit(e)");

        }
        public static void DoctorMenu()
        {
            Console.WriteLine("Choose one (type key letter):");
            Console.WriteLine("Visit(V)");
            Console.WriteLine("Give Prescription(P)");
            Console.WriteLine("Discharge Patient(D)");
            Console.WriteLine("Back(b)");
            Console.WriteLine("Exit(e)");
        }
        public static void NurseMenu()
        {
            Console.WriteLine("Choose one (type key letter):");
            Console.WriteLine("Treat(T)");
            Console.WriteLine("Read Prescription(P)");
            Console.WriteLine("Back(b)");
            Console.WriteLine("Exit(e)");
        }
        public static void Default(int pausetime)
        {
            Message.Program();
            Console.WriteLine("Please Enter Valid Value!");
            Wait.Dot("", pausetime);
        }

    }
}
