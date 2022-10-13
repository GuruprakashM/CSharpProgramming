using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication
{
    public static class Operations
    {
       static List<UserRegisteration> usersList =new List<UserRegisteration>();
       static List<BookDetails> booksList =new List<BookDetails>();
       static List<BorrowBooks> borrowBooksList =new List<BorrowBooks> ();

      static UserRegisteration currentUser=null;
        public static void DefaultSetUp()
        {
            UserRegisteration userone=new UserRegisteration("Baskar",Gender.Male,Department.EEE,8989,"Baskar@gmail",3000 );
            usersList.Add(userone);
             UserRegisteration userTwo=new UserRegisteration("Ravi",Gender.Male,Department.ECE,8989,"ravi@gmail",4000);
             usersList.Add(userTwo);
             BookDetails bookone=new BookDetails("c#","Demis",3);
             booksList.Add(bookone);
             BookDetails bookTwo=new BookDetails("HTML","Eemis",5);
             booksList.Add(bookTwo);
             BookDetails bookThree=new BookDetails("CSS","Femis",3);
             booksList.Add(bookThree);
             BookDetails bookFour=new BookDetails("JS","Gemis",3);
             booksList.Add(bookFour);
             BookDetails bookFive=new BookDetails("TS","Hemis",2);
             booksList.Add(bookFive);
             BorrowBooks borrowBookone= new BorrowBooks("BID101","SF3001", new DateTime(2022,04,10),Status.Issued);
             borrowBooksList.Add(borrowBookone);
             BorrowBooks borrowBookTwo= new BorrowBooks("BID103","SF3001", new DateTime(2022,04,12),Status.Returned);
            borrowBooksList.Add(borrowBookTwo);
             BorrowBooks borrowBookThree= new BorrowBooks("BID104","SF3001", new DateTime(2022,04,15),Status.Issued);
             borrowBooksList.Add(borrowBookThree);
             BorrowBooks borrowBookFour= new BorrowBooks("BID102","SF3001=2", new DateTime(2022,04,11),Status.Returned);
             borrowBooksList.Add(borrowBookFour);
            BorrowBooks borrowBookFive= new BorrowBooks("BID105","SF3002", new DateTime(2022,04,15),Status.Issued);
            borrowBooksList.Add(borrowBookFive);
        }   
     
     
        public static void MainMenu()
        {
             DefaultSetUp();
             string condition="";
             do 
             {
             Console.WriteLine($"Here  is the Options of MainManu");
             Console.WriteLine($"1.UserRegisteration \n2.Login \n3.Exit");
             Console.WriteLine($"Enter your choice");
             int choice=int.Parse(Console.ReadLine());
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
                    //Exit
                    condition="no";
                    break;
                }
                
                
                
             }
             if(condition =="no"){break;}
                
                Console.WriteLine($"Do you want to continue");
                condition=Console.ReadLine().ToLower();
             
             }while(condition=="yes");   
             
        }
        public static void Registeration()
        {
            Console.WriteLine($"Enter your name");
            string name =Console.ReadLine();
            Console.WriteLine($"Enter your Gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.WriteLine($"Enter your Department");
            Department department =Enum.Parse<Department>(Console.ReadLine(),true);
            Console.WriteLine($"Enter your MobileNumber");
            long mobileNumber=long.Parse(Console.ReadLine());
            Console.WriteLine($"Enter your MailId");
            string mailID=Console.ReadLine();
            Console.WriteLine($"enter your WalletBalance");
            int walletBalance=int.Parse(Console.ReadLine());
            
            UserRegisteration user = new UserRegisteration(name, gender,department,mobileNumber,mailID,walletBalance);
            usersList.Add(user);
            Console.WriteLine($"Here is the your LibraryRegisterID {user.RegisterNumber}");
            
        }
       public static void Login()
       {
        Console.WriteLine($"Enter your RegisterID");
        string registerid=Console.ReadLine();
        int count=0;
        foreach(UserRegisteration getUser in usersList)
        {
            if(registerid==getUser.RegisterNumber)
            {
                currentUser=getUser;
                Console.WriteLine($"You have been successFully Logined");
                count++;
                SubMenu();
            }
        }
        if(count==0)

        {
            Console.WriteLine($"Invalid registerID ensure With that");
            
        }
       }
     public static void SubMenu() 
     {
        string condition="";
        do 
       {
        Console.WriteLine($"Here is the choices of SubMenu");
        Console.WriteLine($"1.BorrowBook \n2.ShowBorrowedHistory \n3.ReturnsBooks \n4.WalletRecharge \n5.Exit");
        Console.WriteLine($"Enter your choice");
       int choice =int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    BorrowBook();
                    break;
                }
                case 2:
                {  
                    ShowBorrowedHistory();
                    break;
                }
                case 3:
                {
                    ReturnsBooks();
                    break;
                }
                case 4:
                {
                    WalletRecharge();
                    break;
                }
                 case 5:
                 {
                    
                    condition="no";
                    break;
                 }
            } 
            if(condition=="no"){break;}
            Console.WriteLine($"Do you want to continue With SubMenu");
            condition=Console.ReadLine().ToLower();
                   
        
     }while(condition =="yes");
     
     }
    
     public static void BorrowBook()
     {
       Console.WriteLine($"Here is the List of Books");
       Console.WriteLine($"---------------------------------");
       
       foreach( BookDetails TotalBooks in booksList)
       {
            Console.WriteLine($"BookName: {TotalBooks.BookName}---- AuthorName:{TotalBooks.AuthorName}---- BookID :{TotalBooks.BookID} --Bookcount {TotalBooks.BooKStock} \n");
             
            
       }
       Console.WriteLine($"--------------------------------");
       Console.WriteLine($"Please pick out one of books by using BookID");
       string userBookId=Console.ReadLine();
       int count1=0;
       bool bookAvalible=false;
       int userborrowtime=0;
       bool borrowvalid=false;

       //check book avalible
       foreach(BookDetails checkAvailable in booksList)
       {
            if(userBookId==checkAvailable.BookID)
            {
                count1++;
                if(checkAvailable.BooKStock>0)
                {
                   bookAvalible=true;
                }
                else
                {
                    
                    DateTime date=new DateTime();
                    foreach(BorrowBooks check in borrowBooksList)
                    {
                        if(userBookId==check.BookID)
                        {
                            date=check.BorrowedDate;
                        }
                    }
                    date=date.AddDays(15);
                    Console.WriteLine($"Book is not Avaliable as of now");
                    Console.WriteLine($"You need to wait until{date.ToShortDateString()}");
                    
                    
                    
                }
            }
       }
       //user entry invalid entry
       if(count1==0)
       {
        Console.WriteLine($"Invalid BOOKID entry");
        
       }
       //check the user alreday taken 3 books
       foreach(BorrowBooks checkborrowtime in borrowBooksList)
       {
           if(currentUser.RegisterNumber==checkborrowtime.RegisterNumberID && Status.Issued==checkborrowtime.Status)
           {
              userborrowtime++;
           }
       }
       if(bookAvalible==true && userborrowtime<3)
       {
        Console.WriteLine($"The book successfully borrowed as you wanted");
    
        borrowvalid=true;
        
       }
       else if(bookAvalible==true && userborrowtime>=3)
       {
        Console.WriteLine($"you can't take book as of now becacause already took 3 times first you return those books");
        
       }
       foreach(BookDetails bookstockupdate in booksList)
       {
        if(userBookId==bookstockupdate.BookID)
        {
            bookstockupdate.BooKStock=bookstockupdate.BooKStock-1;
        }
       }
       if(borrowvalid==true)
       {
       BorrowBooks borrowupdate =new BorrowBooks(userBookId,currentUser.RegisterNumber,DateTime.Now,Status.Issued);
       borrowBooksList.Add(borrowupdate);
       Console.WriteLine($"your Borrow ID generated {borrowupdate.BorrowID}");
       }
     }
     public static void ShowBorrowedHistory()
     {
        foreach (BorrowBooks getData in borrowBooksList)
        {
            if(currentUser.RegisterNumber==getData.RegisterNumberID)
            {
                Console.WriteLine($"---------------------------------------------\n");
                
                Console.WriteLine($"BorrowID: {getData.BorrowID} \nBook ID: {getData.BookID} \nRegisterNumber : {getData.RegisterNumberID} \nBorrowedDate :{getData.BorrowedDate.ToShortDateString()} \nStatus {getData.Status}");
            }   Console.WriteLine($"-------------------------------------\n");
            
        }
     }

     public static void ReturnsBooks()
     {
      Console.WriteLine($"Enter your BorrowId");
      string userBorrowid=Console.ReadLine();
      DateTime date =new DateTime();
      bool returnstatus=false;
      foreach(BorrowBooks check in borrowBooksList)
      {
        if(currentUser.RegisterNumber==check.RegisterNumberID && userBorrowid==check.BorrowID)
        {
             date=check.BorrowedDate;
        }
      }
      
      TimeSpan time = new TimeSpan();
      time=DateTime.Now.Subtract(date);
     
      int store=(int)time.TotalDays;
      int totalAmount=0;
      if((int)time.TotalDays<=15)
      {
        Console.WriteLine($"your Status Successfully updated now you Returned your Book");
        Console.WriteLine($"--THANK YOU----");
        returnstatus=true;
        
      }
      else if((int)time.TotalDays>15 && returnstatus==false)
      {
        totalAmount=(store-15)*1;
    
        Console.WriteLine($"you need to pay Rs.{totalAmount}");
        
      }
      Console.WriteLine($"Enter your Amount");
      int amount = int.Parse(Console.ReadLine());
      if(amount<currentUser.WalletBalance && returnstatus==false)
      {
        Console.WriteLine($"Now you successfully returned your Book with out any due fees");
        returnstatus=true;

      }
      else
      {
        Console.WriteLine($"You need to add money Wallet insufficient Balance");
        
      }
   
      if(returnstatus==true)
      {
      
        foreach(BorrowBooks borrowupdate in borrowBooksList)
        {
               if(userBorrowid==borrowupdate.BorrowID)
               {
                  borrowupdate.Status=Status.Returned;
               }
        } 
        
      }
      
      
     }
    
     public static void WalletRecharge()
     {
        Console.WriteLine($"Your Exist Amount : Rs.{currentUser.WalletBalance}");
        
        Console.WriteLine($"Enter your amount OF recharge");
        int walletRecharge=int.Parse(Console.ReadLine());
        currentUser.WalletBalance=currentUser.WalletBalance+walletRecharge;
        Console.WriteLine($"You have been successfully Reacharged");
        Console.WriteLine($"Your current Wallet Balance :Rs.{currentUser.WalletBalance}");
        
        
        
        
     }
    }
}