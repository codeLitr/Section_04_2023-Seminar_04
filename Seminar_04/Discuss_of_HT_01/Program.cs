// Обсуждение домашнего задания к Семинару №2:

// Задача 10.
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Предложение преподавателя сделать двумя вариантами 1 - через функцию, 2 - через строку,
// как массиву символов (мой вариант вначале решения закомментирован):

// int Prompt(string message)
// {
//     Console.Write(message);
//     string strValue = Console.ReadLine() ?? "0";
//     int value = int.Parse(strValue);
//     return value;
// }
// int value = Prompt("Введите трехзначное число > ");
// if (value < 1000 && value > 99)
// {
//     string str = value.ToString();
//     int[] secondNumber = new int[str.Length];
//     for (int i = 0; i < str.Length; i++)
//     {
//     secondNumber[i] = int.Parse(str[i].ToString());
//     }
// Console.WriteLine(secondNumber[1]);
// }
// else
// {
//     Console.WriteLine("Вы ввели не трехзначное число");
// }



// ВАРИАНТ 1 (через функцию): 
// int InputNumberWithMessage(string message)
// {
//     System.Console.WriteLine(message);
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }

// int number = InputNumberWithMessage("Введите трехзначное число: ");

// if (number < 100 || number > 999)
// {
//     Console.WriteLine("Вы ввели не трехзначное число");   
//     return;     
// }

// int result = number / 10 % 10;
// System.Console.WriteLine(result);

// ВАРИАНТ 2 (через строку):

string numberInString = Console.ReadLine();

System.Console.WriteLine(numberInString[1]);