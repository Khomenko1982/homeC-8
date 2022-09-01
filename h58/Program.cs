// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


Console.Write("Введите число M : ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N : ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] array = Fill2DArr(M, N, 0, 9);
Console.WriteLine("Исходный массив 1");
PrintArray(array); // Вызов метода печати массива
Console.WriteLine();
int[,] array2 = Fill2DArr2(M, N, 0, 9);
Console.WriteLine("Исходный массив 2");
PrintArray(array2); // Вызов метода печати массива
Console.WriteLine();
Console.WriteLine("Произведение массивов");
CompositionArray(array);// Вызов метода печати произведения двух массивов


// PrintArray(array);

// Метод возвращает двумерный массив 1 [,] на size элементов 
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
// Метод возвращает двумерный массив 2 [,] на size элементов 
int[,] Fill2DArr2(int rowsCount, int columnsCount, int lefts, int rights)
{
    int[,] array2 = new int[rowsCount, columnsCount];

    Random random = new Random();
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = random.Next(lefts, rights);
        }
    }
    {

    }
    return array2;
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

// Метод  произведения двух массивов

void CompositionArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]*array2[i, j] + " ");
        }
        Console.WriteLine();
    }

}
