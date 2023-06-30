// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
string num1 = Console.ReadLine();
int number1 = Convert.ToInt32(num1);
Console.WriteLine ("Введите второе число");
string num2 = Console.ReadLine();
int number2 = Convert.ToInt32(num2);
if ( number1 < number2)
    Console.WriteLine("Число " + number1 + " меньше числа " + number2);
else
{
    Console.WriteLine ("Число " + number1 + " больше числа " + number2);
}
