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
        public SDoctor[] DoctorList = new SDoctor[6];
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
            Console.WriteLine($"{"Name:",-17} {DoctorList[index].FirstName + " " + DoctorList[index].LastName}");
            Console.WriteLine($"{"Code:",-17} {DoctorList[index].Code}");
            Console.WriteLine($"{"Expertise:",-17} {DoctorList[index].Expertise}");
            Console.WriteLine($"{"Work Experience:",-17} {DoctorList[index].Record}years");
            Console.WriteLine("------------------------------------------------");
        }
        // searching for patient
        public int SearchPatient(string id, SPatient[] patientlist)
        {
            int i;
            for (i = 0; i < patientlist.Length; i++)
            {
                if (patientlist[i].ID == id)
                {
                    Console.WriteLine("Patient Found Successfully.");
                    return i;
                }
            }
            Message.PatientNotFound(id);
            return -1;
        }
        public int Visit(string id, SPatient[] patientlist)
        {
            int i;
            for (i = 0; i < patientlist.Length; i++)
            {
                if (patientlist[i].ID == id)
                {
                    Message.PatientVisit(patientlist[i].FirstName, patientlist[i].LastName);
					Message.PatientPrescription();
                    return i;
                }
            }
            Message.PatientNotFound(id);
            return -1;
        }
        public void Prescription(string prescription, SPatient[] patientlist, int index)
		{
            patientlist[index].Prescription = prescription;
			Message.PrescriptionGiven();
		}
        public void Discharge(int index, SPatient[] patientlist)
        {
            for (int i = index; i < patientlist.Length - 1; i++)
            {
                patientlist[i] = patientlist[i + 1];
            }
            Array.Resize(ref patientlist, patientlist.Length - 1);
        }
    }
}

// show dr