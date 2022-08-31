// Задача 50. Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4


internal class Program
{
    private static void Main(string[] args)
    {
        int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
        

        for (int i = 0; i < array.GetLength(0); i++)
        {

            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
                
            }
            Console.WriteLine();
        }
        


        Console.WriteLine("Введите строку:  ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите столбец:  ");
        int column = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(array[row - 1, column - 1]);

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(row > array.GetLength(0) || column-1 > array.GetLength(1)) 
                {
                     Console.WriteLine("Такого элемента нет"); 
                }
                
                
            }

        }
    }
}