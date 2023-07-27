/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(11);
    return array;
}

int CountMinimumStringSum(int[,] array)
{
    int size=array.GetLength(0);
    int [] stringNum = new int[size];
    int index, sum, min, mini=0;
    for(int i = 0; i<array.GetLength(0); i++)
    {
        sum=0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum=sum+array[i,j];
        }
        index=i;
        stringNum[index]=sum;
        Console.WriteLine(stringNum[index]);
    }
    min=stringNum[0];

    for (index = 0; index<size; index++)
        if (stringNum[index]<min)
        {
            min=stringNum[index];
            mini=index;
        }
    return mini;
}

void ShowArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)   
            Console.Write($"{array[i,j]}  ");
        Console.WriteLine();
    }   
}

int n=4, stringNumber;
int [,] array = new int[n,n];
array=FillArray(array);
ShowArray(array);
Console.WriteLine($"Минимальная сумма элементов в строке номер: {CountMinimumStringSum(array)+1}");
