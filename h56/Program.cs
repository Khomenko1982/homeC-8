// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите число M : ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N : ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] array = Fill2DArr(M, N, -10, 10);
Console.WriteLine("Исходный массив");
PrintArray(array); // Вызов метода печати массива

Console.WriteLine("суммы строк");
SumArrayRows(array);// Вызов метода печати суммы строк и наименьшего элемента



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

// Метод  суммы строк двумерного массива и определения наименьшего элемента
  
    void SumArrayRows(int[,] array)
{
    int indexMin = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine(sum);
        if (i == 0)
        {
            minSum = sum;
        }
        else if (sum < minSum)
        {
            minSum = sum;
            indexMin = i;
        }
    }
    string line = string.Empty;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        line += array[indexMin, j] + " ";
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов равна {indexMin+1}. ");
}


// Основную часть последнего метода признаюсь нашел в интернете 