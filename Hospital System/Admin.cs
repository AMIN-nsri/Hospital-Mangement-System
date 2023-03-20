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
	public class Admin:Program
	{
		public Admin()
		{
		}

        // *****Declaring Main Admin
        private string MainUsername= "amin";
		private int MainPassword= 12345;

		// *****Method For adding new admin by user
		// Up to *5* new admin could be added
        private string[] Username =new string[5];
		private int[] Password= new int[5];
		int y = 0;
        public void AddAdmin(string username, int password)
		{
			if (y < 5)
			{
				this.Username[y] = username;
				this.Password[y] = password;
				Message.NewAdmin();
				y++;
			}
			else Message.MaximumAdmin();
		}
        // *****Method For adding new patient
        // Up to *50* new patient could be added
        public SPatient[] PatientList = new SPatient[50];
		public int x = 0;
        public void AddPatient(string firstname,string lastname,string id,string sickness,int roomnumber )
		{
			if (x < 50)
			{
				PatientList[x].FirstName = firstname;
				PatientList[x].LastName = lastname;
				PatientList[x].ID = id;
				PatientList[x].Sickness = sickness;
				PatientList[x].RoomNumber = roomnumber;
				PatientList[x].treated = false;
				Message.NewPatient(PatientList[x].FirstName, PatientList[x].LastName, PatientList[x].ID);
				x++;
			}
			else Message.MaximumPatient();
		}
		// Show Patient List
		public void ShowPatients()
		{
			for (int i=0; i< x; i++)
			{
				Console.WriteLine($"{i+1,-2}. {PatientList[i].FirstName+" "+PatientList[i].LastName,-30}  #ID: {PatientList[i].ID,-15}");
			}
		}
		// Show Patient Full Information
        public void PatientFullInfo(int index)
        {
			Console.WriteLine($"{"Name:",-15} {PatientList[index].FirstName + " " + PatientList[index].LastName}");
			Console.WriteLine($"{"ID:",-15} {PatientList[index].ID}");
            Console.WriteLine($"{"Sickness:",-15} {PatientList[index].Sickness}");
            Console.WriteLine($"{"Room Number:",-15} {PatientList[index].RoomNumber}");
        }

    }
}
