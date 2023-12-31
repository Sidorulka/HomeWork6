﻿// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int ReadInput(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int M = ReadInput("Введите неотрицательное число: ");
int N = ReadInput("Введите неотрицательное число: ");

int FunAckermann(int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0) return FunAckermann(M - 1, 1);
    else return FunAckermann(M - 1, FunAckermann(M, N - 1));
}

System.Console.WriteLine($"Функция Аккермана равна {FunAckermann(M, N)}");