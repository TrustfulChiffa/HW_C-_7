// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


//Пусть в примере 17 это 1 - строка, 7 - столбец
//Программа на вход принимает только позицию элемента, поэтому значение элементов и размерность массива зададим рандомно


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

void PrintArray(int[,] array)
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

int linesSizeOfArray = new Random().Next(2, 11);
int columnsSizeOfArray = new Random().Next(2, 11); // минимальное ограничение 2, чтобы массив в любом случае был двумерным

int[,] array = CreateArray(linesSizeOfArray, columnsSizeOfArray);

Console.Clear();

Console.Write("Введите строку искомого элемента: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите столбец искомого элемента: ");
int j = Convert.ToInt32(Console.ReadLine());

Console.Clear();

PrintArray(array);

if (i <= linesSizeOfArray && j <= columnsSizeOfArray)
{
    Console.Write($"{i}{j} -> {array[i - 1, j - 1]}");
}
else
{
    Console.Write($"{i}{j} -> такого числа в массиве нет");
}