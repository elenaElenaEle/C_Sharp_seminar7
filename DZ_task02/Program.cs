// 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)  // ПЕЧАТЬ
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] arr2)
{
    for (int i = 0; i < arr2.GetLength(0); i++) // 0 - столбцы ГЕНЕРАЦИЯ
    {
        for (int j = 0; j < arr2.GetLength(1); j++) // 1 - строки
        {
            arr2[i, j] = new Random().Next(0, 10);
        }
    }
}

int m = 5, n = 7; // m - сторка, n - столбец
int[,] mass = new int[m, n];

FillArray(mass);
Print(mass);
Console.WriteLine();

Console.Write("Введите позицию строки искомого элемента: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите позицию столбца искомого элемента: ");
int y = int.Parse(Console.ReadLine());

for (int k = 0; k < mass.Length; k++)
{
    for (int l = 0; l < mass.Length; l++)
    {
        if (x <= (mass.GetLength(0) - 1)  && y <= (mass.GetLength(1)-1))
        {
            Console.Write(mass[x, y]);
        }
        else 
        {
            Console.Write("Такого числа нет в массиве");
        }
        break;
    }
    break;
}