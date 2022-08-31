// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Write("Введите число M : ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N : ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] array = Fill2DArr(M, N, -10, 10);
int[,] tarray = GetTArray(array);
Console.WriteLine("Исходный массив");
PrintArray(array); // Вызов метода печати массива
GetTArray(array);// Вызов метода печати перевернутого массива
Console.WriteLine();
Console.WriteLine("Перевернутый массив");
PrintArray(tarray);

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

// Метод  замены строк на столбцы у двумерного массива
int[,] GetTArray(int[,] array)
{
    int[,] tarray = new int[array.GetLength(1), array.GetLength(0)];

        for (int i = 0; i < tarray.GetLength(0); i++)
    {
        for (int j = 0; j < tarray.GetLength(1); j++)
        {
            tarray[i, j] = array[j,i];
        }
    }
    {

    }
    return tarray;
}
