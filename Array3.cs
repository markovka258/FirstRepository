using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Array3
{
    private int[][] array3;

    public Array3(int rows, int[] values)
    {
        array3 = new int[rows][];

        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            array3[i] = new int[values[i]];

            for (int j = 0; j < values[i]; j++)
            {
                array3[i][j] = random.Next(1, 100);
            }
        }
    }

    public Array3(int rows)
    {
        array3 = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Введите количество значений в строке {i + 1}: ");
            int values = int.Parse(Console.ReadLine());

            array3[i] = new int[values];

            for (int j = 0; j < values; j++)
            {
                Console.Write($"Введите значение [{i}, {j}]: ");
                array3[i][j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public double Average()
    {
        int sum = 0;
        int count = 0;

        for (int i = 0; i < array3.Length; i++)
        {
            for (int j = 0; j < array3[i].Length; j++)
            {
                sum += array3[i][j];
                count++;
            }
        }

        return (double)sum / count;
    }


    public void ModifyArray()
    {
        for (int i = 0; i < array3.Length; i++)
        {
            for (int j = 0; j < array3[i].Length; j++)
            {
                if (array3[i][j] % 2 == 0)
                {
                    array3[i][j] = i * j;
                }
            }
        }
    }


    public double[] GetAverages()
    {
        double[] averages = new double[array3.Length];

        for (int i = 0; i < array3.Length; i++)
        {
            int sum = 0;

            for (int j = 0; j < array3[i].Length; j++)
            {
                sum += array3[i][j];
            }

            averages[i] = (double)sum / (double)array3[i].Length;
        }

        return averages;
    }


    public void PrintArray()
    {
        Console.WriteLine("Массив:");

        for (int i = 0; i < array3.Length; i++)
        {
            for (int j = 0; j < array3[i].Length; j++)
            {
                Console.Write(array3[i][j] + " ");
            }

            Console.WriteLine();
        }
    }
}
