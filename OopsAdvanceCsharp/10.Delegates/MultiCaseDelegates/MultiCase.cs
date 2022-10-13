using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiCaseDelegates 
{
    public delegate int Calculator(int n);
    public static class MultiCase
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
                Calculator nc;
                Calculator nc1= new Calculator(AddNum);
                Calculator nc2 = new Calculator(MulNum);
                 nc =nc1;
                 nc+=nc2;
                 nc(5);
                Console.WriteLine($"Value of Num 0 : {GetNum()}");
            }
    }
}
    