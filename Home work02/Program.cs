/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите первое число  ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите первое число  ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите первое число  ");
int numberC = int.Parse(Console.ReadLine());


if (numberB < numberA && numberA> numberC)
{
   Console.WriteLine($"max = {numberA}");
}
else

if (numberA < numberB && numberB> numberC)
{
   Console.WriteLine($"max = {numberB}");
}
if (numberA < numberC && numberC> numberB)
{
   Console.WriteLine($"max = {numberC}");
}
