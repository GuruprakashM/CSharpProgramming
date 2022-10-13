using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperatorOverLoading
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box()
        {

        }
       public Box(double length1, double width1, double height2)
        
        {
                 length=length1;
                 width=width1;
                 height=height2;
        }

         public double CalcualteVolume()
         {
            return length*width*height;
         }

      /// <summary>
      /// Here operator is the just keyword
      /// </summary>
      /// <param name="box1"></param>
      /// <param name="box2"></param>
      /// <returns></returns>
         public static Box operator +(Box box1,Box box2)
            {
                 
                 Box box =new Box();
                 box.length =box1.length +box2.length;
                 box.width=box1.length+box2.width;
                 box.height=box1.height+box2.height;

                return box;
            }
    }
}