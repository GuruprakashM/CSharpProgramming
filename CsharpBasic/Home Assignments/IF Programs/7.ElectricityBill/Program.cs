using System;
namespace ElectricityBill
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int customerId,consumeUnits;
            Console.WriteLine($"Enter your name");
            string name=Console.ReadLine();
            Console.WriteLine($"Enter your Id");
            customerId=int.Parse(Console.ReadLine());
            Console.WriteLine($"Your consuming units details");
            consumeUnits=int.Parse(Console.ReadLine());
            double unitCharges=0;
            Console.WriteLine($"-------------------------------------");
            
            Console.WriteLine($"your id:{customerId} \nyour Name:{name} \nyour consumeunits:{consumeUnits}");
            
            if(consumeUnits>=0  && consumeUnits<199)
            {
                unitCharges=consumeUnits*1.20;
                Console.WriteLine($"Amount chargerd {consumeUnits}units @1.20 perunit Rs.{unitCharges}");
                
            }
             
            else if(consumeUnits>=200 && consumeUnits<400) 
            {
                unitCharges=consumeUnits*1.50;
                Console.WriteLine($"Amount chargerd {consumeUnits}units @1.50 perunit Rs.{unitCharges}");
            }
            else if(consumeUnits>=400 && consumeUnits<600) 
            {
                unitCharges=consumeUnits*1.80;
                Console.WriteLine($"Amount chargerd {consumeUnits}units @1.80 perunit Rs.{unitCharges}");
            }
            else 
            {
                unitCharges=consumeUnits*2.0;
                Console.WriteLine($"Amount chargerd {consumeUnits}units @2.0 perunit Rs.{unitCharges}");
            }     
            if(unitCharges>400)
            {
                Console.WriteLine($"you need to pay  surcharge for that");
                double surcharge=(unitCharges*0.15);
                unitCharges+=surcharge;
                Console.WriteLine($"--------------------------------------");
                
                Console.WriteLine($"surcharge: Rs.{surcharge} \n Total net Pay: Rs.{unitCharges}");    
            }
            Console.WriteLine($"Thank You visit again!!!!!!");
            
       }
            
    }
}

