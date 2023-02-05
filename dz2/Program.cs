//  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125
System.Console.WriteLine("Enter number N");
int num1 = int.Parse(Console.ReadLine());
int count = 1;
System.Console.WriteLine("----------------------------------------------------------------");
while(count <= num1)
{
System.Console.WriteLine(Math.Pow(count, 3));
count++;
}