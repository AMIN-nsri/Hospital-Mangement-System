using System;
namespace Hospital
{
	public class Nurse
	{
		public Nurse()
		{
		}
        // Method For Adding Nurse
        SNurse[] NurseList = new SNurse[10];
        int z = 0;
        public void AddNurse(string firstname, string lastname, string code)
        {
            if (z < 10)
            {
                NurseList[z].FirstName = firstname;
                NurseList[z].LastName = lastname;
                NurseList[z].Code = code;
                if (z > 1)
                {
                    Message.NewNurse(firstname, lastname, code);
                }
                z++;
            }
            else Message.MaximumNurse();
        }
        // Declaring Default Nurses
        public void DefaultNurse()
        {
            AddNurse("Azita", "Soofian", "6432");
            AddNurse("Parisa", "Nabavi", "6481");
        }

        // ****Treatment Function
        // reading prescription
        public void ReadPrescription(SPatient patientlist)
        {
            if(patientlist.Prescription==null)
                Console.WriteLine("No Prescription Given Yet.");
            else
                Console.WriteLine(patientlist.Prescription);
        }
        // searching for patient
        public int SearchPatient(string id, SPatient[] patientlist)
        {
            int i;
            for (i = 0; i < patientlist.Length ; i++)
            {
                if (patientlist[i].ID == id)
                {
                    if (!patientlist[i].treated)
                    {
                        Message.PatientFound();
                        return i;
                    }
                    else
                    {
                        Message.AlreadyTreated();
                        return i;
                    }
                }
            }
            if (i == patientlist.Length)
            {
                Message.PatientNotFound(id);
                return -1;
            }
            return 0;
        }
        // treatment
        public void Treat(SPatient[] patientlist,int i)
        {
            patientlist[i].treated = true;
            Message.PatientTreated(patientlist[i].FirstName, patientlist[i].LastName);
        }
        // ***Discharge Patient From Hospital
        public void Discharge(string lastname,SPatient[] patientlist, int i)
        {
            Array.Clear(patientlist, i, patientlist.Length);
            Message.PatientDischarge(lastname);
        }
    }
}


// show Nurse
