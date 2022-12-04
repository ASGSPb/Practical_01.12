/*
Задача 58*: Задайте две матрицы. Напишите программу, которая будет
*находить произведение двух матриц.*/

Console.Write("Введите колличество столбцов матриц ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество строк матриц ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Первая матрица");
int [,] firstArray = FillingArray (rows, columns);


Console.WriteLine("Вторая матрица ");
int [,] secondArray = FillingArray (rows, columns);


Console.WriteLine();
int [,] multiplyArray = MultiplyArray(firstArray, secondArray);

Console.WriteLine("Конечная матрица ");
PrintArray(multiplyArray);



int [,] MultiplyArray(int [,] arrayFirst, int [,] arraySecond)
{
    int arraySum = 0;
    int [,] multiplyArray = new int [arrayFirst.GetLength(0), arraySecond.GetLength(1)];
    for (int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arraySecond.GetLength(1); j++)
        {
            for (int k = 0; k < arrayFirst.GetLength(1); k++)
            {
                arraySum = arraySum + (arrayFirst[i,k] * arraySecond[k,j]);
            }
        multiplyArray[i, j] = arraySum;
        arraySum = 0;
        }
    }
    return multiplyArray;
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
            Console.Write(String.Format("{0,6}", array[i, j]) + " ");
            
        }
        Console.WriteLine();
    }     
}