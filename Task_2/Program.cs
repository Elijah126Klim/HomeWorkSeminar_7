// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// n = 3, m = 2 -> A(m,n) = 29
// n = 3, m = 11 -> A(m,n) = 16381

int FunctOfAkkerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    if (m == 0)
    {
        return FunctOfAkkerman(n - 1, 1);
    }
    return FunctOfAkkerman(n - 1, FunctOfAkkerman(n, m - 1));
}

int functionOfAkkerman = FunctOfAkkerman(3, 11);
Console.WriteLine(functionOfAkkerman);