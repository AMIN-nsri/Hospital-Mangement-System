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
	public class Admin
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


	}
}

