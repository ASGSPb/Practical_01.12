// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.Write("Введите кол-во строк ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во столбцов ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Начальный массив ");
int[,] array2D = FillingArray(n, m);
System.Console.WriteLine();

Console.Write("Конечный массив ");
int [,] sortArray = SortArray(array2D);
Console.WriteLine();

PrintArray(sortArray);
Console.WriteLine();


int [,] SortArray(int [,] array2D)
{
    int temp = 0; 
    for (int m = 0; m < array2D.GetLength(0); m++)
        {
            for (int n = 0; n < array2D.GetLength(1); n++)
            {
                for (int i = 0; i < array2D.GetLength(1); i++)
                {
                    for (int j = i + 1; j < array2D.GetLength(1); j++)
                    {
                        if (array2D[m,i] < array2D[m,j])
                        {    
                            temp = array2D[m,j];
                            array2D[m,j] = array2D[m,i];
                            array2D[m,i] = temp;
                        }
                    }
                }
            }
        
        }
    return array2D;
}


int[,] FillingArray(int n, int m)
{
    int[,] array2D = new int[n, m];

    
    for (int i = 0; i < n; i++)
    {
        System.Console.WriteLine();

    for (int j = 0; j < m; j++)   
        {
            array2D[i, j] = new Random().Next(0, 10);

            Console.Write(String.Format("{0,6}", array2D[i, j]) + " ");
            // Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    return array2D;
}


void PrintArray(int[,] array)
{ 
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for  (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,6}", array2D[i, j]) + " ");
            
        }
        Console.WriteLine();
    }     
}
