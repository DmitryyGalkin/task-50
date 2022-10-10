/* Задача 50. Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента или же указание, 
 что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1
7 -> такого числа в массиве нет
 */
Console.Clear();

Console.WriteLine("Введите значение m:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение n:");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];



FillArray(array);
PrintArray(array);
SearchElmentArray(array);


void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }

}

void FillArray(int[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(0, 10);
        }
    }
}

void SearchElmentArray(int[,] array)
{
    Console.WriteLine("Введите значение x:");
    int x = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение y:");
    int y = int.Parse(Console.ReadLine()!);

    if (m < x && n < y)
        Console.WriteLine("такого числа в массиве нет");
    else

    {

        int elementValue = array[x, y];
        Console.WriteLine(elementValue);
    }
}