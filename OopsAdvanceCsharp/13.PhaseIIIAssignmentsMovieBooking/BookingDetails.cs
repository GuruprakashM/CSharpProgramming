using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBooking
{
    public enum BookingStatus{Default,Booked,Cancelled}
    /* BookingID (Auto Increment – BID7001)  UserID
 MovieID
 TheatreID
 SeatCount  TotalAmount  BookingStatus (Enum type – Booked, Cancelled)*/
    public class BookingDetails
    {
       
        private  static int s_bookingId=7000;
         /// <summary>
        /// Booking ID of current user
        /// </summary
        public string BookingID { get; set; } 
        /// <summary>
        /// userID
        /// </summary>
        /// <value></value>
        public  string  UserID { get; set; }
        /// <summary>
        /// unqiueID of  movie
        /// </summary>
        /// <value></value>
        public string MovieID { get; set; }
        /// <summary>
        /// 
        /// theatre ID for tracking the Theatre
        /// </summary>
        /// <value></value>
        public string TheatreID { get; set; }
        /// <summary>
        /// NO of tickets buy Details
        /// </summary>
        /// <value></value>
        public int SeatCount { get; set; }
        /// <summary>
        /// total amount tickets
        /// </summary>
        /// <value></value>
        public double TotalAmount { get; set; }
        /// <summary>
        /// Current Booking Status
        /// </summary>
        /// <value></value>
        public BookingStatus BookingStatus{ get; set; }

        /// <summary>
        /// BookingDetails Stored Process
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="movieId"></param>
        /// <param name="theatreId"></param>
        /// <param name="seatCount"></param>
        /// <param name="totalAmount"></param>
        /// <param name="bookingStatus"></param>
        public BookingDetails(string userId,string movieId ,string theatreId,int seatCount,double totalAmount,BookingStatus bookingStatus)
        {
            s_bookingId++;
            BookingID="BID"+s_bookingId;
            UserID=userId;
            MovieID=movieId;
            TheatreID=theatreId;
            SeatCount=seatCount;
            TotalAmount=totalAmount;
            BookingStatus=bookingStatus;
        }
         /// <summary>
         /// FILE READ PROCESS
         /// </summary>
         /// <param name="data"></param>
        public BookingDetails(string data)
        {
           string[] values= data.Split(",");
           s_bookingId = int.Parse(values[0].Remove(0,3));
           BookingID=values[0];
           UserID= values[1];
           MovieID=values[2];
           TheatreID=values[3];
           SeatCount=int.Parse(values[4]);
           TotalAmount=double.Parse(values[5]);
           BookingStatus=Enum.Parse<BookingStatus>(values[6],true);
        }
    }
}