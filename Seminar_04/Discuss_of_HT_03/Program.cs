// Обсуждение домашнего задания к Семинару №2:

// Задача 15: 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Предложение преподавателя сделать по двумя вариантами 1 - стандартный, 2 - через функцию,
// (мои два варианта вначале решения закомментированы):

// ВАРИАНТ РЕШЕНИЯ (мой):

// int Prompt(string message)
// {
//     Console.Write(message);
//     string strValue = Console.ReadLine() ?? "0";
//     int value = int.Parse(strValue);
//     return value;
// }

// string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

// int value = Prompt("Введите номер дня недели > ");
// if(value == 6 || value == 7) 
// {
//     Console.WriteLine("Да");
// } 
// else
// {
//     Console.WriteLine("Нет");
// }

// ВАРИАНТ 1 преподавателя (стандартный):

// int InputNumberWithMessage(string message)
// {
//     System.Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int dayOfWeek = InputNumberWithMessage("Введите номер дня недели");

// if (dayOfWeek >= 1 && dayOfWeek <= 5)
// {
//     System.Console.WriteLine("Рабочий день");
// }
// else if (dayOfWeek >= 6 && dayOfWeek <= 7)
// {
//     System.Console.WriteLine("Выходной день");
// }
// else 
// {
//     System.Console.WriteLine("Нет такого дня недели");
// }


// ВАРИАНТ 2 преподавателя (через функцию):

int InputNumberWithMessage(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintDayOfWeekByNumber(int dayOfWeek)
{
    if (dayOfWeek >= 1 && dayOfWeek <= 5)
    {
        System.Console.WriteLine("Рабочий день");
    }
        else if (dayOfWeek >= 6 && dayOfWeek <= 7)
        {
            System.Console.WriteLine("Выходной день");
        }
        else
        {
            System.Console.WriteLine("Нет такого дня недели");
        }
}
int dayOfWeek = InputNumberWithMessage("Введите номер дня недели");

PrintDayOfWeekByNumber(dayOfWeek);