bool Multiple(int n)
{
    if (n % 7 == 0 && n % 23 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

System.Console.WriteLine ("Input number: " );
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine (Multiple(a));
