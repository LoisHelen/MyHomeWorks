// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandomDouble2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение элемента: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение элемента: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = Math.Round((new Random().Next(minValue, maxValue + 1) + new Random().NextDouble()), 2);

    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + " ");
            Console.WriteLine();
        }
    Console.WriteLine();
}

double[,] my2dArray = CreateRandomDouble2dArray();
Show2dArray(my2dArray);
*/

// Задача 50. Напишите программу (void or int), которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Сделала оба варианта метода: через void и через int - в обоих случаях одинаковый результат - проверено неоднократно.
/*
int [,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

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

// void ShowElement(int[,] array, int m, int n)
// {
//     int element = 0;
//     if(m <= array.GetLength(0) && n <= array.GetLength(1)) 
//     {
//         element = array[m,n];
//         Console.WriteLine("Значение элемента: " + element);
//     }
//     else Console.WriteLine("Элемента с такими индексами в массиве нет");
// } 

int ShowElement(int[,] array, int m, int n)
{
    int element = 0;
    if(m <= array.GetLength(0) && n <= array.GetLength(1)) 
    {
        element = array[m,n];
        Console.WriteLine("Значение элемента: " + element);
    }
    else Console.WriteLine("Элемента с такими индексами в массиве нет");
    return element;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.Write("Введите номер строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = ShowElement(myArray, m, n); // в случае с void убираем "int result = "
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце (сначала j, потом i). Результат - одномерный массив

/*
int [,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

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

double[] AverageInColumns(int[,] array)
{
    double[] average = new double[array.GetLength(1)];

    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
            average[j] += array[i,j];
        average[j] = average[j] / array.GetLength(0);
    }
    
    return average;
}

void ShowArray(double[] average)
{
    for(int i = 0; i < average.Length; i++)
        Console.Write(average[i] + " ");
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

double[] myAverage = AverageInColumns(myArray);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
ShowArray(myAverage);
*/