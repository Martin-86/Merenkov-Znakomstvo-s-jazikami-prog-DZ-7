//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] number = {{41,67,96,77},
                 {14,72,26,71},
                 {65,52,33,23},};

Console.WriteLine("Введите номер строки ");
int row = Convert.ToInt32(Console.ReadLine())-1;
Console.WriteLine("Введите номер столбца ");
int column = Convert.ToInt32(Console.ReadLine())-1;
if(row < number.GetLength(0))
{
    if(column < number.GetLength(0)+1)
    {
        Console.Write("Значение элемента ");
        Console.Write(number[row, column]);
    }
    else
    {
        Console.WriteLine("Нет такого элемента"); 
    }

}
else
{
Console.WriteLine("Нет такого элемента");
}
