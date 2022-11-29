/*
Задача 68: Напишите программу вычесления функции Аккермана,
с помощью рекурсии. Даны два неотрицаетльных числа а и b.
m = 2, n = 3 -> A(m, n) = 9;
m = 3, n = 2 -> A(m, n) = 29;
*/

double GetNumber(string message)
{
    Console.WriteLine(message);
    double number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double AkkermansFunction(double m, double n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AkkermansFunction(m - 1, 1);
    else return AkkermansFunction(m - 1, AkkermansFunction(m, n - 1));
}

double numberM = GetNumber("Enter number M > 0");
double numberN = GetNumber("Enter number N > 0");
if (numberM >= 0 && numberN >= 0)
{
    double FunctionOfAkkerman = AkkermansFunction(numberM, numberN);
    Console.WriteLine($"Akkerman Function = {AkkermansFunction(numberM, numberN)}");
}
else Console.WriteLine("Введенное число не должно быть отрицательным");