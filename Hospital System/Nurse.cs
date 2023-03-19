using System;
namespace Hospital
{
	public class Nurse
	{
		public Nurse()
		{
		}
        private string FirstName;
        private string LastName;
        private string Code;
        public void SetData(string firstname, string lastname, string code)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Code = code;
            //Console.WriteLine(FirstName+ "," + LastName+","+Code);
        }

        public void Treat()
        {

        }
    }
}

