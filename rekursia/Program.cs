// Рекурсия

int Rec (int num)
{
    if (num <= 0)
    {
        return 1; // прекращение вызова функции
    }
    /* Console.WriteLine("Рекурсия!");
    Rec (num - 1); */
    return Rec(num - 1) * 2;
}
Console.WriteLine(Rec (4));
