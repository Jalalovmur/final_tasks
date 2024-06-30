// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void PrintNumbers(int m, int n)
{
    if (m == n)
    {
        Console.Write(n + " ");
    }
    if(m < n)
    {
        PrintNumbers(m, n - 1);
        Console.Write(n + " ");
    }
}

Console.WriteLine("Input first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumbers(m ,n);




