using ConsoleApp1;
using Test;


internal class Program
{
    private static void Main(string[] args)
    {
        Array1 randArr = new Array1(3, false);
        randArr.PrintArray();
        Console.WriteLine("Среднее значение: " + randArr.Average());

        // Создание экземпляра класса с заполнением значениями, введенными пользователем
        Array1 usInpArr = new Array1(3, true);
        usInpArr.PrintArray();
        Console.WriteLine("Среднее значение: " + usInpArr.Average());

        Array1 arrRemover = new Array1(3, true);
        arrRemover.PrintArray();
        arrRemover.RemoveElements();
        Console.WriteLine("Mассив, где удалены все элементы, большие 100 по модулю: ");
        arrRemover.PrintArray();

        Array1 arrRemoveDupl = new Array1(3, true);
        arrRemoveDupl.PrintArray();
        Console.WriteLine("Массив, где удалены все повторяющиеся элементы: ");
        arrRemoveDupl.RemoveDuplicates();
        arrRemoveDupl.PrintArray();



        Console.WriteLine("Вводим размеры:");
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        Array2 array1 = new Array2(rows, columns);
        Console.WriteLine("Массив1:");
        array1.PrintArray2();
        Console.WriteLine($"Среднее: {array1.Average()}");
        Console.WriteLine($"Массив1 с четными строками в обратном порядке:");
        array1.InReverse();

        Array2 array2 = new Array2(rows, columns, true);
        Console.WriteLine("Массив2:");
        array2.PrintArray2();
        Console.WriteLine($"Среднее: {array2.Average()}");
        Console.WriteLine($"Массив2 с четными строками в обратном порядке:");
        array2.InReverse();




        Console.Write("Введите количество строк в ступенчатом массиве: ");

        int[] values = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Введите количество значений в строке {i + 1}: ");
            values[i] = int.Parse(Console.ReadLine());
        }

        Array3 randArr = new Array3(rows, values);

        Console.WriteLine("Ступенчатый массив с рандомными значениями:");
        randArr.PrintArray();

        Console.WriteLine($"Среднее: {randArr.Average()}");
        randArr.ModifyArray();

        foreach (double i in randArr.GetAverages())
        {
            Console.WriteLine($"Среднее для вложенного массива: {i}");
        }

        Console.WriteLine("Измененный: ");
        randArr.PrintArray();

        Array3 userArr = new Array3(rows);

        Console.WriteLine("\nСтупенчатый массив с вводом значений пользователем:");
        userArr.PrintArray();

        Console.WriteLine($"Среднее: {userArr.Average()}");

        foreach (double i in userArr.GetAverages())
        {
            Console.WriteLine($"Среднее для вложенного массива: {i}");
        }

        Console.WriteLine("Измененный: ");
        userArr.ModifyArray();
        userArr.PrintArray();
    }
}