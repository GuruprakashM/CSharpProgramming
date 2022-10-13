using System;

namespace MovieBooking
{
    /*TheatreID(Auto Increment – TID301)  TheatreName
 TheatreLocation*/
    public class TheatreDetails
    {
        
        private static int s_theatreId=300;
       /// <summary>
       /// Theatre ID 
       /// </summary>
       /// <value></value>
        public string TheatreID { get; }
        /// <summary>
        /// Thearte Name Show Purpose
        /// </summary>
        /// <value></value>
        public string  TheatreName { get; set; }
        /// <summary>
        /// Theatre Location
        /// </summary>
        /// <value></value>
        public string TheatreLocation { get; set; }

        public TheatreDetails(string theatreName, string theatreLocation)
        {
              s_theatreId++;
              TheatreID="TID"+s_theatreId;
              TheatreName=theatreName;
              TheatreLocation=theatreLocation;
        }

        public TheatreDetails(string data)
        {
           string[] values= data.Split(",");
           s_theatreId = int.Parse(values[0].Remove(0,3));
           TheatreID=values[0];
           TheatreName = values[1];
           TheatreLocation=values[2];
        }
        public void ShowTheatreDetails()
        {
            
            Console.WriteLine($"{TheatreID}  -----  {TheatreName}  ---- {TheatreLocation}");
            
            
        }
    }
}