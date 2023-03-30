/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if(a > b & b >= c){
    Console.WriteLine($"max = {a}");
}
if(b > a & a >= c){
    Console.WriteLine($"max = {b}");
}
if(c > b & b >= c){
    Console.WriteLine($"max = {c}");
}
if (a == b & b == c){
    Console.WriteLine("Everything is equal");
}
