using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());

        int count = 0;
        string[] array = new string[size];
        for (int i = 0; i < size; ++i)
        {
            Console.Write("Введите " + i + " элемент массива: ");
            array[i] = Console.ReadLine();
            if (array[i].Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        for (int i = 0, j = 0; i < size; ++i)
        {
            if (array[i].Length <= 3)
            {
                result[j++] = array[i];
            }
        }

        Console.Write("Result: [");
        Console.Write(string.Join(", ", result));
        Console.Write("]");
    }

}