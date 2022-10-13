using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceProcess
{
    public enum OrderStatus {Default,Ordered,Canceled}
    public class OrderDetails
    {
        //OrderDetails
        private static int s_orderID=1000;
        public string OrderID { get; set; }
        public string CustomerID { get; set; }
        public string ProductID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Quantity { get; set; }
        
        public OrderStatus OrderStatus{get;set;}
        
    public OrderDetails(string customerID, String productID,double totalPrice, DateTime purchaseDate,int quantity,OrderStatus orderStatus)
    {

        s_orderID++;
        OrderID="OID"+s_orderID;
        CustomerID=customerID;
        ProductID=productID;
        TotalPrice=totalPrice;
        PurchaseDate=purchaseDate;
        Quantity=quantity;
        OrderStatus=orderStatus;

    }        
        
        
        
        
        
                
        
    }
}