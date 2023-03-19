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
        }
        // ****Treatment Function
        public void Treat(string id, SPatient[] patientlist)
        {
            int i;
            for (i = 0; i < patientlist.Length ; i++)
            {
                if (patientlist[i].ID == id)
                {
                    patientlist[i].treated = true;
                    Message.PatientTreated(patientlist[i].FirstName, patientlist[i].LastName);
                    break;
                }
            }
            if (i == patientlist.Length) Message.PatientNotFound(id);
        }
    }
}

