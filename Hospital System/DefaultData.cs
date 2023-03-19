using System;
namespace Hospital
{
	public class DefaultData
	{
		public DefaultData()
		{
		}
		public static void Docters()
		{
            Doctor[] docter = new Doctor[2];
            Doctor d1 = new Doctor();
			d1.SetData("Mohammad", "Amiri", "8962", "Cardiologist", 7);
			docter[0] = d1;
            d1.SetData("Amir", "Mohammadi", "8932", "Neurologist", 3);
			docter[1] = d1;
        }
		public static void Nurses()
		{
			Nurse[] nurse = new Nurse[2];
			Nurse n1 = new Nurse();
			n1.SetData("Azita","Soofian","6432");
			nurse[0] = n1;
			n1.SetData("Parisa","Nabavi","6481");
			nurse[1] = n1;
		}

    }
}

