// Задача 60. ...
// Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите число x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число y:");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число z: ");
int z = Convert.ToInt32(Console.ReadLine());

if ((x * y * z) > 89)                               //Проверка на двузначность
{
    Console.WriteLine("Запас двузначных чисел закончился, введите иные координаты");
    return;
}

int[,,] threeDimArray = new int[x, y, z];            // Задаем трехмерный массив

void FillArray(int[,,] array)                      // заполняем его числами от 10 до 99 (см проверку)
{
    int n = 10;

    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = n;
                n++;
            }
        }
    }
}

void PrintArray(int[,,] array)               // Выводим на печать трехмерный массив
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[x, y, z]}({x},{y},{z}) ");
            }
            Console.WriteLine();
        }
    }
}

FillArray(threeDimArray);
PrintArray(threeDimArray);

