using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceProcess
{
    public class ProductDetails
    {
        //ProductDetails
        public static int  s_productID=100;
        public string ProductID{get;set;}
        public string ProductName{get;set;}

        public double ProductPrize{get;set;}
        public int Stock { get; set; }
        public int ShippingDuration { get; set; }
        
        public ProductDetails(string productName,double productPrize, int stock,int shippingDuration)
        {
            s_productID++;
            ProductID="PID"+s_productID;
            ProductName=productName;
            ProductPrize=productPrize;
            Stock=stock;
            ShippingDuration=shippingDuration;
        }

        public ProductDetails(string pass2)
        {
            string[] values=pass2.Split(",");
            s_productID=int.Parse(values[0].Remove(0,3));
            ProductID=values[0];
            ProductName=values[1];
            ProductPrize=double.Parse(values[2]);
           Stock=int.Parse(values[3]);
           ShippingDuration=int.Parse(values[4]);
        }
        
        
    }
}