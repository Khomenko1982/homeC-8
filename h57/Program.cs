// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

Console.Write("Введите число M : ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N : ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] array = Fill2DArr(M, N, 0, 9);
Console.WriteLine("Исходный массив");
PrintArray(array); // Вызов метода печати массива
FrequencyDictionary(array);// Вызов метода печати перевернутого массива


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

// Метод  частотного словаря
void FrequencyDictionary(int[,] array)
{
    int[] repeats=new int[10];
    for (int i = 0; i < array.GetLength(1); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        repeats[array[i,j]]++;
      }
    }
for (int i = 0; i<repeats.Length; i++)
{
    if (repeats[i]>0)
    {
         Console.WriteLine($"Количество повторений числа {i} = {repeats[i]}");
    }
}
    }



