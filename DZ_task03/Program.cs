// 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)  // ПЕЧАТЬ
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "   ");
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

int m = 3, n = 4; // m - сторка, n - столбец

int[,] mass = new int[m, n];
FillArray(mass);
Print(mass);
Console.WriteLine();

for (int i = 0; i < mass.GetLength(1); i++) // строки
{
    double avg = 0;
    for (int j = 0; j < mass.GetLength(0); j++) // столбцы
    {
        avg += mass[j, i];
    }
    Console.Write($" {Math.Round(avg = avg / mass.GetLength(0), 1)} ");
}
