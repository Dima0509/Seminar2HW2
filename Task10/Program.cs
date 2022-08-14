// Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число:  ");
int numberA = Convert.ToInt32(Console.ReadLine());
int res = numberA % 100/10;

Console.WriteLine($"Результат = {res}"); 