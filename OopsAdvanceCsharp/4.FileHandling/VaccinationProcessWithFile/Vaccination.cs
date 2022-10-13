using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationProcess
{
    
    public class Vaccination
    {
        private static int s_vaccinationId=1000;
        public string  VaccinationID{ get; set; }
        public string RegisterNumber{ get; set; }
        public string VaccineID { get; set; }

        public int DoseNumber { get; set; }
        
        public DateTime VaccinatedDate{get;set;}
        
        public Vaccination(string registerNumber,string vaccineID, int doseNumber, DateTime vaccinatedDate)
        {
            s_vaccinationId++;
            VaccinationID="VID"+s_vaccinationId;
            RegisterNumber=registerNumber;
            VaccineID=vaccineID;
            DoseNumber=doseNumber;
            VaccinatedDate=vaccinatedDate;
        }
        
              
        
    }
}