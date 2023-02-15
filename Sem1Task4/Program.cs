// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три чиcла:");
int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());
int thirdNum = Convert.ToInt32(Console.ReadLine());

if ((firstNum > secondNum) && (firstNum > thirdNum))
{
    Console.WriteLine(firstNum + " больше " + secondNum + " и больше " + thirdNum + ", max = " + firstNum);
}
else if ((firstNum == secondNum) && (firstNum > thirdNum))
{
    Console.WriteLine(firstNum + " и " + secondNum + " равны " + "и больше " + thirdNum + ", max = " + firstNum);

}
else if ((secondNum > firstNum) && (secondNum > thirdNum))
{
    Console.WriteLine(secondNum + " больше " + firstNum + " и больше " + thirdNum + ", max = " + secondNum);
}
else if ((secondNum > firstNum) && (secondNum == thirdNum))
{
    Console.WriteLine(secondNum + " и " + thirdNum + " равны " + "и больше " + firstNum + ", max = " + secondNum);
}
else if ((firstNum == thirdNum) && (firstNum > secondNum))
{
    Console.WriteLine(firstNum + " и " + thirdNum + " равны " + "и больше " + secondNum + ", max = " + firstNum);
}
else if ((firstNum == thirdNum) && (firstNum == secondNum))
{
    Console.WriteLine(firstNum + " и " + secondNum + " и " + thirdNum + " равны " + ", max = " + firstNum);
}
else
{
    Console.WriteLine(thirdNum + " больше " + firstNum + " и больше " + secondNum + ", max = " + thirdNum);
}
Console.WriteLine("Введи в терминал команду dotnet run и попробуйте снова");

