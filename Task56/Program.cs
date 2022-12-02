// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите такое же число столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

if (rows!=columns)
    {
         Console.WriteLine("число строк и столбцов должно совпадать");
         return;
    }

int[,] array = new int[rows, columns];  // Задаем массив

int[,] GetArray()                      // заполняем его числами от -9 до 9
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)               // Выводим на печать массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int SumInRow(int[,] array)    // Находим суммы элементов построчно
{
    int minVal = Int32.MaxValue;         // Находим строку, где сумма минимальна
    int minSumInRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
        sum += array[i,j];
        }
        if (sum < minVal)
        {
            minVal=sum;
            minSumInRow=i;
        }
    }
    return minSumInRow;
}
PrintArray(GetArray());
Console.WriteLine("номер строки с наименьшей суммой элементов => " + SumInRow(array));


