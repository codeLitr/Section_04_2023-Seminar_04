// Задача 4.
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями 
// и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// ВАРИАНТ решения без функций:

// int[] array = new int[8];

// Random rnd = new Random();

// for (int i = 0; i < array.Length; i++) // array.Length - определит длину массива.
// {
//     array[i] = rnd.Next(0, 2); // Заполнит массив числами в диапазоне от 0 до 2,
//     // при этом 2 в счет не берется, т.е. будет заполняться нулями и единицами.
// }

// for (int i = 0; i < array.Length; i++)
// {
//     if (i == array.Length - 1) //Уберет запятую после последнего числа в массиве.
//     {
//         System.Console.Write(array[i]); // Выведет значения, которым заполнился
//     }                                       // массив
//     else
//     {
//         System.Console.Write(array[i] + ", ");
//     }
// }


// ВАРИАНТ решения с функциями:

void FillArrayRandomNumbers(int[] array) // Функция по определению длины и 
// заполнения массива.
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
}

void PrintArray(int[] array) // Функция по выводу массива и исключения запятой
// после последнего числа в массиве.
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            System.Console.Write(array[i]);
        else
            System.Console.Write(array[i] + ", ");
    }
}

int[] array = new int[8];
FillArrayRandomNumbers(array);
PrintArray(array);