using System;


namespace DictionaryDs
{
    class Program 
    {
        public static void Main(string[] args)
        {
           
          Dictionary<int,string> keypair = new Dictionary<int, string>();
          keypair.Add(1,"guru");
          keypair.Add(1,"Raj");
          keypair.Add(2,"ram");
          keypair.Add(3,"prakash");
          keypair.Add(4,"ramprakash");
          Console.WriteLine(keypair.Containskey(1));
          Console.WriteLine(keypair.ContainsValue("ram"));
          KeyValue<int,string> temp=  keypair.ElementAt(1);
          Console.WriteLine(temp.key + "   "+temp.value);
          Console.WriteLine(keypair.Remove(3));
       
           
        }
    }
}