// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”


// string CharsToString(char[] chars)
// {
//     string result = string.Empty;
//     for (int i = 0; i < chars.Length; i++)
//     {
//         result = result + chars[i];
//     }
//     return result;
// }

// char[] chars = {'a', 'b', 'c', 'd'};

// Console.WriteLine(CharsToString(chars));







// Задание 2. Работа в сессионных залах
// Семинар 6. Массивы и строки
// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

// char[] StringToChars(string str)
// {
//     char[] result = new char[str.Length];
//     for (int i = 0; i < str.Length; i++)
//         {
//             result[i] = str[i];
//         }
//     return result;
// }

// void PrintArray(char[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write("'" + array[i] + "' " );
//     }
//     System.Console.WriteLine("");
// }

// PrintArray(StringToChars("abcdef"));






// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int VowelsCount(string str)
{
    str = str.ToLower();
    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
    int vowelCount = 0;
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (str[i] == vowels[j])
            {
                vowelCount++;
                break;
            }
        }
    }
    return vowelCount;
}

Console.WriteLine("Введите строку из латинских букв в нижнем регистре:");
string str = Console.ReadLine();

Console.WriteLine($"Количество гласных букв: {VowelsCount(str)}");