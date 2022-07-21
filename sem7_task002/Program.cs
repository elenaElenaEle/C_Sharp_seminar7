// 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится
//  по формуле: Aₙₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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

Console.Write("Введите количество сторк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++) // 0 - столбцы ГЕНЕРАЦИЯ
{
    for (int j = 0; j < mass.GetLength(1); j++) // 1 - строки
    {
        mass[i, j] = i + j;
    }
}

Print(mass);
