using System;
namespace ListDS 
{
    class Program
    {
        public static void Main(string[] args)
        {
           List<int> datas = new List<int>();
          
           datas.AddElement(10);
           datas.AddElement(20);
           datas.AddElement(30);
           datas.AddElement(40);
           datas.AddElement(50);
           datas.Insert(2,70);
           datas.removeAt(2);
           datas.remove(50);
         Console.WriteLine($"---1---");
         
          foreach (var data in datas)
          {
              Console.WriteLine($"{data}");
              
          }
          Console.WriteLine($"----2---");
          
          for( int i=0; i<datas.Count; i++)
          {
            Console.WriteLine($"{datas[i]}");
            
          }
        }
    }
}