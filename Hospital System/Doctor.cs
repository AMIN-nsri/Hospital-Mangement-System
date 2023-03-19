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
		}
        public void Visit(string id, SPatient[] patientlist)
        {
            int i;
            for (i = 0; i < patientlist.Length; i++)
            {
                if (patientlist[i].ID == id)
                {
                    Message.PatientVisit(patientlist[i].FirstName, patientlist[i].LastName);
					Message.PatientPrescription();
                    break;
                }
            }
            if (i == patientlist.Length) Message.PatientNotFound(id);
        }
        public void Prescription(string prescription, SPatient patientlist)
		{
			patientlist.Prescription = prescription;
			Message.PrescriptionGiven();
		}
    }
}

