// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4

// 12 13 14 5

// 11 16 15 6

// 10 9 8 7

 var z = new int[4,4];
            z = Fill(z);

            Console.WriteLine("Спиральный массив:");
            PrintArray(z);


	        int[,] Fill(int[,] array)
        {
            var SizeX = array.GetUpperBound(0);
            var SizeY = array.GetUpperBound(1);
            var maxX = SizeX+1;
            var maxY = SizeY;
            var dirX = 1;
            var dirY = 1;

            var x = -1;
            var y = 0;
            var val = 1;
            while ((maxX >= 0) && (maxY >= 0))
            {
                for (int xval = 1; xval <= maxX; xval++)
                {
                    array[x + dirX * xval, y] = val;
                    val++;
                }

                x = x + dirX * maxX;
                dirX = -dirX;
                maxX--;

                for (int yval = 1; yval <= maxY; yval++)
                {
                    array[x, y + dirY * yval] = val;
                    val++;
                }

                y = y + dirY * maxY;
                dirY = -dirY;
                maxY--;
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
             Console.Write(array[j, i] + " "); // если надо спираль против часовой, поменяй местами i и j 
        }
        Console.WriteLine();
    }
}
       
          
        
// Сама спиралька за исключением метода вывода на печать взята с интернета.
