// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

System.Console.WriteLine("Enter rows number");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter columns number");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] GetDoubleArray(int m, int n){
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(-100, 100)/ 10.0;
        }
    }
    return result;
}

double[,] arr = GetDoubleArray(rows, columns);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        System.Console.Write($"{arr[i,j]} ");
    }
    System.Console.WriteLine();
}


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// вводим позиции по i и j -> если таких нет - выводим, что позиции не существует. 
// Если есть - выводим элемент по этим индексам.

int[,] array2D = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        System.Console.Write($"{array2D[i, j]} ");
    }
    System.Console.WriteLine();
}

void GetElementOfIndexes(int i, int j)
{
    if (i > array2D.GetLength(0) || j > array2D.GetLength(1))
    {
        System.Console.WriteLine("Позиция не существует в массиве");
    }
    else
        System.Console.WriteLine($"Элемент по индексам i={i}, j={j}: {array2D[i, j]}");
}

GetElementOfIndexes(4, 1);



// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



void GetAverageColumns(int[,] array)
{
    int[] sumColumns = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
             sumColumns[i] += array[j,i];
        }
    }
    foreach (double item in sumColumns)
    {
        System.Console.Write($"{Math.Round(item/array.GetLength(0), 3)} ");
    }
}

GetAverageColumns(array2D);
