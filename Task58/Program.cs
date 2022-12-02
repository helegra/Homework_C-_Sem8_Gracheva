// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите число строк 1 матрицы");
int rows1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите такое же число столбцов 1 матрицы");
int columns1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число строк 2 матрицы, равное числу столбцов 1 матрицы ");
int rows2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите такое же число столбцов 2 матрицы");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[rows1, columns1];  // Задаем 1 матрицу
int[,] matrix2 = new int[rows2, columns2];  // Задаем 2 матрицу

if (columns1 != rows2) // проверка на возможность умножения матриц
{
    Console.WriteLine("Эти матрицы перемножать нельзя");
    return;
}

int[,] GetArray(int[,] array)                           // заполняем матрицу случайными числами от -9 до 9
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-2, 3);
        }
    }
    return array;
}
GetArray(matrix1);
GetArray(matrix2);


int[,] MltplMatrix(int[,] matrix1, int[,] matrix2)              // третья матрица-результат умножения 1 и 2
{
    int[,] matrix = new int[columns2, rows1];
    for (int i = 0; i < matrix1.GetLength(1); i++) // строки первой матрицы
    {
        for (int i2 = 0; i2 < matrix1.GetLength(1); i2++) // строки первой матрицы, столбцы второй матрицы
        {
            int sum = 0;
            for (int j = 0; j < matrix2.GetLength(0); j++) // столбцы первой матрицы
            {
                sum += matrix1[i, j] * matrix2[j, i2];
                Console.Write($"  ss: {i},{j}={sum} "); 
            }
            matrix[i, i2] = sum;
            Console.WriteLine();
        }
    }
    return matrix;
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

Console.WriteLine("Первая матрица: ");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
PrintArray(matrix2);
Console.WriteLine("Результат умножения: ");
PrintArray(MltplMatrix(matrix1, matrix2));
