using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class Draw:IRectangle
    {
        public int Area { get; set; }
        public int Length{get; set;}
        public int Width { get; set; }
        
        public void GetData(int length,int width)
        {
            Length=length;
            Width=width;
        }
        public void CalcualteArea()
        {
            
            Area=Length*Width;
            Console.WriteLine($"The Area is {Area}");
            
        }

    }
}