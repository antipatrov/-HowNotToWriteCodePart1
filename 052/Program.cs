// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");

        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}
void ArithMean(int[,] matr)
{
    //Console.WriteLine(matr.GetLength(0));
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;
        double mean = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];
            
        }
        mean = sum / matr.GetLength(0);
       Console.Write($"{Math.Round(mean,3)}  ");
    }
}



int [,] array = new int[3,4];
int [] matrix2 = new int[4];
PrintMatrix(array);
Console.WriteLine();
FillArray(array);
PrintMatrix(array);
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое каждого столбца:  ");
ArithMean(array);


// int [] matrix2 = new int[4];
// int sum = 0; int mean = 0;
