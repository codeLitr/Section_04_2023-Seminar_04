// Задача 1:
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму 
// чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
int InputNumberWithMessage(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SummDigitsInNumber(int number) //Функция сложения чисел от 1 до N.
{
    int summ = 0;

    for (int i = 1; i <= number; i++)
    {
        summ += i;
    }
    return summ;
}
int A = InputNumberWithMessage("Введите число А");

System.Console.WriteLine(SummDigitsInNumber(A));