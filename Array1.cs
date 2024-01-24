using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Array1
{
    private int[] array;

    public Array1(int length, bool usInp = false)
    {
        array = new int[length];

        if (usInp)
        {

            ArrUsInp();
        }

        else
        {
            ArrRand();
        }
    }

    public void ArrUsInp()
    {
        Console.WriteLine($"Введите {array.Length} чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    public void ArrRand()
    {
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
        }

        Console.WriteLine("Рандомные значаения: ");
    }

    public double Average()
    {
        int sum = 0;
        foreach (int value in array)
        {
            sum += value;
        }
        return (double)sum / array.Length;
    }


    public void RemoveElements()
    {
        int[] newArray = new int[array.Length];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i]) <= 100)
            {
                newArray[j] = array[i];
                j++;
            }
        }
        Array.Resize(ref newArray, j);
        array = newArray;
    }



    public void RemoveDuplicates()
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                count++;
            }
        }

        int[] result = new int[count];
        count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                result[count] = array[i];
                count++;
            }
        }
        array = result;
    }


    public void PrintArray()
    {
        Console.WriteLine("Элементы массива:");
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }

}
