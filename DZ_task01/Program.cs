// 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9

void Print(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)  // ПЕЧАТЬ
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            //Console.Write(i + " " + j + ", ");
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] arr2)
{
    for (int i = 0; i < arr2.GetLength(0); i++) // 0 - столбцы ГЕНЕРАЦИЯ
    {
        for (int j = 0; j < arr2.GetLength(1); j++) // 1 - строки
        {
            arr2[i, j] = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 2);
        }
    }
}

Console.Write("Введите количество сторк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

double[,] mass = new double[m, n];

FillArray(mass);
Print(mass);
Console.WriteLine();
