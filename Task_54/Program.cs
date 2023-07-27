/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

using System.Buffers;
using System.Globalization;

int[,] FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(11);
    return array;
}

int[,] SortStringArray(int[,] array)
{
    int temp, max, maxi, maxk;
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            max=array[i,j];
            maxi=i;
            maxk=j;
            for (int k = j; k<array.GetLength(1); k++)
            {
                
                if (array[i,k] > max)
                {
                    temp=max;
                    array[maxi,maxk]=array[i,k];
                    max=array[i,k];
                    array[i,k]=temp;
                }
            } 
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)   
            Console.Write($"{array[i,j]}  ");
        Console.WriteLine();
    }   
    Console.WriteLine(); 
}

int m=3;
int n=8;
int [,] array= new int[m,n];
array=FillArray(array);
ShowArray(array);
array=SortStringArray(array);
ShowArray(array);