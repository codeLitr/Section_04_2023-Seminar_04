// Задача 3. 
// Напишите программу, которая принимает на вход число N и выдаёт произведение 
// чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int InputNumberWithMessage(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int MultiplyDigitsInNumber(int number) //Функция произведения (Multiply) чисел 
// от 1 до N.
{
    int mltply = 1;

    for (int i = 1; i <= number; i++)
    {
        mltply *= i;
    }
    return mltply;
}
int N = InputNumberWithMessage("Введите число А");

System.Console.WriteLine(MultiplyDigitsInNumber(N));