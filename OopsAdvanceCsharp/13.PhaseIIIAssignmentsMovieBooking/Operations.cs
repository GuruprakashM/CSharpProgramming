using System;

namespace MovieBooking
{
    public delegate void EventManager();
    public static class Operations
    {

        public static event EventManager eventlink=null;
        public static void SubScribes()
        {
            eventlink+=new EventManager(Files.CreateFile);
            eventlink+=new EventManager(Files.ReadFile);
            eventlink+=new EventManager(Operations.MainMenu);
            //eventlink+= new EventManager(Files.WriteFile);
        } 

        public static void StartEvent()
        {
            SubScribes();
            eventlink();
        }
        static UserRegsiteration currentUser =null;
        public static List<UserRegsiteration> userList = new List<UserRegsiteration>();
        public static List<TheatreDetails>  theatreList = new List<TheatreDetails>();
        public static List<MovieDetails> movieList = new List<MovieDetails>();
        public static List<ScreeningDetails> screeningList =  new List<ScreeningDetails>();
        public static List<BookingDetails> bookingList = new List<BookingDetails>();
        public static void MainMenu()
        {
           // DefaultSetUp();
            string condition="";
                do 
                { 
                    Console.WriteLine($"Welcome BookingMovies.com ");
                    Console.WriteLine($"MainMenu Details");
                    Console.WriteLine($"1.Registeration \n2.Login \n3.Exit");
                    Console.WriteLine($"Enter your choice");
                    int choice = int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                            case 1:
                            {
                                Registeration();
                                break;
                            }
                            case 2:
                            {
                                Login();
                                break;
                            }
                            case 3:
                            {
                                condition="no";
                                Console.WriteLine($"EXIT FROM MAINMENU \nTHANK YOU VISIT AGAIN");
                                break;
                            }
                    }
                    if(condition=="no"){break;}
                    Console.WriteLine($"Do you want Continue with MainMenu");
                    condition=Console.ReadLine().ToLower();
                
                }while(condition=="yes");
        
        }

        public static void Registeration()
        {
            Console.WriteLine($"---Registeration Process---");

            Console.WriteLine($"Enter your Name");
            string name=Console.ReadLine();

            Console.WriteLine($"Enter your Age");
            int age=int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your MobileNumber");
            long mobileNumber= long.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your WalletBalance");
            double walletBalance= double.Parse(Console.ReadLine());

            UserRegsiteration userNew = new UserRegsiteration(name,age,mobileNumber,walletBalance);
            userList.Add(userNew);

            Console.WriteLine($"Your Registeration process has been successfully completed \n");
            Console.WriteLine($"Your RegisteartionID is {userNew.UserID}");
            
        }


        public static void Login()
        {

            Console.WriteLine($"Login process");
            Console.WriteLine($"Enter your RegisterID");
            bool userValid=false;
            string userId=Console.ReadLine().ToUpper();
                foreach(UserRegsiteration userCheck in userList)
                {
                    if(userCheck.UserID==userId)
                    {
                        currentUser=userCheck;
                        userValid=true;
                        Console.WriteLine($"you have been SuccessFully Logined \n");
                        SubMenu();
                        
                    }
                }
                if(userValid==false)
                {
                    Console.WriteLine($"Invalid RegisterId has entered ensure with that");
                    
                }
            
            
        }
        public static void SubMenu() 
        {
            string condition="";
                do 
                { 
                   
                    Console.WriteLine($"SubMenu Details");
                    Console.WriteLine($"1.TicketBooking \n2.TicketCancellation \n3.BookingHistory \n4.WalletRecharge \n5.Exit");
                    Console.WriteLine($"Enter your choice");
                    int choice = int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                            case 1:
                            {
                                TicketBooking();
                                break;
                            }
                            case 2:
                            {
                                TicketCancellation();
                                break;
                            }
                            case 3:
                            {
                               BookingHistory();
                                break;
                            }
                            case 4:
                            {
                                Console.WriteLine($"Enter the Recharge amount ");
                                double amount =double.Parse(Console.ReadLine());
                                currentUser.WalletRecharge(amount);
                                break;
                            }
                            case 5:
                            {
                                condition="no";
                                Console.WriteLine($"EXIT FROM SUBMENU");
                                break;
                            }
                    }
                    if(condition=="no"){break;}
                    Console.WriteLine($"Do you want Continue with SubMenu");
                    condition=Console.ReadLine().ToLower();
                
                }while(condition=="yes");
        }


        public static void TicketBooking()
        {
            
            /// <summary>
            /// Temperary List of screeningDetails
            /// </summary>
            /// <typeparam name="ScreeningDetails"></typeparam>
            /// <returns></returns>
            List<ScreeningDetails> tempScreen = new List<ScreeningDetails>();


            int noOfSeatsBuy=0;
            bool seatAvailable=false;
            bool booking=false;
            bool theatreIdValid=false;
            bool movieIdValid=false;
            double totalAmountGST=0;
            string movieIdUser="";

            //Theatres Details Show

            Console.WriteLine($"Here is the Theatre Details");
            Console.WriteLine($"TheatreID | TheatreName |TheatreLocation:");
                foreach(TheatreDetails theatre in theatreList)
                {
                        theatre.ShowTheatreDetails();
                }  
            Console.WriteLine();
            
            //Compare  theatre  with Screening Details 

            Console.WriteLine($"Enter the TheatreID shown the Above details");
            string theatreIdUser=Console.ReadLine().ToUpper();

                foreach(ScreeningDetails screen in screeningList)
                {
                    if(theatreIdUser==screen.TheatreID)
                    {
                        ScreeningDetails screening = new ScreeningDetails(screen.MovieID,screen.TheatreID,screen.TicketPrice,screen.NoOfSeatsAvailable);
                        tempScreen.Add(screening);
                        theatreIdValid=true;
                    }
                    
                }
          
            Console.WriteLine();
            
            // Screening Details Show

                if(theatreIdValid==true)
                {
                Console.WriteLine($"Here is the Movie Screening Details about in this theatre");
                Console.WriteLine($"MovieID|   Moviename|   Language");
                }
                foreach(ScreeningDetails screenShow in tempScreen)
                {
                        foreach(MovieDetails movie in movieList)
                        {
                            if(screenShow.MovieID==movie.MovieID)
                            {
                                Console.WriteLine($"{movie.MovieID}  -----  {movie.MovieName}  ---- {movie.Language}");
                                
                            }

                            
                        }
                }
         
            Console.WriteLine();


            //Pick the movie from the MovieDetails

                if((theatreIdValid==true))
                {
                Console.WriteLine($"Enter the movieID which movie you want to book above the list");
                movieIdUser =Console.ReadLine().ToUpper();
                    
                }
             
                foreach(ScreeningDetails screenBook in tempScreen)
                {
                    if(movieIdUser==screenBook.MovieID)
                    {
                        Console.WriteLine($"Enter the amount of the  tickets you want to buy");
                        noOfSeatsBuy=int.Parse(Console.ReadLine());
                        movieIdValid=true;
                        if(screenBook.NoOfSeatsAvailable>=noOfSeatsBuy)
                        {
                                double totalAmount=(noOfSeatsBuy*screenBook.TicketPrice);
                                totalAmountGST=(totalAmount*0.18)+totalAmount;
                                Console.WriteLine($"Your total amount of tickets are Rs.{totalAmountGST}"); 
                                seatAvailable=true;
                        }
                        else
                        {
                            Console.WriteLine($"Seats not available as you required");
                            
                        }
                        
                        
                    }
                }


            // BOOKING PROCESS
            if(seatAvailable==true)
            {
                while(booking==false)
                {
                        if(currentUser.WalletBalance>=totalAmountGST)
                        {

                             foreach (ScreeningDetails Seatupdate in screeningList)
                             {
                                 if(Seatupdate.TheatreID==theatreIdUser && Seatupdate.MovieID==movieIdUser)
                                 {
                                        currentUser.WalletBalance-=totalAmountGST;
                                        Seatupdate.NoOfSeatsAvailable-=noOfSeatsBuy;
                                        BookingDetails bookingConfirm = new BookingDetails(currentUser.UserID,movieIdUser,theatreIdUser,noOfSeatsBuy,totalAmountGST,BookingStatus.Booked);
                                        bookingList.Add(bookingConfirm);
                                        Console.WriteLine($"You have booked the tickets Successfully");
                                        Console.WriteLine($"Your bookig id is {bookingConfirm.BookingID}");
                                        Console.WriteLine($"Your current Balance of AfterBooking is Rs. {currentUser.WalletBalance}"); 
                                        booking=true;
                                 }
                             }     
                             
                        
                        }

                        else
                        {
                             Console.WriteLine($"Please Recharge your wallet at least minimum with {totalAmountGST}");
                             Console.WriteLine($"Enter your Recharge amount ");
                             double amount=double.Parse(Console.ReadLine());
                             currentUser.WalletRecharge(amount);

                             
                        }
                        if(booking==true){break;}
               
                }
          
            }
            if(movieIdValid==false && theatreIdValid==true)
            {
                Console.WriteLine($"Invalid MovieID Entry");
                
            }
            if(theatreIdValid==false)
            {
                Console.WriteLine($"Invalid THEATRE ID entry");
                
            }
            
        }

        public static void TicketCancellation()
        {
            bool cancelled=false;
            bool bookIdValid=false;
            Console.WriteLine($"Ticket cancellation process");
            Console.WriteLine($"enter your  Booking Id ");
            string bookingid =Console.ReadLine().ToUpper();
            foreach ( BookingDetails bookingCancel in bookingList)
            {
                if(bookingCancel.UserID==currentUser.UserID && bookingCancel.BookingID==bookingid)
                {
                    bookIdValid=true;
                    foreach ( ScreeningDetails screen in screeningList)
                    {
                         if(bookingCancel.MovieID == screen.MovieID && bookingCancel.TheatreID == screen.TheatreID && bookingCancel.BookingStatus==BookingStatus.Booked)
                         {
                            screen.NoOfSeatsAvailable+=bookingCancel.SeatCount;
                            currentUser.WalletBalance+=bookingCancel.TotalAmount-20.0f;
                            bookingCancel.BookingStatus=BookingStatus.Cancelled;
                            Console.WriteLine($"Your booking successfully cancelled \nYour wallet Money also Updated  ");
                            Console.WriteLine($"Your current wallet Balance is Rs.{currentUser.WalletBalance}");
                            cancelled=true;
                            
                         }
                         
                    }
                    
                }
            }
           if(bookIdValid==true && cancelled==false)
           {
            Console.WriteLine($"booking already cancelled");
            
           }
           if(bookIdValid==false && cancelled==false)
           {
            Console.WriteLine($"Invalid Booking ID Entered");
            
           }
            
            
        }
        public static void BookingHistory()
        {
            Console.WriteLine($"BOOKING HISTORY");
            Console.WriteLine($"-------------------------------------");
                  foreach ( BookingDetails booking in bookingList)
                  {
                        if(booking.UserID==currentUser.UserID)
                        {
                            Console.WriteLine($"Booking ID :{booking.BookingID} \nuserID : {booking.UserID} \nMovieId :{booking.MovieID} \nTheatreId :{booking.TheatreID} \nNooftciketsorder :{booking.SeatCount}\nTotalamount :{booking.TotalAmount}\nBookingStatus :{booking.BookingStatus}");
                            Console.WriteLine();
                            
                        }
                  }
            Console.WriteLine($"----------------------------------------");
            
        }



        /*public static void DefaultSetUp()
        {
            //userList
            UserRegsiteration userOne = new UserRegsiteration("guru",21,9894999231,1000);
            userList.Add(userOne);
            UserRegsiteration userTwo = new UserRegsiteration("guruprakash",22,984999231,2000);
            userList.Add(userTwo);


            //TheatreList 
            TheatreDetails theatreOne = new TheatreDetails("Inox", "Anna Nagar");
            theatreList.Add(theatreOne);
            TheatreDetails theatreTwo = new TheatreDetails("Ega","Theatre Chetpet");
            theatreList.Add(theatreTwo);
            TheatreDetails theatreThree = new TheatreDetails("Kamala", "Vadapalani");
            theatreList.Add(theatreThree);

            //MovieList 
           MovieDetails movieOne = new MovieDetails("Bagubhali2 ", "Telugu");
           movieList.Add(movieOne);
           MovieDetails movieTwo = new MovieDetails("Ponniyin Selvan","Tamil");
           movieList.Add(movieTwo);
           MovieDetails movieThree = new MovieDetails("Cobra", "Tamil");
           movieList.Add(movieThree);
           MovieDetails movieFour = new MovieDetails(" Vikram", "Hindi(Dubbed)");
           movieList.Add(movieFour);
           MovieDetails movieFive= new MovieDetails(" Vikram", "Tamil");
           movieList.Add(movieFive);
           MovieDetails movieSix = new MovieDetails("Beast", "English");
           movieList.Add(movieSix);
           

           //ScreeingList
           ScreeningDetails screenOne = new ScreeningDetails("MID501" ,"TID301",200, 5);
           screeningList.Add(screenOne);
           ScreeningDetails screenTwo = new ScreeningDetails("MID502","TID301", 300,2);
           screeningList.Add(screenTwo);
           ScreeningDetails screenThree = new ScreeningDetails("MID506","TID301",50 ,1);
           screeningList.Add(screenThree);
           ScreeningDetails screenFour= new ScreeningDetails("MID501","TID302",400,11);
           screeningList.Add(screenFour);
           ScreeningDetails screenFive= new ScreeningDetails("MID502", "TID302",300,20);
           screeningList.Add(screenFive);
           ScreeningDetails screenSix = new ScreeningDetails("MID504","TID302",500,2);
           screeningList.Add(screenSix);
           ScreeningDetails screenSeven = new ScreeningDetails("MID505","TID303",100,11);
           screeningList.Add(screenSeven);
           ScreeningDetails screenEight = new ScreeningDetails("MID502","TID303",200,20);
           screeningList.Add(screenEight);
           ScreeningDetails screenNine = new ScreeningDetails("MID504","TID303",350,2 );
           screeningList.Add(screenNine);
           
           //BookingDetails

           BookingDetails bookingone = new BookingDetails("UID1001","MID501","TID301",1, 200,BookingStatus.Booked);
           bookingList.Add(bookingone);
           BookingDetails bookingTwo = new BookingDetails("UID1001","MID504","TID302", 1, 400,BookingStatus.Booked );
           bookingList.Add(bookingTwo);
           BookingDetails bookingThree = new BookingDetails(" UID1002","MID505", "TID302", 1, 300, BookingStatus.Booked);
           bookingList.Add(bookingThree);

        }*/
    }

}
