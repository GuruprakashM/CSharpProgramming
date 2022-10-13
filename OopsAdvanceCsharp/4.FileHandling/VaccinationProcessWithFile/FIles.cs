using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
namespace VaccinationProcess
{
    public  static class FIles
    {
        public static void CreateFile()
        {
            if(!Directory.Exists("Vaccination"))
            {
                Console.WriteLine($"Folder creating SuccessFully");
                
                Directory.CreateDirectory("Vaccination");
            }
            else 
            {
                Console.WriteLine($"Folder Already Exist");
                
            }
            if(!File.Exists("Vaccination/Beneficiary.csv"))
            {
                File.Create("Vaccination/Beneficiary.csv");
            }
            if(!File.Exists("Vaccination/Vaccine.csv"))
            {
                File.Create("Vaccination/Vaccine.csv");
            }
            if(!File.Exists("Vaccination/Vaccination.csv"))
            {
                File.Create("Vaccination/Vaccination.csv");
            }
        }

        public static void ReadFiles()
        {
            string[] get=File.ReadAllLines("Vaccination/Beneficiary.csv");
            foreach(var check in get)
            {
                Beneficiary user = new Beneficiary(check);
                Operation.BeneficiariesList.Add(user);
            }
        }
        public static void WriteFiles()
        {
            string[] output = new string[Operation.BeneficiariesList.Count];
            for(int i =0 ;i<Operation.BeneficiariesList.Count; i++)
            {
               output[i]=Operation.BeneficiariesList[i].RegisterNumber+","+Operation.BeneficiariesList[i].Name+","+Operation.BeneficiariesList[i].Age+","+Operation.BeneficiariesList[i].Gender+","+Operation.BeneficiariesList[i].City+","+Operation.BeneficiariesList[i].MobileNumber;
            }
            File.WriteAllLines("Vaccination/Beneficiary.csv",output);
        }
    }
}
/*

public Beneficiary(string check)
        {
            string[] values= check.Split(",");
            s_registerNumber=int.Parse(values[0].Remove(0,3));
            RegisterNumber=values[0];
            Name=values[1];
            Age=int.Parse(values[2]);
            Gender=Enum.Parse<Gender>(values[3],true);
            City=values[4];
            MobileNumber=long.Parse(values[5]);

        }
*/