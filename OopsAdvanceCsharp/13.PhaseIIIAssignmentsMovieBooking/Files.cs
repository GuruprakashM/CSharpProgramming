using System;
using System.IO;

namespace MovieBooking
{
    public static class Files
    {
        /// <summary>
        /// 
        /// FileCreation Process
        /// </summary>
        public static void CreateFile()
        {
            if(!Directory.Exists("MovieBooking"))
            {
                Directory.CreateDirectory("MovieBooking");
            }
            if(!File.Exists("MovieBooking/UserDetails.csv"))
            {
                File.Create("MovieBooking/UserDetails.csv");
            }
            if(!File.Exists("MovieBooking/MovieDetails.csv"))
            {
                File.Create("MovieBooking/MovieDetails.csv");
            }
            if(!File.Exists("MovieBooking/TheatreDetails.csv"))
            {
                File.Create("MovieBooking/TheatreDetails.csv");
            }
            if(!File.Exists("MovieBooking/ScreeningDetails.csv"))
            {
                File.Create("MovieBooking/ScreeningDetails.csv");
            }
            if(!File.Exists("MovieBooking/BookingDetails.csv"))
            {
                File.Create("MovieBooking/BookingDetails.csv");
            }
         
        }
 
       
       /// <summary>
       /// FileRead Process
       /// </summary>
        public static void ReadFile()
        {
            string[] getOne = File.ReadAllLines("MovieBooking/UserDetails.csv");
            foreach( var data in getOne )
            {
                if(data!="")
                {
                    UserRegsiteration user = new UserRegsiteration(data);
                    Operations.userList.Add(user);
                }
            }

            string[] getTwo = File.ReadAllLines("MovieBooking/MovieDetails.csv");
            foreach( var data in getTwo )
            {
                if(data!="")
                {
                    MovieDetails movie = new MovieDetails(data);
                    Operations.movieList.Add(movie);
                }
            }

            string[] getThree = File.ReadAllLines("MovieBooking/TheatreDetails.csv");
            foreach( var data in getThree )
            {
                if(data!="")
                {
                   TheatreDetails theatre = new TheatreDetails(data);
                    Operations.theatreList.Add(theatre);
                }
            }

            string[] getFour = File.ReadAllLines("MovieBooking/ScreeningDetails.csv");
            foreach( var data in getFour)
            {
                if(data!="")
                {
                    ScreeningDetails screening = new ScreeningDetails(data);
                    Operations.screeningList.Add(screening);
                }
            }
            
            string[] getFive = File.ReadAllLines("MovieBooking/BookingDetails.csv");
            foreach( var data in getFive)
            {
                if(data!="")
                {
                    BookingDetails booking = new BookingDetails(data);
                    Operations.bookingList.Add(booking);
                }
            }
            
        }
         /// <summary>
         /// File Write Process
         /// </summary>
        public static void WriteFile()
        {
            string[] outputOne =new string[Operations.userList.Count];
            for(int i=0; i<Operations.userList.Count; i++)
            {
                outputOne[i]=Operations.userList[i].UserID+","+Operations.userList[i].Name+","+Operations.userList[i].Age+","+Operations.userList[i].MobileNumber+","+Operations.userList[i].WalletBalance;
            }
            File.AppendAllLines("MovieBooking/UserDetails.csv",outputOne);

            string[] outputTwo =new string[Operations.movieList.Count];
            for(int i=0; i<Operations.movieList.Count; i++)
            {
                outputTwo[i]=Operations.movieList[i].MovieID+","+Operations.movieList[i].MovieName+","+Operations.movieList[i].Language;
            }
            File.AppendAllLines("MovieBooking/MovieDetails.csv",outputTwo);
            
            string[] outputThree =new string[Operations.theatreList.Count];
            for(int i=0; i<Operations.theatreList.Count; i++)
            {
                outputThree[i]=Operations.theatreList[i].TheatreID+","+Operations.theatreList[i].TheatreName+","+Operations.theatreList[i].TheatreLocation;
            }
            File.AppendAllLines("MovieBooking/TheatreDetails.csv",outputThree);
           

            string[] outputFour =new string[Operations.screeningList.Count];
            for(int i=0; i<Operations.screeningList.Count; i++)
            {
                outputFour[i]=Operations.screeningList[i].MovieID+","+Operations.screeningList[i].TheatreID+","+Operations.screeningList[i].NoOfSeatsAvailable+","+Operations.screeningList[i].TicketPrice;
            }
            File.AppendAllLines("MovieBooking/ScreeningDetails.csv",outputFour);


            string[] outputFive = new string[Operations.bookingList.Count];
            for(int i=0; i<Operations.bookingList.Count; i++)
            {
                outputFive[i]=Operations.bookingList[i].BookingID+","+Operations.bookingList[i].UserID+","+Operations.bookingList[i].MovieID+","+Operations.bookingList[i].TheatreID+","+Operations.bookingList[i].SeatCount+","+Operations.bookingList[i].TotalAmount+","+Operations.bookingList[i].BookingStatus;
            }
            File.AppendAllLines("MovieBooking/BookingDetails.csv", outputFive);



        }
    }
}

          