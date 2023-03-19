using System;
namespace Hospital
{
	public class Doctor
	{
		public Doctor()
		{
		}
		// ***** Declaring Doctors
		private string FirstName; 
		private string LastName; 
		private string Code;
		private string Expertise; 
		private int Record; 
		public void SetData(string firstname,string lastname, string code, string expertise, int record)
		{
			this.FirstName = firstname;
			this.LastName = lastname;
			this.Code = code;
			this.Expertise = expertise;
			this.Record = record;
			//Console.WriteLine(FirstName+","+LastName+","+Expertise+","+Record+","+Code);
		}
        public void Visit()
        {

        }
        public void Prescription()
		{

		}
    }
}

