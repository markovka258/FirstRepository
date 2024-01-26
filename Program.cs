using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Array1 randArr = new Array1(3, false);
        randArr.PrintArray();
        Console.WriteLine("Среднее значение: " + randArr.Average());

        randArr.PrintArray();
        randArr.RemoveElements();
        Console.WriteLine("Mассив, где удалены все элементы, большие 100 по модулю: ");
        randArr.PrintArray();

        randArr.PrintArray();
        Console.WriteLine("Массив, где удалены все повторяющиеся элементы: ");
        randArr.RemoveDuplicates();
        randArr.PrintArray();



        Console.WriteLine("Вводим размеры:");
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());
    

        Array2 randArr2 = new Array2(3, 2, false);
        randArr2.ArrRand2(); 
        randArr2.PrintArray2(); 

        Console.WriteLine("Среднее значение: " + randArr2.Average()); 
        
        Console.WriteLine($"Массив с четными строками в обратном порядке:");
        randArr2.InReverse(); 




        Console.Write("Введите количество строк в ступенчатом массиве: ");

        int[] values = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Введите количество значений в строке {i + 1}: ");
            values[i] = int.Parse(Console.ReadLine());
        }

        Array3 randArray = new Array3(rows, values);

        Console.WriteLine("Ступенчатый массив с рандомными значениями:");
        randArray.PrintArray();

        Console.WriteLine($"Среднее: {randArray.Average()}");
        randArray.ModifyArray();

        foreach (double i in randArray.GetAverages())
        {
            Console.WriteLine($"Среднее для вложенного массива: {i}");
        }

        Console.WriteLine("Измененный: ");
        randArray.ModifyArray();
        randArray.PrintArray();
    }
}