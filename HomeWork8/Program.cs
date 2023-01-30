// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение элемента: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение элемента: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortElementsInRows(int[,] array)
{
    for (int k = array.GetLength(1) - 1; k > 0; k--)
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < k; j++)
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
}
    
int[,] array = CreateRandom2dArray();
Show2dArray(array);
SortElementsInRows(array);
Show2dArray(array);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов (например "1 строка" с т.з. пользователя).
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение элемента: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение элемента: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(min, max + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + " ");
            Console.WriteLine();
        }
    Console.WriteLine();
}

int SearchMinSumInRow(int[,] array)
{
    int minSum = 0;
    int numRow = 0;
    for(int i = 0, j = 0; j < array.GetLength(1); j++) 
        minSum = minSum + array[i, j];

    for(int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        if(sum < minSum) 
        {
            minSum = sum;
            numRow = i;
        }
    }
    return numRow + 1;
}

int[,] array = CreateRandom2dArray();
Show2dArray(array);
Console.WriteLine("Номер строки с наименьшей суммой элементов: " + SearchMinSumInRow(array));
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц (mathprofy)
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение элемента: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение элемента: ");
    int max = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(min, max + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + " ");
            Console.WriteLine();
        }
    Console.WriteLine();
}

int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < array1.GetLength(0); i++)
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < array1.GetLength(1); k++)
                    result[i, j] += array1[i, k] * array2[k, j];
            }
    }
    return result;
}

int [,] array1 = CreateRandom2dArray();
int [,] array2 = CreateRandom2dArray();
Show2dArray(array1);
Show2dArray(array2);

Show2dArray(MatrixMultiplication(array1, array2));
*/

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся (опционально) двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/*
int[,,] Create3DRandomArray()
{
    Console.Write("Введите количество элементов в первом измерении: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество элементов во втором измерении: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество элементов в третьем измерении: ");
    int z = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение элемента: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение элемента: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,,] array = new int[x, y, z];
    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++)
            for (int k = 0; k < z; k++)
                array[i, j, k] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write(array[i, j, k] + $"({i},{j},{k}) ");
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int[,,] newArray = Create3DRandomArray();
Show3dArray(newArray); 
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

