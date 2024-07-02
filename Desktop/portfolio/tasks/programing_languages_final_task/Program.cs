// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// void PrintNumbers(int m, int n)
// {
//     if (m == n)
//     {
//         Console.Write(n + " ");
//     }
//     if(m < n)
//     {
//         PrintNumbers(m, n - 1);
//         Console.Write(n + " ");
//     }
// }

// Console.WriteLine("Input first number: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// PrintNumbers(m ,n);




// // Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// // Даны два неотрицательных числа m и n.

// int AckermannFunction(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (m > 0 && n == 0)
//     {
//         return AckermannFunction(m - 1, 1);
//     }
//     else
//     {
//         return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//     }
// }

// int m = 3;
// int n = 2;
// Console.Write(AckermannFunction(m, n));






// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// void PrintElementsOfArray(int[] array, int i)
// {
//     if(i == 0)
//     {
//         Console.Write(array[i] + " ");
//     } 
//     else if(i > 0)
//     {
//         Console.Write(array[i] + " ");
//         PrintElementsOfArray(array, i - 1);
//     }
// }

// int[] array = {1, 2, 3};
// int i = array.Length - 1;
// PrintElementsOfArray(array, i);


