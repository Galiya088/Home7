// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] GetArray(int rows, int cols, int min, int max)
{
    int[,] arr = new int[rows, cols];
    // int maxTemp = max + 1;
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    return arr;
}
 
void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(String.Format("{0,3} ", array[i, j]));
        }
        Console.WriteLine();
    }
}
int[] FindIndex(int[,] array, int num)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int[] result = new int[2];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (array[i, j] == num)
            {
                result[0] = i;
                result[1] = j;
                return result;
            }
        }
    }
    return null;
}

int sizeM = GetNum("Введите размер M: ");
int sizeN = GetNum("Введите размер N: ");
int findNum = GetNum("Введите число от 0 до 10: ");
int[,] array = GetArray(sizeM, sizeN, 0, 10);

PrintArray(array);

int[] arrayIndex = FindIndex(array, findNum);

if (arrayIndex == null) Console.WriteLine($"{findNum} => Такого числа нет");
else Console.WriteLine($"Индексы числа {findNum} => [{arrayIndex[0]},{arrayIndex[1]}]");
