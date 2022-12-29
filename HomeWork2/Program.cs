// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecNum(int number)
{
    int des = number / 10;
    int result = des % 10;
    return result;
}

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 999 || number < 100) Console.WriteLine("Вы ввели не трёхзначное число! Повторите попытку.");
else Console.WriteLine("Вторая цифра числа: " + SecNum(number));
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdNum(int number)
{
    while(number > 999) 
    {
       number = number / 10;
    }   
    int result = number % 10;
    return result;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 100) Console.WriteLine("Третьей цифры в данном числе нет");
else Console.WriteLine("Третья цифра числа: " + ThirdNum(number));
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool Weekend (int day)
{
    if(day > 5) return true;
    else return false;
}

Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

bool result = Weekend(day);

if (day < 1 || day > 7) Console.WriteLine("Нет такого номера дня недели");
else 
{
    if (result) Console.WriteLine("Данный день недели выходной");
    else Console.WriteLine("День недели не является выходным");
}
*/