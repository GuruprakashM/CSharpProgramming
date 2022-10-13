using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Syncfusion:AbstractBase
    {
        public override string Name {get{return name;} set{name=value;}}
        public override void Salary(int dates)
        {
             Display();
             Amount=(double)dates*500;
             Console.WriteLine($"{Amount}");
             
        }
    }
}