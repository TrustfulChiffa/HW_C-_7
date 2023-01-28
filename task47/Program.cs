// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


double[,] RandomDouble2DeArray(int lines, int columns)
{
    int[,] integerArray = new int[lines, columns];

    for (int i = 0; i < integerArray.GetLength(0); i++)
    {
        for (int j = 0; j < integerArray.GetLength(1); j++)
        {
            integerArray[i, j] = new Random().Next(-99, 100);
        }
    }

    double[,] realNumbersArray = new double[integerArray.GetLength(0), integerArray.GetLength(1)];
    for (int i = 0; i < integerArray.GetLength(0); i++)
    {
        for (int j = 0; j < integerArray.GetLength(1); j++)
        {
            realNumbersArray[i, j] = Convert.ToDouble(integerArray[i, j]) / 10;
        }
    }
    return realNumbersArray;
}

void PrintRealNumbersArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine(String.Empty);

    }
}

Console.Clear();

Console.Write("Введите количество строк(m) массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов(n) массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();

double[,] array = RandomDouble2DeArray(m, n);

Console.WriteLine($"m = {m}, n = {n}.");

PrintRealNumbersArray(array);