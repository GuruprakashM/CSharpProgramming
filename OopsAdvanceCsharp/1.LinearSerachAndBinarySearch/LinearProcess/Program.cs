using  System;
namespace LinearProcess
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Program pro =new Program();
            pro.IntLinear();
            pro.CharLinear();
            pro.StringLinear();
        }
        public void IntLinear()
        {
            Console.WriteLine($"Enter the value");
            int value=int.Parse(Console.ReadLine());
            int[] array={1,2,3,4,5,6,7,8,9};
            int count=0;
            for(int output=0; output<array.Length; output++)
            {
                if(value==array[output])
                {
                    count++;
                    Console.WriteLine($"The number {value} is avalible index position {output}");
                    
                }
            }
            if(count==0)
            {
                Console.WriteLine($"The number is {value} is not available");
                
            }
        }
        public void CharLinear()
        {
            Console.WriteLine($"Enter the char");
            char value=char.Parse(Console.ReadLine());
            char[] array={'A','B','C','a','b','c'};
            int count=0;
            for(int output=0; output<array.Length; output++)
            {
                if(value==array[output])
                {
                    count++;
                    Console.WriteLine($"The number {value} is avalible index position {output}");
                    
                }
            }
            if(count==0)
            {
                Console.WriteLine($"The number is {value} is not available");
                
            }
        }
     public void StringLinear()
        {
            Console.WriteLine($"Enter the char");
           string value=Console.ReadLine();
            string[] array={"Apple","Orange","banana","grape"};
            int count=0;
            for(int output=0; output<=array.Length-1; output++)
            {
                if(value==array[output])
                {
                    count++;
                    Console.WriteLine($"The number {value} is avalible index position {output}");
                    
                }
            }
            if(count==0)
            {
                Console.WriteLine($"The number is {value} is not available");
                
            }
        }

    }
}