using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAssembly 
{
    public class Second: First
    {
        public int protectedvalue{get{return FourthNum;}}
    }
}