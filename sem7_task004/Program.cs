// 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

void Print(int[,] arr)
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

/* Console.Write("Введите количество сторк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] mass = new int[m, n];

FillArray(mass);
Print(mass);
Console.WriteLine();

int sum = 0;
for (int i = 0; i < mass.GetLength(0); i++) // 0 - столбцы ГЕНЕРАЦИЯ
{
    for (int j = 0; j < mass.GetLength(1); j++) // 1 - строки
    {
        if ( i == j)
        sum = sum + mass[i, j];
    }    
}
Console.Write("Сумма элементов главной диагонали: " + sum); */
int Digsum (int[,] arr3)
{
    int sum = 0;
    int minSize = Math.Min(arr3.GetLength(0), arr3.GetLength(1));
    for (int i = 0; i < minSize; i++)
    {
        sum = sum + arr3[i, i];
    }
    return sum;
}
Console.Write("Введите количество сторк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] mass = new int[m, n];

FillArray(mass);
Print(mass);
Console.WriteLine();
Digsum(mass);
Console.Write("Сумма элементов главной диагонали: " + Digsum(mass));
