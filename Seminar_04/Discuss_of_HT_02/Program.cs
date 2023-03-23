// Обсуждение домашнего задания к Семинару №2:

// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Предложение преподавателя сделать по тремя вариантами 1 - упрощенный, через строку, как 
// массиву символов, 2 - по программе обучения, 3 - через функцию (мои два варианта 
// вначале решения закомментированы):

// ВАРИАНТ РЕШЕНИЯ 1 (мой):

// int Prompt(string message)
// {
//     Console.Write(message);
//     string strValue = Console.ReadLine() ?? "0";
//     int value = int.Parse(strValue);
//     return value;
// }
// int temp = Prompt("Введите число > ");
// if (temp < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     if (temp < 1000 && temp > 99)
//     {
//         int result = temp % 10;
//         Console.WriteLine(result);
//     }
//     else
//     {
//         string str = temp.ToString();
//         int[] thirdNumber = new int[str.Length];
//         for (int i = 0; i < str.Length; i++)
//         {
//             thirdNumber[i] = int.Parse(str[i].ToString());
//         }
//         Console.WriteLine(thirdNumber[2]);
//     }
// }



// ВАРИАНТ РЕШЕНИЯ 2 (мой):

// int Prompt(string message)
// {
//     Console.Write(message);
//     string strValue = Console.ReadLine() ?? "0";
//     int value = int.Parse(strValue);
//     return value;
// }
// int temp = Prompt("Введите число > ");
// if (temp < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// if(temp > 100)
// {
// string str = temp.ToString();
//     int[] thirdNumber = new int[str.Length];
//     for (int i = 0; i < str.Length; i++)
//     {
//         thirdNumber[i] = int.Parse(str[i].ToString());
//     }
//     Console.WriteLine(thirdNumber[2]);
// }



// ВАРИАНТ 1 преподавателя (упрощенный):

string numberInString = Console.ReadLine();

if (numberInString.Length < 3) // Условие, если длина массива меньше трех символов.
{
    System.Console.WriteLine("Неправильный ввод");
    return;
}

System.Console.WriteLine(numberInString[2]);



// ВАРИАНТ 2 преподавателя (по программе обучения):

// int InputNumberWithMessage(string message)
// {
//     System.Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int number = InputNumberWithMessage("Введите число: ");

// if (number < 100)
// {
//     Console.WriteLine("Вы ввели не трехзначное число");   
//     return;     
// }

// while (number > 999)
// {
//     number /= 10;
// }
// System.Console.WriteLine(number % 10);

// ВАРИАНТ 3 преподавателя (через функцию):

// int InputNumberWithMessage(string message)
// {
//     System.Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int FindThirdDigit(int number)
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     return number % 10;
// }

// int number = InputNumberWithMessage("Введите число: ");

// if (number < 100)
// {
//     Console.WriteLine("Вы ввели не трехзначное число");   
//     return;     
// }

// System.Console.WriteLine(FindThirdDigit(number));

