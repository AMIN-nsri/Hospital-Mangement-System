using System;
namespace Hospital
{
	public class Doctor
	{
		public Doctor()
		{
		}
        // Method For Adding Doctor
        // Up to *4* new patient could be added
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
        public void DefaultDoctor()
        {
            AddDoctor("Mohammad", "Amiri", "8962", "Cardiologist", 7);
            AddDoctor("Amir", "Mohammadi", "8932", "Neurologist", 3);
        }
        // Show Doctors List
        public void ShowDoctors()
        {
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine($"{i + 1,-2}. {DoctorList[i].FirstName + " " + DoctorList[i].LastName,-30}  Expertise: {DoctorList[i].Expertise,-15}");
            }
        }
        // Doctor Full Info
        public void DoctorFullInfo(int index)
        {
            Console.WriteLine($"{"Name:",-15} {DoctorList[index].FirstName + " " + DoctorList[index].LastName}");
            Console.WriteLine($"{"Code:",-15} {DoctorList[index].Code}");
            Console.WriteLine($"{"Expertise:",-15} {DoctorList[index].Expertise}");
            Console.WriteLine($"{"Room Number:",-15} {DoctorList[index].Record}");
            Console.WriteLine("------------------------------------------------");
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