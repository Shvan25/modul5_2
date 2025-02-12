using System;

class Program
{
    static void Main(string[] args)
    {
        var result = GetArrayFromConsole(10);

        Console.WriteLine("Нужна ли сртировка массиву? (false/true)");

        bool sign = bool.Parse(Console.ReadLine());

        ShowArray(result, sign);
    }

    static int[] GetArrayFromConsole(int num = 5)
    {
        var result = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Ваш массив:");
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }

        return result;
    }
    static void ShowArray(int[] array, bool sign = false)
    {
        var result = array;

        if (sign)
        {
            result = SortArray(result);
        }

        Console.WriteLine("\nВаш массив:");
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
    static int[] SortArray(int[] array)
        {
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        k = array[i];
                        array[i] = array[j];
                        array[j] = k;
                    }
                }

            }

            return array;
        }
    }