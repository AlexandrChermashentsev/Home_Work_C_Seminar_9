/*
Задача 64: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> 5, 4, 3, 2, 1
N = 8 -> 8, 7, 6, 5, 4, 3, 2, 1
*/

int EnterNumber(string msg)
{
    Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

string PrintNumbers(int n) 
{
    if (n > 0)
    {
        if (n >= 2) return $"{n}, " + PrintNumbers(n - 1);
        if (n == 1) return $"{n}";
        else return string.Empty;
    }
    else if (n < 0)
    {
        if (n <= -2) return $"{n}, " + PrintNumbers(n + 1);
        if (n == -1) return $"{n}";
        else return string.Empty;
    }
    else return $"{n}";
}

int n = EnterNumber("Enter the number");
Console.WriteLine($"N = {n} -> {PrintNumbers(n)}");