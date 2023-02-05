// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int mynumber;
while(true)
{
System.Console.WriteLine("Enter your five digit number!");
mynumber = int.Parse(Console.ReadLine());
if (mynumber >= 10000 && mynumber <= 99999)
{
break;
}
}
int Firstchar = (mynumber % 100000 / 10000) * 100;
int Secondchar = (mynumber % 10000 / 1000) * 10;
int ThirdChar = (mynumber % 1000 / 100);
int part1 = Firstchar + Secondchar + ThirdChar;

int InverseFithChar = (mynumber % 10) * 100;
int InverseForthChar = (mynumber % 100 / 10) * 10;
int part2 = InverseFithChar + InverseForthChar + ThirdChar;
if (part1 == part2) System.Console.WriteLine("Your number is palindrome!");
else System.Console.WriteLine("Your number is not palindrome!");