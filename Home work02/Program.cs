/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите первое число  ");
string number1 = Console.ReadLine();
Console.WriteLine("Введите второе число  ");
string number2 = Console.ReadLine();
Console.WriteLine("Введите третье число  ");
string number3 = Console.ReadLine();

int numA = int.Parse(number1);
int numB = int.Parse(number2);
int numC = int.Parse(number3);
int max = numA;

 if (numA > max) max = numA;
 if (numB > max) max = numB;
 if (numC > max) max = numC;
 Console.Write ($"max = {max}");