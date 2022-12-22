// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите размерность массива");
Console.Write("Введите  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваш массив: ");
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
       
         Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

void ItemPosition(int[,]matrix)
{
    Console.WriteLine("Введите координаты позиции элемента в двумерном массиве");
    Console.Write($"Введите  номер строки: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите  номер столбца: ");
    int N = Convert.ToInt32(Console.ReadLine());
    if (M > matrix.GetLength(0)|| N > matrix.GetLength(1) ) 
    {
        Console.WriteLine("Такого числа в массиве нет");
        Console.ResetColor() ;
        return;
    }

    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++)
    {
       
       if(i == (M-1) && j == (N-1)) Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(matrix[i, j] + " ");
        if(i == (M-1) && j == (N-1)) Console.ResetColor();
    }
    Console.WriteLine();
    }

return;
}

ItemPosition(matrix);