// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();
int [] number = new int [2];
Console.Write("Введите первое число: ");
number[0] = int.Parse(Console.ReadLine()); 
Console.Write("Введите второе число: ");
number[1] = int.Parse(Console.ReadLine()); 
int max = 0;
int count = 0;
while(count<number.Length)
{
    if(max<number[count]){ max = number[count];}
    count++;
}
Console.WriteLine($"Максимальное число равно: {max}");