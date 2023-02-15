// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два чиcла:");
int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum > secondNum)
{
    Console.WriteLine(firstNum + " больше " + secondNum + ", max = " + firstNum);
}
else if(firstNum == secondNum)
{
    Console.WriteLine(firstNum + " и " + secondNum + " равны " + ", max = " + firstNum);
}
else
{
    Console.WriteLine(firstNum + " меньше " + secondNum + ", max = " + secondNum);
}
Console.WriteLine("Введи в терминал команду dotnet run и попробуйте снова");


