// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [m,n];
for(int i = 0; i < m; i++)
{
for(int j = 0; j < n; j++)
{
    Random rand = new Random();
    matrix[i,j] = Math.Round(rand.Next(0, 11) + rand.NextDouble(), 2);
    Console.Write("{0,7}", matrix[i,j] + " ");
}
Console.WriteLine();
}