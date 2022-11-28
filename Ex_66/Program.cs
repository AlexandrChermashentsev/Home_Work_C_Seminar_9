/*
Задача 66: Задайте значения М и N.
Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.
M = 1, N = 15 -> 120
M = 4, N = 8 -> 30
*/

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SummNumbers(int m, int n)
{
    int summ = 0;
    if (m <= n) return summ = m + SummNumbers(m + 1, n);
    else return summ; 
}

int m = GetNumber("Enter M");
int n = GetNumber("Enter N");

int summ = SummNumbers(m, n);
Console.WriteLine(summ);