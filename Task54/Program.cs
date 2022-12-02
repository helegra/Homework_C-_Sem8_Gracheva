// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];  // Задаем матрицу

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

void SortArrayInLine(int[,] array)     // Сортировка в строке по убыванию
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j2 = 0; j2 < array.GetLength(1) - 1; j2++)   //Проходим методом пузырька j-1 раз
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j+1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }
}
PrintArray(GetArray());
Console.WriteLine("Отсортированный массив: ");
SortArrayInLine(array);
PrintArray(array);
