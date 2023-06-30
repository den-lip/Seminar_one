//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число");
string numberA = Console.ReadLine();
int a = Convert.ToInt32(numberA);
Console.WriteLine("Введите второе число");
string numberB = Console.ReadLine();
int b = Convert.ToInt32(numberB);
Console.WriteLine("Введите третье число");
string numberC = Console.ReadLine();
int c = Convert.ToInt32(numberC);

int max = a;
if (max < b) max = b;
if (max < c) max = c;

System.Console.WriteLine("Наибольшее из этих чисел = " + max );
