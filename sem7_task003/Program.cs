// 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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

Console.Write("Введите количество сторк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] mass = new int[m, n];

FillArray(mass);
Print(mass);
Console.WriteLine();

/* for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            mass[i, j] = mass[i, j] * mass[i, j];
        }
    }
} */

for (int i = 0; i < mass.GetLength(0); i += 2)
{
    for (int j = 0; j < mass.GetLength(1); j += 2)
    {

        mass[i, j] = mass[i, j] * mass[i, j];
    }
}
Print(mass);
