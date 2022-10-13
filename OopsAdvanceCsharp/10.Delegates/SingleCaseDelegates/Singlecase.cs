using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleCaseDelegates
{
    public delegate int Calculator(int n);
    public static class Singlecase
    {
       
            public static int value=10;
            public static int  AddNum(int number) {value +=number; return value;}
            public static int MulNum(int number ){value *=number ; return value;}
            public static int GetNum()
            {
                return value;
            }
            public static void MainMenu()
            {
                Calculator nc1= new Calculator(AddNum);
                Calculator nc2 = new Calculator(MulNum);
                nc1(25);
                Console.WriteLine($"Value of Num 0:  {GetNum()}");
                
                nc2(20);
                Console.WriteLine($"Value of Num 0 : {GetNum()}");
            }
    }
}