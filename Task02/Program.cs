// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.Write("Введите кол-во столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во строк ");
int m = Convert.ToInt32(Console.ReadLine());

int sumRow = 0;

int minSumRow = Int32.MaxValue;

int indexRowMin = 0;

int[,] array = FillingArray(n, m);
Console.WriteLine();

for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumRow = sumRow + array[i, j];
    }
    if ( sumRow < minSumRow)
    {
        minSumRow = sumRow;
        indexRowMin = j;
    }
    sumRow = 0;

}

Console.WriteLine("    "+ indexRowMin +" строка");
Console.WriteLine();


int[,] FillingArray(int n, int m)
{
    int[,] array2D = new int[n, m];

    for (int j = 0; j < m; j++)
    {
        System.Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            array2D[i, j] = new Random().Next(0, 10);

            Console.Write(String.Format("{0,6}", array2D[i, j]) + " ");
            // Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    return array2D;
}

