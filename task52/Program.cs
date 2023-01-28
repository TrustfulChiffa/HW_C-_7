// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray(int lines, int columns)
{
    int[,] array = new int[lines, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10); //ограничение согласно примеру
        }
    }
    return array;
}

void Print2DArray(int[,] array)
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

void Print1DArray(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {

        Console.Write($"{Math.Round(array[i], 1)}; ");
    }
    Console.Write($"{Math.Round(array[array.Length - 1], 1)}.");
}

double[] AverageOfEachColumn(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        average[j] = sum / array.GetLength(0);
    }

    return average;
}

// минимальное ограничение 2, чтобы массив в любом случае был двумерным
int linesSizeOfArray = new Random().Next(2, 11);
int columnsSizeOfArray = new Random().Next(2, 11);

int[,] array = CreateArray(linesSizeOfArray, columnsSizeOfArray);

Print2DArray(array);

Console.Write("Среднее арифметическое каждого столбца: ");

double[] averageArray = AverageOfEachColumn(array);

Print1DArray(averageArray);