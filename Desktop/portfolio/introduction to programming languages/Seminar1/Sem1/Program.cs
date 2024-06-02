// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.WriteLine("input first number: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x == y * y)
// {
//     Console.WriteLine($"x = {x}, y = {y} -> yes");
// }
// else
// {
//     Console.WriteLine($"x = {x}, y = {y} -> no");
// }


// Console.WriteLine("input number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int start = -n;
// while(start <= n)
// {
//     System.Console.Write(start + " ");
//     start++;
// } 


using System.Diagnostics.CodeAnalysis;

Console.WriteLine("input number: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x > 99 && x <1000)
{
    int num1 = x / 100;
    int num2 = x % 10;
    Console.WriteLine("sum =" + (num1 + num2));
}
else
{
    Console.WriteLine("not three-digit number");
}
