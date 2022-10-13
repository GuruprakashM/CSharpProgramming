using System;
namespace StackDS
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Stack<string> stacks = new Stack<string>();
            stacks.Push("guru");
            stacks.Pop();
            stacks.Contains("g");
            stacks.peek();
        }
    }
}