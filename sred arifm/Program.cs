int[,] number = {{1,4,7,2},
                 {5,9,2,3},
                 {8,4,2,4},};


int i = 0;
int j = 0;
decimal a = 0;
int temp = 0;
void Array(int[,] number)
{
    for( j = 0; j < number.GetLength(1);)
    {
        for (i = 0; i < number.GetLength(0); i++)
        {
            temp = (number[i, j]);
            a = a + Convert.ToDecimal(temp);

        }
        Console.WriteLine("Столбец " + (j + 1));
        // b = Convert.ToDecimal(a);
        // c = Convert.ToDecimal(j);
        // Console.WriteLine(b/c);
        Console.WriteLine(a/number.GetLength(0));
        a = 0;
        j++;

    }
    
}
Array(number);
