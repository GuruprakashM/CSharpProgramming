using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethod
{
    public class Poppy:Dog
    {
        public override void MakeSound()
        {
            Console.WriteLine($"Make Sounds by puppy");
            
        }
    }
}