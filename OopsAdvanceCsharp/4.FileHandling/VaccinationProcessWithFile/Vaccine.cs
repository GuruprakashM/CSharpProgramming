using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationProcess
{
    public enum VaccineName{Default,Covidshield,Covaccine}
    public class Vaccine
    {
        private static int s_vaccineID=100;
        public string VaccineID { get; set; }

        public VaccineName VaccineName{get;set;}
        public int NoOfAvailableDose {get;set;}
        public Vaccine(VaccineName vaccineName, int noOfAvailableDose)        
        {
            s_vaccineID++;
            VaccineID="CID"+s_vaccineID;
            VaccineName=vaccineName;
            NoOfAvailableDose=noOfAvailableDose;
        }
        
    }
}