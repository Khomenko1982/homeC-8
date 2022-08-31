// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Write("Введите число M : ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N : ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] array = Fill2DArr(M, N, -10, 10);
Console.WriteLine("Исходный массив");
PrintArray(array); // Вызов метода печати массива
SwapFirstAndLastRows(array);// Вызов метода печати перевернутого массива
Console.WriteLine();
Console.WriteLine("Перевернутый массив");
PrintArray(array);

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

// Метод  перевернутого двумерного массива
void SwapFirstAndLastRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
       int temp=array[0,i];
       array[0,i]=array[array.GetLength(0)-1 ,i];
       array[array.GetLength(0)-1 ,i]=temp;
    }

}


