//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();
int [] number = new int [3];
Console.Write("ВВедите первое число: ");
number[0] = int.Parse(Console.ReadLine()); 
Console.Write("Введите второе число: ");
number[1] = int.Parse(Console.ReadLine());
Console.Write("Введите третее число: ");
number[2] = int.Parse(Console.ReadLine()); 
int max = number[0];
if(max<number[1]){ max = number[1]; }
if(max<number[2]){ max = number[2]; }
Console.WriteLine($"Максимальное число равно {max}");