// Задача 2.
// Напишите программу, которая принимает на вход число и выдаёт количество цифр 
// в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int InputNumberWithMessage(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int A = InputNumberWithMessage("Введите число: ");

int index = (int)Math.Log10(A) + 1;

System.Console.WriteLine(index);