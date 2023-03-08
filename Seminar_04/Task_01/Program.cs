// Сложить A c B при помощи функции.
// void - означает, что функция ничего не возвращает.
// int Summ() - int это тип данных, которые будут возвращены, "Summ" это название функции
// (название функции надо называть глаголом (потому что она что-либо делает) и с большой буквы),
// в скобках указываются параметры (переменные).

int InputNumberWithMessage(string message)
{
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
void Summ(int A, int B) // Название функции надо называть глаголом (потому что она что-либо
// делает) и с большой буквы.
{
    System.Console.WriteLine(A + B);
}

int A = InputNumberWithMessage("Введите A");
int B = InputNumberWithMessage("Введите B");

Summ(A, B);