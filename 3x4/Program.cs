//              Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//              m = 3, n = 4.



void Printarray(int[,] arr)
{
    int[,] array = new int[3, 4];

    for (int i = 0; i < arr.GetLength(0); i++)   // matrix.GetLength(0) - берет количество строк(0 означает строки)
    {
        for (int j = 0; j < arr.GetLength(1); j++) // matrix.GetLength(1)- означает столбцы(1)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-10,10);
        }
    }
}

int[,] array = new int[3, 4];
FillArray(array);
Printarray(array);