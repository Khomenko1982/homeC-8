// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8

Console.Write("Введите число M : ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N : ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] array = Fill2DArr(M, N, -10, 10);
Console.WriteLine("Исходный массив");
PrintArray(array); // Вызов метода печати массива
Console.WriteLine("Отсортированный массив");
SortArrayRows(array);// Вызов метода печати перевернутого массива


// Метод возвращает двумерный массив [,] на size элементов 
int[,] Fill2DArr(int rowsCount, int columnsCount, int lefts, int rights)
{
    int[,] array = new int[rowsCount, columnsCount];

    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(lefts, rights);
        }
    }
    {

    }
    return array;
}
// Метод печати двумерного массива
void PrintArray(int[,] array)
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




// Метод  сортировки двумерного массива по строкам
void SortArrayRows(int[,] array)
{
    int[] temp = new int[array.GetLength(0)];
 Console.WriteLine("Сортировка по строкам: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                    temp[j] = array[i, j];
                Array.Sort(temp);
                for (int k = 0; k < array.GetLength(0); k++)
                {
                    array[i, k] = temp[k];
                    Console.Write("{0}\t", array[i, k]);
                }
                Console.WriteLine();
            }
}

// Увы, получилось добиться сортировки только в квадратном массиве..