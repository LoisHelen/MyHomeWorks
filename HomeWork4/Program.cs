// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int CustomPow(int a, int b)
{
    int result = a;
    for(int current = 1; current < b; current++)
        result = result * a;
    return result;
}

Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = CustomPow(a, b);
Console.Write("A в степени B = " + result);
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumDigit(int num)
{
    int sum = 0;
    int digit = 0;
    while(num > 0)
    {
        digit = num % 10;
        sum = sum + digit;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма всех цифр числа = " + SumDigit(num));
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] UserArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input an {i + 1} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine("- " + array[i] + ";");
}

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] newArray = UserArray(m);
ShowArray(newArray);
*/