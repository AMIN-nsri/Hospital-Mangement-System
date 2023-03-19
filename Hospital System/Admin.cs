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
        public void AddAdmin(string username, int password, int index)
		{
			this.Username[index] = username;
			this.Password[index] = password;
		}

		// *****Method For adding new patient
        public SPatient[] P1 = new SPatient[20];
        public void AddPatient(string firstname,string lastname,string id,string sickness,int roomnumber, int x=0 )
		{
			P1[x].FirstName = firstname;
			P1[x].LastName = lastname;
			P1[x].ID = id;
			P1[x].Sickness = sickness;
			P1[x].RoomNumber = roomnumber;
			Message.NewPatient(P1[x].FirstName, P1[x].LastName, P1[x].ID);
			x++;
		}

    }
}

