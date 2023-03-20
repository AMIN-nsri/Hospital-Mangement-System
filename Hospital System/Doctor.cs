using System;
namespace Hospital
{
	public class Doctor
	{
		public Doctor()
		{
		}
        // Method For Adding Doctor
        SDoctor[] DoctorList = new SDoctor[6];
		int t = 0;
		public void AddDoctor(string firstname,string lastname, string code, string expertise, int record)
		{
			if (t < 6)
			{
				DoctorList[t].FirstName = firstname;
				DoctorList[t].LastName = lastname;
				DoctorList[t].Code = code;
				DoctorList[t].Expertise = expertise;
				DoctorList[t].Record = record;
				if (t > 1)
				{
					Message.NewDoctor(lastname, code);
				}
				t++;
			}
			else Message.MaximumNurse();
		}
        // Declaring Default Doctors
        public void DefaultNurse()
        {
            AddDoctor("Mohammad", "Amiri", "8962", "Cardiologist", 7);
            AddDoctor("Amir", "Mohammadi", "8932", "Neurologist", 3);
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

// show dr