using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethod
{
    public class Dog:Animal
    {
        public  new void MakeSound()
        {
            Console.WriteLine($"Make Sound by Dog");
            
        }
    }
}