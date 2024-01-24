using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Array2
{
    private int rows;
    private int columns;
    private Random random;
    private bool fillWithUserInput;
    private int[,] array;
    public Array2(int rows, int columns, bool fillWithUserInput = false)
    {
        this.rows = rows;
        this.columns = columns;
        this.fillWithUserInput = fillWithUserInput;
        random = new Random();
        FillArray2();
    }
    private void FillArray2()
    {
        array = new int[rows, columns];
        if (fillWithUserInput)
        {
            Console.WriteLine("Введите элементы матрицы через пробел: ");
            for (int i = 0; i < rows; i++)
            {
                var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = int.Parse(line[j]);
                }
            }
        }
        else
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(1, 100);
                }
            }
        }
    }
    public void PrintArray2()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    public void InReverse()
    {
        for (int i = 0; i < rows; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            else
            {
                for (int j = columns - 1; j >= 0; j--)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
    public double Average()
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                sum += array[i, j];
            }
        }
        return sum / (rows * columns);
    }

}
