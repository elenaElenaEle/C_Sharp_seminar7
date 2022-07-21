// 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.    
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
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

int m = 3, n = 4;
int[,] mass = new int[m, n];
Print(mass);
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++) // 0 - столбцы ГЕНЕРАЦИЯ
{
    for (int j = 0; j < mass.GetLength(1); j++) // 1 - строки
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}

Print(mass);
