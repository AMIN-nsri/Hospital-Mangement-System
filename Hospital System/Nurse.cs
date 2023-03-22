using System;
using System.Reflection;

namespace Hospital
{
	public class Nurse
	{
		public Nurse()
		{
		}
        // Method For Adding Nurse
        // Up to *8* new patient could be added
        public SNurse[] NurseList = new SNurse[10];
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
        // Showing Nurses list
        public void ShowNurses()
        {
            for (int i = 0; i < z; i++)
            {
                Console.WriteLine($"{i + 1,-2}. {NurseList[i].FirstName + " " + NurseList[i].LastName,-30}  #Code: {NurseList[i].Code,-15}");
            }
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
                    //if (!patientlist[i].treated)
                    //{
                        Message.PatientFound();
                        return i;
                    //}
                    //else
                    //{
                    //    Message.AlreadyTreated();
                    //    return i;
                    //}
                }
            }
            //if (i == patientlist.Length)
            //{
                Message.PatientNotFound(id);
                return -1;
            //}
            //return 0;
        }
        // treatment
        public void Treat(SPatient patientlist, SNurse nurselist)
        {
            patientlist.treated = true;
            Message.PatientTreated(patientlist.FirstName, patientlist.LastName,nurselist.FirstName,nurselist.LastName);
        }
        // ***Discharge Patient From Hospital
        public void Discharge(string lastname,SPatient[] patientlist, int index)
        {
            for (int i = index; i < patientlist.Length - 1; i++)
            {
                patientlist[i] = patientlist[i + 1];
            }
            Array.Resize(ref patientlist, patientlist.Length - 1);
            //Array.Clear(patientlist, i, patientlist.Length);
            Message.PatientDischarge(lastname);
            // don't forget to x--
        }

    }
}