// Задача 19 - Напишите программу, которая принимает на вход любое целое положительное число и проверяет, является ли оно палиндромом.
/*
bool Palindrome (int number)
{
    int startnumber = number;
    int newnumber = 0;
    while(startnumber > 0)
    {
        int ed = startnumber % 10;
        newnumber = (newnumber + ed) * 10;
        startnumber = startnumber / 10;
    }
    newnumber = newnumber / 10;
    if (newnumber == number) return true;
    else return false;
}

Console.WriteLine("Введите любое целое положительное число, чтобы проверить является ли оно палиндромом: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Palindrome(number);
if(result) Console.WriteLine("Ура! Мы нашли палиндром!");
else Console.WriteLine("Данное число не является палиндромом");
*/

// Задача 21 - Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Dist(double x1,double y1,double z1,double x2,double y2,double z2)
{
    double result = Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2));
    return result;
}

Console.WriteLine("Введите координаты двух точек по порядку: x1, y1, z1, x2, y2, z2");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

double result = Dist(x1,y1,z1,x2,y2,z2);

Console.WriteLine("Расстояние между двумя точками = " + Math.Round(result,2));
*/

// Задача 23 - Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube(int n)
{
    int count = 1;
    Console.WriteLine("Кубы чисел: ");
    while(count < n+1) 
    {
        Console.Write(Math.Pow(count, 3) + " ");
        count = count + 1;
    }
}

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Cube(n);
*/