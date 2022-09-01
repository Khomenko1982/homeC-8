// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

// Метод генерации случайных неповторяемых чисел:

IEnumerable<int> UniqueRandomNumbers(int from, int to)
{
    Random rand = new();
    int[] values = Enumerable.Range(from, to).ToArray();
    int i = values.Length;
    while (i > 0)
    {
        int j = rand.Next(i--);
        yield return values[j];
 
        (values[i], values[j]) = (values[j], values[i]);
    }
}

// Заполнение случайными уникальными числами массива:
int[,,] array = new int[2, 2, 2];
 
IEnumerator<int>  iterator = UniqueRandomNumbers(0, 9).GetEnumerator();
 
for (int i = 0; i < array.GetLength(0); i++)
for (int j = 0; j < array.GetLength(1); j++)
for (int k = 0; k < array.GetLength(2); k++)
{
    if (!iterator.MoveNext())
    {
        Console.WriteLine("Уникальные числа закончились!");
        return;
    }
 
    array[i, j, k] = iterator.Current;
}


for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine("Сторона N: "+ (i + 1));
 
   for (int j = 0; j < array.GetLength(1); j++)
       {
        for (int k = 0; k < array.GetLength(2); k++)
            {
            Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
        Console.WriteLine();
       }
    Console.WriteLine("============================");
}
 


// Многое взято с интернета, но смысл работы понятен