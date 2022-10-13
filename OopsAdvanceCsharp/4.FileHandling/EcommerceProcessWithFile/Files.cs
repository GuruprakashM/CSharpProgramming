using System;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace EcommerceProcess
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("Ecommerce"))
            {
                Console.WriteLine($"New Folder Created");
                
                Directory.CreateDirectory("Ecommerce");

            }
            else 
            {
                Console.WriteLine($"Folder is already exist");
                
            }
            
            
            if(!File.Exists("Ecommerce/CustomerDetails.csv"))
            {
               Console.WriteLine($"File creating");
               File.Create("Ecommerce/CustomerDetails.csv");
            }
            if(!File.Exists("Ecommerce/OrderDetails.csv"))
            {
               Console.WriteLine($"File creating");
               File.Create("Ecommerce/OrderDetails.csv");
            }
            if(!File.Exists("Ecommerce/ProductDetails.csv"))
            {
               Console.WriteLine($"File creating");
               File.Create("Ecommerce/ProductDetails.csv");
            }
        }
        public static void ReadFile()
        {
            string[] customers = File.ReadAllLines("Ecommerce/CustomerDetails.csv");
            foreach( var pass in customers)
            {
                CustomerDetails customer = new CustomerDetails(pass);
                Opreation.customerList.Add(customer);
            }

            string[] orders = File.ReadAllLines("Ecommerce/OrderDetails.csv");
            foreach( var pass1 in orders)
            {
                OrderDetails order= new OrderDetails(pass1);
                Opreation.orderList.Add(order);
            }

            string[] products = File.ReadAllLines("Ecommerce/ProductDetails.csv");
            foreach (var pass2 in products)
            {
                ProductDetails product= new ProductDetails(pass2);
                Opreation.productList.Add(product);

            }
        } 
        public static void WriteFile()
        {
            int count1=Opreation.customerList.Count;
            string[] write1 = new string[count1];
            for(int output =0; output<count1; output++ )
            {
                write1[output]=Opreation.customerList[output].CustomerID+","+Opreation.customerList[output].CustomerName+","+Opreation.customerList[output].City+","+Opreation.customerList[output].MobileNumber+","+Opreation.customerList[output].WalletBalance+","+Opreation.customerList[output].EmailID;
            }
           File.WriteAllLines("Ecommerce/CustomerDetails.csv",write1);

            int count2=Opreation.orderList.Count;
            string[] write2 = new string[count2];
            for(int output =0; output<count2; output++ )
            {
               write2[output]=Opreation.orderList[output].OrderID+","+Opreation.orderList[output].CustomerID+","+Opreation.orderList[output].ProductID+","+Opreation.orderList[output].TotalPrice+","+Opreation.orderList[output].PurchaseDate.ToString("dd/MM/yyyy")+","+Opreation.orderList[output].Quantity+","+Opreation.orderList[output].OrderStatus;
            }
           File.WriteAllLines("Ecommerce/OrderDetails.csv",write2);

           int Count3=Opreation.productList.Count;
           string[] write3 = new string[Count3];

           for(int output=0; output<Count3; output++)

           {
             write3[output]=Opreation.productList[output].ProductID+","+Opreation.productList[output].ProductName+","+Opreation.productList[output].ProductPrize+","+Opreation.productList[output].Stock+","+Opreation.productList[output].ShippingDuration;
           }
          File.WriteAllLines("Ecommerce/ProductDetails.csv",write3);
       }
    } 
}

 /*string[] values=data3.Split(",");
            s_productID=int.Parse(values[0].Remove(0,3));
            ProductID=values[0];
            ProductName=values[1];
            ProductPrize=double.Parse(values[2]);
           Stock=int.Parse(values[3]);
           ShippingDuration=int.Parse(values[4]);*/
 