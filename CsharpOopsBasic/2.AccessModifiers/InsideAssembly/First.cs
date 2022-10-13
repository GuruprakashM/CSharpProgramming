using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OutsideAssembly;
namespace InsideAssembly
{
    public class First:Third
    {
        public int publicNumber=10;
        private int secondNum=10;
        public int SecondNum{get{return secondNum;}}
        internal int ThirdNUm=20;
        protected int FourthNum=30;
        public int showprotected{get{return protectedvalue2;}}
        
    }
}