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

    public Array2(int rows, int columns, bool usInp = false)
    {
        array = new int[rows, columns];
        if (usInp)
        {

            ArrUsInp2();
        }

        else
        {
            ArrRand2();
        }
    }

    public void ArrUsInp2()
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

    public void ArrRand2()
    {
        Random random = new Random();

        for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(1, 100);
                }
            }

        Console.WriteLine("Рандомные значаения: ");
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
        int[,] ar = array;
        for (int i = 0; i < rows; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(ar[i, j] + " ");
                }
            }
            else
            {
                for (int j = columns - 1; j >= 0; j--)
                {
                    Console.Write(ar[i, j] + " ");
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
