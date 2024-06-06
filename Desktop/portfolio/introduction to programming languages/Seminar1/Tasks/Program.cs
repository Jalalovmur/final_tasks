// bool Multiple(int n)
// {
//     if (n % 7 == 0 && n % 23 == 0)
//     {
//         return true;
//     }
//     return false;
// }

// System.Console.WriteLine ("Input number: " );
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine (Multiple(a));




// bool NotZero (int x, int y)
// {
//     if (x != 0 && y != 0)
//     {
//        return true;
//     }
//     return false;
// }

// void Coordinate(int x, int y)
// {
//     if (NotZero(x, y))
//     {
//         if (x > 0 && y > 0)
//         {
//             Console.WriteLine("first quarter");

//         }
//         if (x < 0 && y > 0)
//         {
//             Console.WriteLine("second quarter");
//         }
//         if (x < 0 && y < 0)
//         {
//             Console.WriteLine("third quarter");
//         }
//         if (x > 0 && y < 0)
//         {
//             Console.WriteLine("forth quarter");
//         }
//     }
//     else
//     {
//         Console.WriteLine("x and y equalize to zero");
//     }
// }

// Console.WriteLine("input first number: " );
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number: " );
// int b = Convert.ToInt32(Console.ReadLine());
// Coordinate(a, b);



using System.Globalization;

bool Limit (int x)
{
    if (x >= 10 && x <=99)
    {
       return true;
    }
    return false;
}

void MaxOfTwoNumbers(int x)
{
    if (Limit (x))
    {
        int a = x / 10;
        int b = x % 10;  
        if(a > b)
        {
            Console.WriteLine(a);
        }
        if(a == b)
        {
            Console.WriteLine("the numbers are equal");
        }
        else
        {
            Console.WriteLine(b);
        }
    }
    else 
    {
        Console.WriteLine("number is out of the limit");
    }
}

Console.WriteLine("input number: " );
int c = Convert.ToInt32(Console.ReadLine());
MaxOfTwoNumbers(c);