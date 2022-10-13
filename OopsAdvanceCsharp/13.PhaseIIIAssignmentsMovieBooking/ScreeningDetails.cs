using System;
namespace MovieBooking
{
    /* Movie ID  TheatreID
 NoOfSeatsAvailable
 Ticket Price*/
    public class ScreeningDetails
    {
      
        /// 
        /// /// <summary>
        /// movie name
        /// </summary>
        /// <value></value>

        public string MovieID { get; set; }
        /// <summary>
        /// 
        /// Theatre iD
        /// </summary>
        /// <value></value>
        public string TheatreID { get; set; }
        /// <summary>
        ///Seat availablity show
        /// </summary>
        /// <value></value>
        public int  NoOfSeatsAvailable{ get; set; }
        /// <summary>
        /// Ticket price of each ticket
        /// </summary>
        /// <value></value>
        public double TicketPrice { get; set; }

        public ScreeningDetails(string movieId,string theatreId, double ticketPrice,int noOfSeatsAvailable)
        {
              MovieID=movieId;
              TheatreID=theatreId;
              NoOfSeatsAvailable=noOfSeatsAvailable;
              TicketPrice=ticketPrice;
        }

        public ScreeningDetails(string data)
        {
           string[] values= data.Split(",");
           MovieID=values[0];
           TheatreID=values[1];
           NoOfSeatsAvailable=int.Parse(values[2]);
           TicketPrice=double.Parse(values[3]);
        }
    }
}