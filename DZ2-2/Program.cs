// Напишите пргограмму, которая выводит третью цифру заданного числа или показывает, что третьей цифры нет
// 645-> 5
// 78-> третьей цифры нет
// 32679-> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 )
{
    Console.WriteLine("Число не трехзначное");
}
else 
{
    while (number >999)
    {
    number/=10;
    }
    System.Console.WriteLine($"{(number % 10)}");
}
