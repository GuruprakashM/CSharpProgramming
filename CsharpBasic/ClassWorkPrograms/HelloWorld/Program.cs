// See https://aka.ms/new-console-template for more information
int a;
a=Convert.ToInt32(Console.ReadLine());
int[] b=new int[a-5];

for(int i=0; i<a; i++)
{
    Console.WriteLine(i);
}
for(int i=0; i<b.Length; i++)
{
    b[i]=Convert.ToInt32(Console.ReadLine());
}
foreach(int i in b)
{
    Console.WriteLine(i);
}