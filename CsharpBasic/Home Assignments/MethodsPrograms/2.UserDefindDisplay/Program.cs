using System;
namespace UserDefindDisplay 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            UserDefine();
            Console.WriteLine($"-----------------");
            
            Console.WriteLine($"{userDefine()}");
            
            void UserDefine()
            {
                Console.WriteLine($"Welcome Friends \nHave a nice Day");
                
            }
            string userDefine()
            {
                string messsage="Welcome Friends \nHave a noice day";
                return messsage;
            }
        }
    }
}