using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceProcess
{
    public static class Opreation
    {
        // menu 1.register 2.login 3.exit
        // 1.register 
        //2.login{customer id ok means }=> submenu 1.purchase 2.order history 3.cancel order 4. wallet recharge 5.exit        
        // 3.EXit
        public static List<CustomerDetails> customerList= new List<CustomerDetails>();
         public static List<OrderDetails> orderList= new List<OrderDetails>();
        public static List<ProductDetails> productList=new List<ProductDetails>();
        static CustomerDetails currentuser=null;
       


        public static void MainMenu()
        {
           DefaultSetup();
           string condition="";
           do
           {

            Console.WriteLine($"Here is Details of Menu");
            Console.WriteLine($"1.CustomerRegistertion \n2.Login & Purchase \n3.Exit ");
            Console.WriteLine($"Enter your choice");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    Registertion();
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
                    Console.WriteLine($"------THANK YOU----");
                    break;
                }
            }
            if(condition=="no"){break;}
            Console.WriteLine($"Do you want continue with MainMenu");
            condition=Console.ReadLine().ToLower();
           }while(condition=="yes");
            Console.WriteLine($"COME & VISIT Again");
             
        }
        public static void Registertion()
           {
            Console.WriteLine($"Enter your Name");
            string customerName=Console.ReadLine();

            Console.WriteLine($"Enter your City");
            string city =Console.ReadLine();

            Console.WriteLine($"Enter your PhoneNumber");
            long mobileNumber=long.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your mail Id");
            string emailID=Console.ReadLine();

            Console.WriteLine($"Enter Your wallet intial Balance");
            double walletBalance=double.Parse(Console.ReadLine());
    
            CustomerDetails customer =new CustomerDetails(customerName,city,mobileNumber,walletBalance,emailID);
            customerList.Add(customer);
            Console.WriteLine($"--------------------------------------------\n");
            Console.WriteLine($"Your Customer ID has been Gerenerated Successfully {customer.CustomerID} \n");
            Console.WriteLine($"--------------------------------------------");            
           }
        
        public static void Login()
        {
            Console.WriteLine($"Enter your CustomerID");
            string customerID=Console.ReadLine().ToLower();
            int count=0;
            foreach(CustomerDetails customer in customerList)
            {
               
                if(customerID==customer.CustomerID.ToLower())
                {
                    currentuser=customer;
                    Console.WriteLine($"---------------------------------------------\n");
                    Console.WriteLine($"you have successfully Logined \n");
                    Console.WriteLine($"----------------------------------------------\n");
                    count++;
                    SubMenu();
                    
                }
                

            }
           if(count==0)
           {
             Console.WriteLine($"invalid entry or user doens't exist ");
                  
           }
            
        } 
     
        public static void SubMenu()
        {
            string condition="";
            do
            {
            Console.WriteLine($"Here is the options in the Submenu");
            Console.WriteLine($"1.Purchase \n2.Order History \n3.CancelOrder \n4.walllet Balance \n5.Exit");
            Console.WriteLine($"Enter your choice");
            int choice =int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    Purchase();
                    break;
                }
                case 2:
                {
                    OrderHistory();
                    break;
                }
                case 3:
                { 
                    CancelOrder();
                    break;
                }
                case 4:
                {
                    WalletBalanceRecharge();
                    break;
                    
                }
                case 5:
                {
                    //Exit();
                    condition="no";
                    break;
                }
            }
           if(condition=="no")
           {
           
            break;
            }
            Console.WriteLine($"do you want to continue with Submenu");
            condition=Console.ReadLine().ToLower();
            
            }while(condition=="yes");
            
        }
        public static void Purchase()
        {       
            string repeat="";
            string productid="";
            double purchasecost=0;
            int productcount=0;
         do
          {
                    Console.WriteLine($"HERE IS THE PRODUCT DETAILS OF OUR PLATFORM \n");
                    foreach (ProductDetails product in productList)
                        {
                         Console.WriteLine($"{product.ProductID}-----{product.ProductName} \n");
                                    
                        }
                    Console.WriteLine($"Enter your product id which one wants to buy");
                    productid=Console.ReadLine();
                    Console.WriteLine($"how many product would you like have");
                     productcount=int.Parse(Console.ReadLine());
                    purchasecost=0;
                foreach(ProductDetails productaval in productList)
                {
                    if(productaval.ProductID==productid)
                    {
                        if(productcount<=productaval.Stock)
                        {
                                purchasecost=(productaval.ProductPrize*productcount)+500;
                                Console.WriteLine($"----------------------------------------\n");
                                
                                Console.WriteLine($"we have required stocks as you expected\n you need pay per product : Rs.{productaval.ProductPrize} \nTotally you have to pay :Rs.{(purchasecost)} develivery charge Rs.500 has already included \n");
                                Console.WriteLine($"--------------------------------------------------------------");
                                repeat="";
                        }
                        else
                        {
                            Console.WriteLine($"product was out of range ");
                            Console.WriteLine($"Please try again");
                            
                            repeat="repeat";
                            break;
                        }
                        
                    }
                }

          }while(repeat=="repeat");
                    Console.WriteLine($"we have to check your wallet balance let's proceed click yes or no");
                    string click=Console.ReadLine().ToLower();
                    if(click=="yes")
                    {
                        if(currentuser.WalletBalance>=purchasecost)
                        {
                            currentuser.WalletBalance=currentuser.WalletBalance-purchasecost;
                        
                        foreach(ProductDetails productreduce in productList)
                        {
                            if(productreduce.ProductID==productid)
                            {
                                productreduce.Stock--;
                            
                             Console.WriteLine($"----------------------------------------------------\n");
                             
                             Console.WriteLine($"your Transaction successfully completed");
                             Console.WriteLine($"your current balance in wallet : RS.{currentuser.WalletBalance}");

                             Console.WriteLine($"your order status was confirmed ");
                           
                             Console.WriteLine($"your develivery with in {productreduce.ShippingDuration+1} Days \n");
                             Console.WriteLine($"THANK YOU FOR PURCHASING WITH US");
                             
                             Console.WriteLine($"----------------------------------------------------");
                            }
                            
                         }
                        
                        }
                        else
                        {
                            Console.WriteLine($"you have insufficient balance");
                            
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine($"SORRY we can't deduct amount THANK YOU");
                        
                    }
           OrderDetails ordered =new OrderDetails(currentuser.CustomerID,productid,purchasecost,DateTime.Now,productcount,OrderStatus.Ordered);
          orderList.Add(ordered);
         }

        public static void OrderHistory()
        {
            foreach(OrderDetails orderstatus in orderList)
            {
                if(currentuser.CustomerID==orderstatus.CustomerID)
                {
                    Console.WriteLine($"--------------------------------------------------------------------------------");
                    
                    Console.WriteLine($"--------------{currentuser.CustomerID}---DETAILS--------------\n");
                    
                    Console.WriteLine($"OrderID :{orderstatus.OrderID} \nCustomerId: {orderstatus.CustomerID} \nproduct Id{orderstatus.ProductID} \nTotalPrice :{orderstatus.TotalPrice} \npurchase date :{orderstatus.PurchaseDate} \nQuantity{orderstatus.Quantity} \nOrderstatus{orderstatus.OrderStatus} \n");
                     
                    Console.WriteLine($"----------------------------------------------------------------------");
                    
                }
            }
        }

        public static void CancelOrder()
        {
               OrderHistory();
               Console.WriteLine($"Enter you OrderID");
               string orderid=Console.ReadLine();
               
               foreach(OrderDetails orderupdate in orderList)
               {
                if(orderid==orderupdate.OrderID)
                {
                    orderupdate.OrderStatus=OrderStatus.Canceled;
                    currentuser.WalletBalance=currentuser.WalletBalance+((orderupdate.TotalPrice)-500);
                    foreach(ProductDetails productupdate in productList)
                    {
                            if(productupdate.ProductID==orderupdate.ProductID)
                            {
                                productupdate.Stock++;
                            }
                    
                    }
                    
                }
                
                
               }
               
            Console.WriteLine($"you order successfully cancel \nNow your WalletBalanceupdated: {currentuser.WalletBalance}");
            Console.WriteLine($"Service charge RS.500 was not applicable to refund");
            Console.WriteLine($"--------------------THANK YOU---------------------");
            
            
               
        }

        public static void WalletBalanceRecharge()
        {
         Console.WriteLine($"----------------------------------");
        
            
        Console.WriteLine($"YOUR CURRENT AVALIBLE BALANCE");
        Console.WriteLine($"{currentuser.WalletBalance}");
         
        Console.WriteLine($"----------------------------------");   
               
            
         Console.WriteLine($"Do you want to recharge your Wallet");
         string check=Console.ReadLine();
         if(check=="yes")
         {
            Console.WriteLine($"Enter your Recharge amount");
            double amount=Convert.ToDouble(Console.ReadLine());
            currentuser.WalletBalance=currentuser.WalletBalance+amount;
            
         }
     
         Console.WriteLine($"Your amount successfully added");
         Console.WriteLine($"Yourcurrent Balance{currentuser.WalletBalance}");
         
         
         
        }
        public static void DefaultSetup()
        {
          // customer Default
          CustomerDetails customerFirst =new CustomerDetails("guru","rajapalayam",9894999231,50000,"guru@mail.com");
          customerList.Add(customerFirst);
          CustomerDetails customerSecond =new CustomerDetails("prakash","rajapalayam",9894999231,30000,"prakash@mail.com");
          customerList.Add(customerSecond);
          // product Default
          ProductDetails productFirst=new ProductDetails("Mobile",10000,10,3);
          productList.Add(productFirst);
          ProductDetails productSecond=new ProductDetails("Tablet",15000,5,2);
          productList.Add(productSecond);
          ProductDetails productThird=new ProductDetails("Camera",20000,3,4);
          productList.Add(productThird);
          ProductDetails productFourth=new ProductDetails("iphone",50000,5,6);
          productList.Add(productFourth);
          ProductDetails productFifth=new ProductDetails("Laptop",40000,4,3);
          productList.Add(productFifth);
         //order default
          OrderDetails orderFirst=new OrderDetails("CID1001","PID101",20000,DateTime.Now,2,OrderStatus.Ordered);
          orderList.Add(orderFirst);
          OrderDetails orderSecond=new OrderDetails("CID1002","PID102",40000,DateTime.Now,2,OrderStatus.Ordered);
          orderList.Add(orderSecond);
          


        }
    }
}