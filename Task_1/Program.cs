// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


int ReadInput(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int M = ReadInput("Введите натуральное число: ");
int N = ReadInput("Введите натуральное число: ");

void PrintNaturalEvenNums(int M, int N)
{
    if (M > N) return;
    if (M % 2 == 0)
    {
        System.Console.WriteLine(M);
    }
    PrintNaturalEvenNums(M+1, N);
}

PrintNaturalEvenNums(M, N);

