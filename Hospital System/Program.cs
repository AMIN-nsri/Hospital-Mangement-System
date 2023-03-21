using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;
using System.Text;

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
            Message.MainMenu();
            
            String input = Console.ReadLine();
            while (input != "e")
            {
                switch (input)
                {
                    //** ADMIN MENU
                    case "a":
                        //Login check
                        Message.Program();
                        Console.WriteLine("Enter your Username and Password below");
                        Console.Write("User Name: ");
                        input = Console.ReadLine();
                        string username = input;
                        Console.Write("Password: ");
                        input = GetPassword(); 
                        int password = int.Parse(input);
                        while (!admin.LoginCheck(username, password))
                        {
                            Message.Program();
                            Message.Wrong();
                            Console.WriteLine("Enter your Username and Password below");
                            Console.Write("User Name: ");
                            input = Console.ReadLine();
                            if (input == "b")
                            {
                                Wait.ClearLine();
                                Wait.ClearLine();
                                Wait.ClearLine();
                                Wait.ClearLine();
                                break;
                            }
                            username = input;
                            Console.Write("Password: ");
                            input = GetPassword(); 
                            if (input == "b")
                            {
                                Wait.ClearLine();
                                Wait.ClearLine();
                                Wait.ClearLine();
                                Wait.ClearLine();
                                Wait.ClearLine();
                                break;
                            }
                            password = int.Parse(input);
                        }
                        if (admin.LoginCheck(username, password))
                        {
                            Message.Program();
                            Message.LogedIn();
                            bool adminmenu=true;
                            while (adminmenu)
                            {
                                Message.Loading(2);
                                Message.Program();
                                Message.AdminMenu();
                                string input2;
                                input2 = Console.ReadLine();
                                Message.Program();
                                switch (input2)
                                {
                                    // Add Patient
                                    case "P":
                                        Console.WriteLine("Enter follwing information.");
                                        Console.Write("First Name: ");
                                        input = Console.ReadLine();
                                        string firstname = input;
                                        Console.Write("Last Name: ");
                                        input = Console.ReadLine();
                                        string lastname = input;
                                        Console.Write("ID: ");
                                        input = Console.ReadLine();
                                        string id = input;
                                        Console.Write("Sickness: ");
                                        input = Console.ReadLine();
                                        string sickness = input;
                                        Console.Write("Room Number: ");
                                        input = Console.ReadLine();
                                        int roomnumber = int.Parse(input);
                                        admin.AddPatient(firstname, lastname, id, sickness, roomnumber);
                                        break;
                                    // Show Patient Compact List
                                    case "PL":
                                        bool showpatient = true;
                                        while (showpatient)
                                        {
                                            admin.ShowPatients();
                                            Console.WriteLine("To show complete information enter the patient's index or enter 'b' to turn back.");
                                            string input3 = Console.ReadLine();
                                            // Show Patient Full Info
                                            if (input3 == "b")
                                                showpatient = false;
                                            else
                                            {
                                                int index = int.Parse(input3);
                                                admin.PatientFullInfo(index - 1);
                                            }
                                        }
                                        break;
                                    // Add Nurse
                                    case "N":
                                        Console.WriteLine("Enter follwing information.");
                                        Console.Write("First Name: ");
                                        input = Console.ReadLine();
                                        string Nfirstname = input;
                                        Console.Write("Last Name: ");
                                        input = Console.ReadLine();
                                        string Nlastname = input;
                                        Console.Write("Code: ");
                                        input = Console.ReadLine();
                                        string Ncode = input;
                                        nurse.AddNurse(Nfirstname, Nlastname, Ncode);
                                        break;
                                    // Show Nurse List
                                    case "NL":
                                        bool shownurse = true;
                                        while (shownurse)
                                        {
                                            Message.Program();
                                            nurse.ShowNurses();
                                            Console.WriteLine("Enter 'b' to turn back.");
                                            string input3 = Console.ReadLine();
                                            if (input3 == "b")
                                                shownurse = false;
                                        }
                                        break;
                                    // Add Doctor
                                    case "D":
                                        Console.WriteLine("Enter follwing information.");
                                        Console.Write("First Name: ");
                                        input = Console.ReadLine();
                                        string Dfirstname = input;
                                        Console.Write("Last Name: ");
                                        input = Console.ReadLine();
                                        string Dlastname = input;
                                        Console.Write("Code: ");
                                        input = Console.ReadLine();
                                        string Dcode = input;
                                        Console.Write("Expertise: ");
                                        input = Console.ReadLine();
                                        string Dexpertise = input;
                                        Console.Write("Work Experience(year): ");
                                        input = Console.ReadLine();
                                        int Drecord = int.Parse(input);
                                        doctor.AddDoctor(Dfirstname,Dlastname,Dcode,Dexpertise,Drecord);
                                        break;
                                    // Show Doctor Compact List
                                    case "DL":
                                        bool showdoctor = true;
                                        while(showdoctor)
                                        {
                                            //Message.Program();
                                            doctor.ShowDoctors();
                                            Console.WriteLine("To show complete information enter the doctor's index or enter 'b' to turn back.");
                                            string input3 = Console.ReadLine();
                                            // Show Doctor Full Info
                                            if (input3 == "b")
                                                showdoctor = false;
                                            else
                                            {
                                                int index = int.Parse(input3);
                                                doctor.DoctorFullInfo(index - 1);
                                            }
                                        }
                                        break;
                                    // Add Admin
                                    case "A":
                                        Console.Write("Enter Username: ");
                                        string newusername = Console.ReadLine();
                                        
                                        bool confirm = false;
                                        while (!confirm)
                                        {
                                            Console.Write("Enter Password: ");
                                            int newpassword = int.Parse(Console.ReadLine());
                                            Console.Write("Confirm Password: ");
                                            int conpassword = int.Parse(Console.ReadLine());
                                            if (newpassword == conpassword)
                                            {
                                                admin.AddAdmin(newusername, newpassword);
                                                confirm = true;
                                            }
                                            else
                                            {
                                                Wait.ClearLine();
                                                Wait.ClearLine();
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Password Doesn't Match!");
                                                Console.ForegroundColor = ConsoleColor.White;
                                            }

                                        }
                                        //admin.AddAdmin(newusername, newpassword);
                                        break;
                                    // Turn Back
                                    case "b":
                                        adminmenu = false;
                                        break;
                                    // Exit
                                    case "e":
                                        System.Environment.Exit(0);
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        break;

                    // **DOCTOR MENU
                    case "d":

                        break;

                    // **NURSE MENU
                    case "n":

                        break;
                    default:
                        break;
                }
                //Message.Program();
                Message.MainMenu();
                input = Console.ReadLine();
            }
            Console.WriteLine("hi");

        }
        private static string GetPassword()
        {
            StringBuilder input = new StringBuilder();
            while (true)
            {
                int x = Console.CursorLeft;
                int y = Console.CursorTop;
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }
                if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input.Remove(input.Length - 1, 1);
                    Console.SetCursorPosition(x - 1, y);
                    Console.Write(" ");
                    Console.SetCursorPosition(x - 1, y);
                }
                else if (key.Key != ConsoleKey.Backspace)
                {
                    input.Append(key.KeyChar);
                    Console.Write("*");
                }
            }
            return input.ToString();
        }
    }
}