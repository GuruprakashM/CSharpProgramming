
using System;
namespace StudentDetails 
{
class Program 
{
    public static void Main(string[] args)
    {
       string studentName,fatherName,mailId,gender;
       long phoneNumber;
       int age,chemistryMark, mathsMark,physicsMark,total;
       float Average,Percentage;
       Console.WriteLine("Enter your name");
       studentName=Console.ReadLine();
       Console.WriteLine("Enter your fathername");
       fatherName=Console.ReadLine();
       Console.WriteLine("Enter your Mailid");
       mailId=Console.ReadLine();
       Console.WriteLine("Enter your Gender");
       gender=Console.ReadLine();
       Console.WriteLine("Enter your phonenumber");
       phoneNumber=long.Parse(Console.ReadLine());
       Console.WriteLine("Enter your age");
       age=Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter your Chemistrymark");
       chemistryMark=Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter your Mathsmark");
       mathsMark=Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter your Physicsmark");
       physicsMark=Convert.ToInt32(Console.ReadLine());
       total=chemistryMark+mathsMark+physicsMark;
       Average=(float)total/3f;
       Percentage=(float)((total/600.0)*100.0);
       Console.WriteLine($"your name{studentName}\nyour father name {fatherName}\n yourmaild {mailId} \n your gender{gender} \n your phonenumber{phoneNumber}\n your age{age}");
       Console.WriteLine($"your mark in avg:{Average}\n your mark in percentage:{Percentage}% ");
    }
}
}
